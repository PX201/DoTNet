namespace Lab01
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public string EMail;
        public int PhoneNumber;
       
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName},  e-mail: {EMail}, Phone: {PhoneNumber}";
        }
        

    }
}
