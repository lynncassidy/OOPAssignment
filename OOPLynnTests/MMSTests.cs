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
    public class MessageTests
    {
        //Test to check if MMS message is created properly
        [TestMethod()]
        
        public void MMSTest()
            
        {
            MMS MMSMessage = new MMS("085123456", "John", true, "Hello here's a video","VideoMsg",  MessageType.Video );
        }

        //Test to check if MMS message can be created with empty text content.
        [TestMethod()]

        public void MMSTestBlankMessage()
        {
            MMS MMSMessage = new MMS("085123456", "John", true, "", "VideoMsg", MessageType.Video);
        }

    }
}