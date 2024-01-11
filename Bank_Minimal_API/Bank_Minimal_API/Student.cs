namespace Bank_Minimal_API
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public Student(int id, string firstName, string lastName, DateTime birthdate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }
    }
}
