using System.Collections.Generic;

namespace Interface.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> TypeOfEmplyee = new List<string>()
        {
            "Part Time",
            "Full Time",
            "Student"
        };
    }
}
