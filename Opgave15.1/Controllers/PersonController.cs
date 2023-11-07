using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Opgave15._1.Models;
using System.Text;

namespace Opgave15._1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> persons = new List<Person>
        {
            new Person(1,"Klopp"),
            new Person(2, "Robbo"),
            new Person(3, "Trent"),
            new Person(4, "Szobo"),
            new Person(5, "Bajcetic"),
            new Person(6, "Konate"),
            new Person(7, "Virgil"),
        };


        //GET Person by id
        [HttpGet]
        [Route("(id)")]
        public Person getPersonById(int id)
        {
            foreach (var person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return new Person(69, "Dont exist");
        }

        //GET list of people
        [HttpGet]
        [Route("all")]
        public List<Person> getPeople()
        {
            return persons;
        }

        [HttpPost]
        [Route("Add")]
        public void addPerson(Person person)
        {
            persons.Add(person);
        }

    }
}
