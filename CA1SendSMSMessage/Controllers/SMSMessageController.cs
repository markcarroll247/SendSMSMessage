using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA1SendSMSMessage.Models;
using System.Diagnostics;

namespace CA1SendSMSMessage.Controllers
{
    public class SMSMessageController : Controller
    {
        [HttpGet]
        // the area code and phoneNumber is send back as a query in the URL from the Contacts index page 
        public ActionResult Index(string areaCode, string phoneNumber)
        {

            return View("Index");
        }


        [HttpPost]
        public ActionResult Index(SMSMessage sms)
        {
            if (ModelState.IsValid)
            {
                // verifiying the entered Area Code and Phone Number match a Person in the contact list
                Contacts contactsIndex = new Contacts();
                string findContact = contactsIndex.findContact(sms.AreaCode, sms.PhoneNumber);

                // saves the name and surname of contact of a successfully sent message 
                ViewBag.Contact = findContact;

                if (findContact == "error")
                {
                    // if the contact does not exist, goes to the Error page with the form input
                    return View("Error", sms);
                }
                else
                {
                    // logs all successfully sent messages using the Logging model (Logging.cs)
                    Logging.writeToDeugger(sms.AreaCode, sms.PhoneNumber, sms.TextContent);
                    // if the contact does exist, goes to the Success page with the form input
                    return View("Success", sms);
                }
            }
            return View(sms);

        }


    }
}