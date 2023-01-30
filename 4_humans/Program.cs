using System.Text.RegularExpressions;

namespace consoleApp
{
    class PlayerClass
    {
        private List<string> names = new List<string>();
        private List<string> gender = new List<string>();
        private List<string> speciality = new List<string>();
        private List<string> dateOfBirth = new List<string>();


        public PlayerClass(List<string> names, List<string> gender, List<string> speciality, List<string> dateOfBirth)
        {
            this.names = names;
            this.gender = gender;
            this.speciality = speciality;
            this.dateOfBirth = dateOfBirth;
        }

        public void add(String nameVar, String genderVar, String specialityVar, String dateOfBirthVar)
        {
            names.Add(nameVar);
            gender.Add(genderVar);
            speciality.Add(specialityVar);
            dateOfBirth.Add(dateOfBirthVar);
        }
        public void display()
        {
            if (names.Count > 0)
            {
                var today = DateTime.Today;

                Console.WriteLine("ФИО                      |       Пол             |               Должность        |      Дата рождения               |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < names.Count; i++)
                {
                    var age = ageCalc(dateOfBirth[i], i);
                    Console.WriteLine("{0}                              {1}                             {2}                             {3}({4})", names[i], gender[i], speciality[i], dateOfBirth[i], age);
                }
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }
        }
        public void quest()
        {
            if (names.Count > 0)
            {



                Console.WriteLine("ФИО                      |       Пол             |               Должность        |      Дата рождения               |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < names.Count; i++)
                {
                    var age = ageCalc(dateOfBirth[i], i);
                    if (speciality[i] == "инженер" && ((gender[i] == "М" && age >= 65) || (gender[i] == "Ж" && age >= 60)))
                    {
                        Console.WriteLine("{0}                    {1}                     {2}                         {3}({4})", names[i], gender[i], speciality[i], dateOfBirth[i], age);
                    }
                }
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }

        }
        private static int ageCalc(string time, int i)
        {
            var today = DateTime.Today;
            var age = today.Year - DateTime.Parse(time).Year;
            if (DateTime.Parse(time).Date > today.AddYears(-age)) age--;
            return age;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> gender = new List<string>();
            List<string> speciality = new List<string>();
            List<string> dateOfBirth = new List<string>();


            PlayerClass player = new PlayerClass(names, gender, speciality, dateOfBirth);

            string nameInput;
            string genderInput;
            string specialityInput;
            string dateOfBirthInput;

            string mode;

            while (true)
            {
                nameInput = "";
                genderInput = "";
                specialityInput = "";
                dateOfBirthInput = "";

                Console.WriteLine("Список(L) / Добавить(A) / Задание(Q)");

                mode = Console.ReadLine();
                if (mode == "l" || mode == "L")
                {
                    player.display();
                }
                else if (mode == "q" || mode == "Q")
                {
                    player.quest();
                }
                else if (mode == "a" || mode == "A")
                {
                    Console.WriteLine("Введите ФИО: ");
                    nameInput = Console.ReadLine();

                    Console.WriteLine("Введите пол: ");
                    while (!isValidGender(genderInput))
                    {
                        genderInput = Console.ReadLine();
                        if (!isValidGender(genderInput))
                        {
                            Console.WriteLine("Введите корректное значение!");
                        }
                    }
                    genderInput = genderInput.ToUpper(); // translate to CAPS form;

                    Console.WriteLine("Введите должность: ");
                    while (!isValidSpeciality(specialityInput))
                    {
                        specialityInput = Console.ReadLine();
                        if (!isValidSpeciality(specialityInput))
                        {
                            Console.WriteLine("Введите корректное значение!");
                        }
                    }
                    specialityInput = specialityInput.ToLower();
                    Console.WriteLine("Введите дату рождения: ");

                    bool successParseDate = false;
                    while (!successParseDate)
                    {
                        dateOfBirthInput = Console.ReadLine();
                        if (!isValidDate(dateOfBirthInput))
                        {
                            Console.WriteLine("Введите корректную дату! (regex err)");
                        }
                        else
                        {
                            try
                            {
                                DateTime dt = DateTime.Parse(dateOfBirthInput);
                                Console.WriteLine($"{dateOfBirthInput:d MMMM, yyyy}");
                                successParseDate = true;
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Введите корректную дату! (parsedate err)");
                            }
                        }

                    }

                    player.add(nameInput, genderInput, specialityInput, dateOfBirthInput);
                    Console.WriteLine("Запись добавлена");
                }
                else
                {
                    Console.WriteLine("Неправильная команда!");
                }
            }
        }
        public static bool isValidDate(string time)
        {
            Regex checkTime = new Regex("^(?:[0-3][0-9]).[0-1][0-9].[1-2][0-9][0-9][0-9]$");
            return checkTime.IsMatch(time);
        }

        public static bool isValidGender(string gender)
        {
            if (gender == "м" || gender == "М" || gender == "ж" || gender == "Ж")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isValidSpeciality(string speciality)
        {
            if (speciality.Length > 3 && speciality.Length < 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}