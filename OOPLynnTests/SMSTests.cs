using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPLynn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn.Tests
{
    [TestClass()]
    public class SMSTests
    {
        //Test to see if SMS message is created correctly
        [TestMethod()]
        public void SMSTest()
        {
            SMS textMessage = new SMS("085123456", "John", true, "Hello, it's John"); 
        }

        //Test to check if content can be empty for text message
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        
        public void SMSBlankMessage()
        {
            SMS textMessage = new SMS("085123456", "John", true, "");
        }


    }
}