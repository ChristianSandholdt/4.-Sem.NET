using Opgave4;
DateTime myBirthday = new DateTime(2000, 8, 26);
Person p = new Person("Christian", myBirthday);
int age = 0;

Person.calcAge(myBirthday, out age);

Person.myNormalMethod();
