using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA1SendSMSMessage.Models
{
    public class Contacts
    {
        // my contacts list
        public List<Person> ContactsList = new List<Person>()
            {
                new Person() { AreaCode="087", PhoneNumber = "1234567", FirstName="Liam", Surname="Farrell" },
                new Person() { AreaCode="087", PhoneNumber = "1111111", FirstName = "Mary", Surname="Dooley" },
                new Person() { AreaCode="087", PhoneNumber = "2222222", FirstName = "Crona", Surname="McMonagle" },
                new Person() { AreaCode="087", PhoneNumber = "3333333", FirstName = "Aoife", Surname="McMonagle" },
                new Person() { AreaCode="087", PhoneNumber = "4444444", FirstName = "Louise", Surname="Farrell" },
                new Person() { AreaCode="087", PhoneNumber = "5555555", FirstName = "Terry", Surname="McMonagle" },
                new Person() { AreaCode="087", PhoneNumber = "6666666", FirstName = "Michael", Surname="McMonagle" },
                new Person() { AreaCode="087", PhoneNumber = "7777777", FirstName = "Carol", Surname="O'Shea" },
                new Person() { AreaCode="087", PhoneNumber = "8888888", FirstName = "Ailish", Surname="O'Shea" },
                new Person() { AreaCode="087", PhoneNumber = "9999999", FirstName = "Cormac", Surname="O'Shea" }
            };




        public String findContact(string AreaCode, string PhoneNumber)
        {
            // searches to see if the AreaCode and PhoneNumber matches a contact
            var contact = ContactsList.FirstOrDefault(x => x.AreaCode == AreaCode && x.PhoneNumber == PhoneNumber);

            if (contact == null)
            {
                return "error";
            }
            else
            {
                // this returns the name and surname of a successfully sent message
                return contact.FirstName + " " + contact.Surname;
            }
        }

    }


}