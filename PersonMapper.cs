using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationAndDeserialization
{
    static class PersonMapper
    {
        public static Person deserialize(String json)
        {
            Person person = JsonConvert.DeserializeObject<Person>(json);
            return person;
        }

        public static String serialize(Person person)
        {
            String json = JsonConvert.SerializeObject(person);
            return json;
        }
    }
}
