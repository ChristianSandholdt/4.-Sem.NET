namespace StartUp_CORE.Models
{
    public class Person
    {
        private string firstName;
        public string Firstname
        {
            get
            {
                return firstName;
            }
            set 
            { 
                Firstname = value; 
            }
        }

        private string lastName;
        public string Lastname
        {
            get
            {
                return lastName;
            }
            set 
            { 
                Lastname = value; 
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        private string zip;
        public string Zip
        {
            get
            {
                return zip;
            }
            set 
            { 
                zip = value; 
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string telephone;
        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }
        public Person(string firstname, string lastname, string address, string zip, string city, string telephone)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
            Telephone = telephone;
        }
    }
}
