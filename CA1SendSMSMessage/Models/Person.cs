using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CA1SendSMSMessage.Models
{
    public class Person
    {

        // this is only used to as the model for the Contacts Index, to extract the titles and values as per the contacts List

        [Display(Name = "Area Code")]
        public string AreaCode { get; set; }


        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Message")]
        public string TextContent { get; set; }


        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Surname")]
        public string Surname { get; set; }

    }

}