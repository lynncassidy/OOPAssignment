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
    public class MessageContentTests
    {
        //Test to check whether string is stored correctly 
        [TestMethod()]
        public void MessageContentTestSMS()
        {
            MessageContent messageContentSMS = new MessageContent("Here is some text");

          
            Assert.AreEqual(messageContentSMS.Text, "Here is some text");
        }

        
    }
}