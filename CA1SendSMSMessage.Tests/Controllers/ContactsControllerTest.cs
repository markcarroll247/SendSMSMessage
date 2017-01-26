using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA1SendSMSMessage;
using CA1SendSMSMessage.Controllers;
using CA1SendSMSMessage.Models;

namespace CA1SendSMSMessage.Tests.Controllers
{
    [TestClass]
    public class ContactsControllerTest
    {
        [TestMethod]
        public void ContactsControllerIndexView()
        {
            var controller = new ContactsController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}
