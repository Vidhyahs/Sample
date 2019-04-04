using System;
namespace PolyMorphism
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Employee[] employeArray = new Employee[3];
            for(int i = 0; i < employeArray.Length; i++)
            {
                switch (i.ToString())
                {
                
                    case "0": employeArray[i] = new Employee(); break;
                    case "1": employeArray[i] = new PartTimeEmployee(); break;
                    case "2": employeArray[i] = new FullTimeEmployee(); break;
                }
            }
        }
    }
    public class Employee
    {
        public string FirstName = "Naveen";
        public string LastName = "Alur";

        public virtual void PrintName()
        {
            Console.WriteLine($"My Firs Name is {FirstName} and Last Name {LastName}.. ");
        }
    }
    public class FullTimeEmployee:Employee
    {
        public override void PrintName()
        {
            Console.WriteLine($"Yes My name is {FirstName} {LastName} and im full time employeee...!");
        }
    }
    public class PartTimeEmployee:Employee
    {
        public override void PrintName()
        {
            Console.WriteLine($"Yes My name is {FirstName} {LastName} and im not full time employeee...!");
        }
    }
}