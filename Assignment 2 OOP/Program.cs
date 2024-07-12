using System.Reflection;

namespace Assignment_2_OOP
{
    internal class Program
    {
        /*  struct Person
          {
              public string Name { get; set; }
              public int Age { get; set; }


              public Person(string name, int age)
              {
                  Name = name;
                  Age = age;
              }


              public void DisplayDetails()
              {
                  Console.WriteLine($"Name: {Name}, Age: {Age}");
              }
          }*/

        /*  struct Person
          {
              public string Name { get; set; }
              public int Age { get; set; }

              public Person(string name, int age)
              {
                  Name = name;
                  Age = age;
              }
          }*/

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string SecurityLevel { get; set; }
            public decimal Salary { get; set; }
            public DateTime HireDate { get; set; }
            public string Gender { get; set; }
            public Employee(int id, string name, string securityLevel, decimal salary, DateTime hireDate, string gender)
            {
                ID = id;
                Name = name;
                SecurityLevel = securityLevel;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }
            public void DisplayDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"ID: {ID}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Security Level: {SecurityLevel}");
                Console.WriteLine($"Salary: {Salary:C}");
                Console.WriteLine($"Hire Date: {HireDate:MMMM dd, yyyy}");
                Console.WriteLine($"Gender: {Gender}");
            }
            public int CalculateYearsOfService()
            {
                DateTime today = DateTime.Today;
                int yearsOfService = today.Year - HireDate.Year;

                if (HireDate.Date > today.AddYears(-yearsOfService))
                {
                    yearsOfService--;
                }

                return yearsOfService;
            }
            static void Main(string[] args)
        {

                #region part 01

                #endregion
                //Part 02

                #region 1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
                /*  Person[] people = new Person[3];


                  people[0] = new Person("Alice", 30);
                  people[1] = new Person("Bob", 25);
                  people[2] = new Person("Charlie", 35);
                  Console.WriteLine("Details of persons in the array:");
                  foreach (Person person in people)
                  {
                      person.DisplayDetails();
                  }
                */
                #endregion
                #region 2 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

                /*  Person[] people = new Person[3];

                  for (int i = 0; i < people.Length; i++)
                  {
                      Console.WriteLine($"Enter details for person {i + 1}:");
                      Console.Write("Name: ");
                      string name = Console.ReadLine();
                      Console.Write("Age: ");
                      int age = int.Parse(Console.ReadLine());

                      people[i] = new Person(name, age);

                  }
                  // Finding the oldest person.......
                  Person oldestPerson = people[0];

                  for (int i = 1; i < people.Length; i++)
                  {
                      if (people[i].Age > oldestPerson.Age)
                      {
                          oldestPerson = people[i];
                      }
                  }
                  Console.WriteLine($"\nThe oldest person is:");
                  Console.WriteLine($"Name: {oldestPerson.Name}, Age: {oldestPerson.Age}");*/
                #endregion


                //Part03

                //Starting to make instance from the class......

                Employee employee1 = new Employee(
                        id: 1,
                        name: "Alice Johnson",
                        securityLevel: string.Senior,
                        salary: 80000m,
                        hireDate: new DateTime(2018, 3, 15),
                        gender: string.Female)
      

                Employee employee2 = new Employee(
                    id: 2,
                    name: "Bob Smith",
                    securityLevel: SecurityLevel.Mid,
                    salary: 60000m,
                    hireDate: new DateTime(2020, 7, 1),
                    gender: Gender.Male)



            }
    }
}
