namespace Interface.Model
{
    public class Student : Employee
    {
        public string type;
        public Student(int _Id, string _Name, string type)
        {
            this.Name = _Name;
            this.Id = _Id;

            foreach (var item in TypeOfEmplyee)
            {
                if (item.Equals(type))
                {

                }
            }
        }

    }
}
