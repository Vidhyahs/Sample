using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyWordSample
{
   public class Program
    {
        static void Main(string[] args)
        {
            CollectionOfClass clas = new CollectionOfClass();
            Student st = new Student();
            Employee et = new Employee();
            clas.Id = 123;
            st.Id = clas.Id;
            st.StudentName = "Naveen";

            et.Id = clas.Id;
            et.EmployeeName= "emplname";
            PrintParmObjects(st, et, clas);
            Console.WriteLine("\n");
            Console.ReadLine();
           
        }

        public static void PrintParmObjects(params object[] collection)
        {
            Console.Write("Your Objects are {0}", collection.Length);
            foreach(var singam in collection)
            {
                if (singam.GetType() == typeof(CollectionOfClass))
                {
                    var data = (CollectionOfClass)singam;
                    Console.WriteLine($"Common Id is {data.Id}");
                }
                if (singam.GetType() == typeof(Student))
                {
                    var data = (Student)singam;
                    Console.WriteLine($"Student name {data.StudentName} and his Id is {data.Id}");
                }
                if (singam.GetType() == typeof(Employee))
                {
                    var data = (Employee)singam;
                    Console.WriteLine($"Employee name {data.EmployeeName} and his Id is {data.Id}");

                }

            }
        }
    }
}
