using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_applications
{
    internal class Program
    {
        public class clsPerson {

            public clsPerson(int Id, string FirstName, string LastName, string Title) { 
                this.Id = Id;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Title = Title;
            }
        
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Title { get; set; }   

            public string FullName{

                get
                {
                  return  FirstName + " " + LastName;
                }
            }
            public virtual void Greet()
            {
                Console.WriteLine($"Hi there I'm {FullName} and my title is: {Title}");
            }
        }
        public class clsEmployee : clsPerson {

            public clsEmployee(int Id, string FirstName, string LastName, string Title, float Salary, string Department, string Company) :
                base(Id, FirstName, LastName, Title)
            { 
                this.Salary = Salary;
                this.DepartmentName = Department;
                this.Company = Company;
            }
            public string Company { get; set; }
            public float Salary { get; set; }
            public string DepartmentName {  get; set; }
            public void IncreaseSalaryBy(float Amount) { 
                Salary += Amount;
            }
            public void Work() {
                Console.WriteLine($"Hi, I work in {Company} and my monthly income is {Salary}");
            }
            public override void Greet()
            {
                Console.WriteLine("Hello from the derived class");
                //accessing the print in the base class
                base.Greet();
            }
        }
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee(10,"Carlos","Costa","MR",5000,"Engineering", "google");

            Console.WriteLine("Printing the Object...");

           /*
            //person inherited 
            Employee.Id = 10;
            Employee.Title = "MR.";
            Employee.FirstName = "Carlos";
            Employee.LastName = "Costa";
           */
           /*
            //Employee properties
            Employee.DepartmentName = "Engineering";
            Employee.Salary = 5000;
            */
            Console.WriteLine("ID: {0}", Employee.Id);
            Console.WriteLine("Title: {0}", Employee.Title);
            Console.WriteLine("Full Name: {0}", Employee.FullName);
            Console.WriteLine("Department Name: {0}", Employee.DepartmentName);
            Console.WriteLine("Salary: {0}", Employee.Salary);

            Employee.IncreaseSalaryBy(120);
            Console.WriteLine("After Salary Increase: {0}", Employee.Salary);

            //upcasting 
            clsEmployee Employee2 = new clsEmployee ( 58, "Kique", "flipe","Mr",4200,"Customer service", "mersk");
            clsPerson UpCasting = Employee2;
            UpCasting.Greet();

            //downCasting
            clsPerson Person3 = new clsEmployee(13, "Karmen", "Falco", "Mrs", 2500, "Markting", "Firrera costa");
            clsEmployee Employee3 = (clsEmployee) Person3;
            Employee3.Work();

            //overriding
            clsPerson Carlos = new clsPerson(80, "Carlos", "Falco", "Mr");
            Carlos.Greet();
            Employee.Greet();





        }
    }
}
