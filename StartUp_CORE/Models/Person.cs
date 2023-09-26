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
                firstName = value; 
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
                lastName = value; 
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
        private List<String> phoneNumbers = new List<String>();
        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }
        public void addPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }

        private DateTime birthday;

        public DateTime Birthday
        {
            get 
            {
                return birthday;
            }
            set 
            {
                DateTime now = DateTime.Now;
                if (value.Day > now.Day || (value.Year - now.Year > 120))
                {
                    throw new Exception("Age to big or too small");
                } else
                {
                    birthday = value;
                }
            }
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - birthday.Year;
                if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
                {
                    age--;
                }
                return age;
            }
        }
        public Person(string firstname, string lastname, string address, string zip, string city)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
        }
    }
}
