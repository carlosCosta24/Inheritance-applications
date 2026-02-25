using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public class clsA {
            public virtual void Print() 
            { 
                Console.WriteLine("Hello from the base class");
            }
            public virtual void wink()
            {
                Console.WriteLine("Base class is winking :-)");
            }
        }
        public class clsB: clsA {
            public override void Print()
            {
                Console.WriteLine("Hello form the derived class");
            }
            public new void wink() 
            {
                Console.WriteLine("Derived class is winking :-)");
            }
        }
        public class clsHuman { 
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

            public void Speak() {

                Console.WriteLine($"Hi my name is: {FirstName} and i have {Age} years old");
            }
        }
        public class clsSex : clsHuman { 
            
            public string sex { get; set; }

            public void Intreduce() {

                Console.WriteLine($"I {FirstName} {LastName} i have {Age} years, Iam a {sex}");
            }
        }

        public class clsMember : clsSex { 
        
            public int Id { get; set; }
            public string Randk { get; set; }

            public void Show() { 
                Console.WriteLine($"I am the member number: {Id}, with rank: {Randk} My Name is: {FirstName} {LastName} i have: {Age} years, Iam a: {sex}");

            }
        }

        public class clsInfra { 
            public int Id { get; set; }
            public void Process()
            {
                Console.WriteLine($"the process id is : {Id}");
            }

        }
        class clsFront : clsInfra {
        
            public float Space { get; set; }
            public string Browser { get; set; }

            public void Info() {
                Console.WriteLine($"Hi form the process {Id}, with space of {Space} GB, working on the {Browser}");
            }
        }
        class clsBack : clsInfra
        {
            public string Api { get; set; }

            public string Health { get; set; }
            public void Info()
            {
                Console.WriteLine($"Hi form the process {Id}, with Health of {Health}, working on the {Api}");
            }

        }
        public abstract class Person { 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public abstract void Greet();

            public void SayBye() {
                Console.WriteLine("Good bye");
            }
        }
        public class Engineer : Person
        {

            public string Department { get; set; }
            public string Level { get; set; }

            public double Salary { get; set; }

            public override void Greet()
            {
                Console.WriteLine($"Hi I'am {FirstName} {LastName},my Id is:{Id}, the Engineer responsible " +
                    $"of the {Department}, with Level: {Level} and salary of: {Salary}");
            }
        }
        // Interface
        public interface IEngineer {
            string FirstName{ get; set; }
            string LastName { get; set; }
            string Department { get; set; }
            void Identfy();
            void Status(string StatusLevel);
        }
        public interface ITask { 
             string Build {  get; set; }
            string Test { get; set; }
            
            string Deploy {  get; set; }

            void FinalResult();


        }
        public class clsSWE : IEngineer, ITask
        {

            public string FirstName { set; get; }
            public string LastName { set; get; }
            public string Department { get; set; }

            public void Identfy()
            {
                Console.WriteLine("Hi From Implementation");
            }
            public void Status(string Status)
            {
                Console.WriteLine($"THis SWE have {Status} Status, in According with the last performance reviw");
            }
            public string Build { get; set; }
            public string Test { get; set; }
            public string Deploy { get; set; }

            public void FinalResult()
            {
                Console.WriteLine($"The Final Result after Building: {Build},Testing: {Test}, and Deploying: {Deploy} is Success");

            }
        }
        class clsContainer {
            private int ContainerId;
            public clsContainer(int ContainerId) 
            {
                this.ContainerId = ContainerId;
                
            }
            public void Greet() 
            {
                Console.WriteLine("Hello from the Container class");
            }
            public class clsInner { 
                private int InnerId;

            public clsInner(int InnerId) 
            { 
                this.InnerId = InnerId;
                

            }
            public void Greet()
            {
                    Console.WriteLine("Hello From the inner class");
            }
            public void AccessContainerId(clsContainer Container) 
            {
                    Console.WriteLine("Accessing the Container id from the inner class: " + Container.ContainerId);
            }

            }
        }

        class clsFirst 
        {
            public int x;
            public int y;
            clsEconomy ObjectEco = new clsEconomy();
            public void Print() 
            {
                Console.WriteLine("hello form the FirstClass ");
            }
            public void CallSecond()
            {
                Console.WriteLine("Calling method2 from class Economy ");
            }

            public void CallEco() { 
            
                ObjectEco.Greet();
            }
            
        }
        class clsEconomy 
        {
            public void Greet() 
            {
                Console.WriteLine("Economy class is saying hi");            
            }
        }


        
        static void Main(string[] args)
        {
            //clsEmployee Employee = new clsEmployee(10,"Carlos","Costa","MR",5000,"Engineering", "google");

            //Console.WriteLine("Printing the Object...");

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
            /*Console.WriteLine("ID: {0}", Employee.Id);
            Console.WriteLine("Title: {0}", Employee.Title);
            Console.WriteLine("Full Name: {0}", Employee.FullName);
            Console.WriteLine("Department Name: {0}", Employee.DepartmentName);
            Console.WriteLine("Salary: {0}", Employee.Salary);

            Employee.IncreaseSalaryBy(120);
            Console.WriteLine("After Salary Increase: {0}", Employee.Salary);
            */
            //upcasting 
            /*
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
            */
           /* 
            clsA ObjA = new clsA();
            Console.WriteLine("Base object: ");
            ObjA.Print();
            ObjA.wink();

            clsB ObjB = new clsB();
            Console.WriteLine("Derived class: ");
            ObjB.Print();
            ObjB.wink();

            //casting 
            Console.WriteLine("Casting to the base class: ");
            clsA UpCasting = new clsB();
            UpCasting.Print();
            UpCasting.wink();
           */
          /* clsMember FirstMember = new clsMember();
            FirstMember.FirstName = "Carlos";
            FirstMember.LastName = "Costa";
            FirstMember.Age = 20;
            FirstMember.sex = "M";
            FirstMember.Randk = "A+";
            FirstMember.Id = 1;

            FirstMember.Intreduce();
            FirstMember.Show();
            FirstMember.Speak();
          */
          /*clsFront Chrome = new clsFront();
            Chrome.Browser = "Chrome";
            Chrome.Space = 10;
            Chrome.Id = 1205;
            Chrome.Info();
            Chrome.Process();

            clsBack Next = new clsBack();
            Next.Id = 4528;
            Next.Health = "Good";
            Next.Api = "Nuxt";
            Next.Info();
            Next.Process();
          */
          /*
          Engineer Carlos = new Engineer();
            Carlos.Id = 245;
            Carlos.FirstName = "Carlos";
            Carlos.LastName = "Costa";
            Carlos.Salary = 758622;
            Carlos.Department = "Infrastructure";
            Carlos.Level = "Senior";
            Carlos.Greet();
          */
          /*
            clsSWE Carlos = new clsSWE();
            Carlos.Department = "Web";
            Carlos.FirstName = "Carlos";
            Carlos.LastName = "Costa";
                Carlos.Build = "Complet";
                Carlos.Test = "Complet";
                Carlos.Deploy = "Complet";
                Carlos.FinalResult();
            Carlos.Status("Achiver");
            */

            /*clsContainer Container = new clsContainer(563);
            clsContainer.clsInner Inner = new clsContainer.clsInner(857);

            Container.Greet();
            Inner.Greet();
            Inner.AccessContainerId(Container);*/

            clsFirst Obj1 = new clsFirst();
            Obj1.Print();
            Obj1.CallEco();

            Console.ReadKey();



        }
    }
}
