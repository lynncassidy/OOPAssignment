using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPLynn
{
    public class MMS : Message
    {
        //What exactly is this constructor doing ?
        // Taking string sender recipient and bool status and sending it to parent to create itself and then this object
      

        public MMS(string sender, string recipient, bool status, string text, string fileName, MessageType type)
            : base(sender, recipient, status, text, fileName, type)
        {

        }

    }

    class MMSContent
    {
        private bool picture;
        private bool audio;
        private bool video;

        //method to check if audio, video or image
        public bool MediaChecker() {
           
            return picture | audio | video;
        }

    }

    
     
}
