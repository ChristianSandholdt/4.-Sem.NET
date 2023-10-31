namespace Opgave14._2.Models
{
    public class Person
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public int Age { get; set; }

        public Person(String firstname, String lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }
    }
}
