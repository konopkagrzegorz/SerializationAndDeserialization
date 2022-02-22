using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    class Person
    {
        [JsonProperty]
        private string firstname;

        public Person(String firstname, String lastname, int age, String email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.email = email;
        }

        public string GetFirstname()
        {
            return firstname;
        }

        public void SetFirstname(string value)
        {
            firstname = value;
        }
        [JsonProperty]
        private string lastname;

        public string GetLastname()
        {
            return lastname;
        }

        public void SetLastname(string value)
        {
            lastname = value;
        }
        [JsonProperty]
        private int age;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }
        [JsonProperty]
        private string email;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }
    }
}
