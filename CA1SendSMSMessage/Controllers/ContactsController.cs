using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA1SendSMSMessage.Models;

namespace CA1SendSMSMessage.Controllers
{
    public class ContactsController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            // instantiates the list of contacts
            Contacts contactsIndex = new Contacts();
            
            // returns a view of the list of contacts
            return View("Index", contactsIndex.ContactsList);
        }

    }
}