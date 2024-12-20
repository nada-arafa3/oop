namespace oop
{
    #region session one

    #region 1

    public enum WeekDays
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday

    }

    #endregion
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #region 3
    enum Permission
    {
        None = 0,
        Read = 1 << 0,
        Write = 1 << 1,
        Delete = 1 << 2,
        Execute = 1 << 3
    }

    #endregion
    #region 4
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion

    #endregion


    #region session two 
    #region 1
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the Person
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #endregion

        #region 2

        struct Person2
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        #endregion

        #region part 3
        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        public struct HiringDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HiringDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public SecurityLevel SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public HiringDate HireDate { get; set; }

            // Property with validation for Gender
            private char _gender;
            public char Gender
            {
                get { return _gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                    {
                        _gender = value;
                    }
                    else
                    {
                        // Handle invalid input (e.g., set to default or throw exception)
                        _gender = 'U'; // Set to 'U' for Unknown
                    }
                }
            }

            public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }

            public override string ToString()
            {
                return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate.Month}/{HireDate.Day}/{HireDate.Year}, Gender: {Gender}";
            }
        }
        #endregion

        #endregion




        internal class Program
        {
            static void Main(string[] args)
            {
                #region session one 
                #region 1
                foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
                {
                    Console.WriteLine(day);
                };


                #endregion

                #region 2

                Console.WriteLine("enter a season ");
                string Useason = Console.ReadLine();

                if (Useason == Convert.ToString(Season.Spring)) { Console.WriteLine("xyz"); };
                if (Useason == Convert.ToString(Season.Summer)) { Console.WriteLine("xyz"); };
                if (Useason == Convert.ToString(Season.Winter)) { Console.WriteLine("xyz"); };
                if (Useason == Convert.ToString(Season.Autumn)) { Console.WriteLine("xyz"); };



                #endregion
                #region 3



                #endregion
                #region 4
                Console.WriteLine("enter a color name : ");
                string ucolor = Console.ReadLine();

                if (Enum.TryParse(typeof(Colors), ucolor, true, out var color) && Enum.IsDefined(typeof(Colors), color))
                {
                    Console.WriteLine($"{ucolor} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{ucolor} is not a primary color.");
                }


                #endregion
                #region 5



                #endregion

                #endregion

                /*********************************************/
                #region session two

                #region 1
                Person[] people = new Person[3];


                people[0] = new Person("nada", 30);
                people[1] = new Person("arafa", 25);
                people[2] = new Person("abdo", 35);


                Console.WriteLine("Details of Persons:");
                foreach (var person in people)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
                #endregion
                # region 2

                Person[] people2 = new Person[3];

                for (int i = 0; i < people.Length; i++)
                {
                    Console.WriteLine($"Enter details for person {i + 1}:");
                    Console.Write("Name: ");
                    people[i].Name = Console.ReadLine();
                    Console.Write("Age: ");
                    people[i].Age = int.Parse(Console.ReadLine());
                }

                Person oldestPerson = people[0];
                for (int i = 1; i < people.Length; i++)
                {
                    if (people[i].Age > oldestPerson.Age)
                    {
                        oldestPerson = people[i];
                    }
                }

                Console.WriteLine("The oldest person is:");
                Console.WriteLine($"Name: {oldestPerson.Name}");
                Console.WriteLine($"Age: {oldestPerson.Age}");



                #endregion
                #region 3
                // Create an array of employees
                Employee[] EmpArr = new Employee[3]
                {
            new Employee(1, "nada", SecurityLevel.DBA, 5000, new HiringDate(1, 1, 2020), 'M'),
            new Employee(2, "arafa", SecurityLevel.Guest, 2000, new HiringDate(5, 7, 2022), 'F'),
            new Employee(3, "sayed", SecurityLevel.DBA, 6000, new HiringDate(3, 12, 2021), 'M')
                };

                // Sort employees by hire date
                int boxingUnboxingCount = 0;
                Array.Sort(EmpArr, (x, y) =>
                {
                    boxingUnboxingCount += 2; // Boxing x and y
                    return x.HireDate.Year.CompareTo(y.HireDate.Year) == 0
                        ? x.HireDate.Month.CompareTo(y.HireDate.Month) == 0
                            ? x.HireDate.Day.CompareTo(y.HireDate.Day)
                            : x.HireDate.Month.CompareTo(y.HireDate.Month)
                        : x.HireDate.Year.CompareTo(y.HireDate.Year);
                });

                Console.WriteLine($"Boxing/Unboxing Count: {boxingUnboxingCount}");
                Console.WriteLine("Sorted Employees:");
                foreach (var employee in EmpArr)
                {
                    Console.WriteLine(employee);
                }

                Console.ReadLine();
            }
            #endregion


            #endregion

            /***********************************************/

            #region session four
            //MCQ
            // 1: b
            // 2: a
            // 3: b
            // 4: b
            // 5: d
            // 6: b
            // 7: c
            // 8: a
            // 9: b
            // 10: c
            /*********************************/

            #endregion




        }
        }
    }
