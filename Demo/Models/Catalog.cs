using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Catalog
    {
        private Dictionary<string, Person> _contact = new Dictionary<string, Person>();

        public string Name { get; set; }

        public Dictionary<string, Person> Contact { get { return _contact; } }

        public Person this[string phoneNumber]
        {
            get
            {
                Contact.TryGetValue(phoneNumber, out Person p);
                return p;
            }
            set
            {
                if (!Contact.ContainsKey(phoneNumber))
                {
                    Contact.Add(value.PhoneNumber, value);
                }
                else
                {
                    Contact[phoneNumber] = value;
                }
            }
        }

        public void AddPerson(Person p)
        {
            _contact.Add(p.PhoneNumber, p);
        }

        public void RemovePerson(string phoneNumber)
        {
            _contact.Remove(phoneNumber);
        }

    }
}
