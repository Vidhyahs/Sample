using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyWordSample
{
   public class CollectionOfClass
    {
        public int Id { get; set; }
    }
    public class Student:CollectionOfClass
    {
        public string StudentName { get; set; }

    }
    public class Employee:CollectionOfClass
    {
        public string EmployeeName { get; set; }
    }
    
}
