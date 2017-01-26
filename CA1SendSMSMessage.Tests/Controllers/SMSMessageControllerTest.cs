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
    public class SMSMessageControllerTest
    {
        [TestMethod]
        public void TestIndexView()
        {
            var controller = new SMSMessageController();
            var result = controller.Index("087", "1234567") as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
        //this one works



        [TestMethod]
        public void TestIndexViewToErrorView()
        {         
            var model = new SMSMessage();
            var controller = new SMSMessageController();
            var result = controller.Index(model) as ViewResult;
            Assert.AreEqual("Error", result.ViewName);
        }
        // this one works


        [TestMethod]
        public void TestIndexViewToSuccessView()
        {
            var model = new SMSMessage();
            var controller = new SMSMessageController();
            var result = controller.Index(model) as ViewResult;

            Assert.AreEqual("Success", result.ViewName);
        }
        // this one doesn't work...
    }
}
