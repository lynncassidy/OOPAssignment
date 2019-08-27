using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn
{
    public class SMS : Message
    {

        //Constructor 
        public SMS(string sender, List<string> recipient, bool status) : base(sender, recipient, status)
        {

        }
    }
    

    class SMSContent
    {
        private string messageContent;

        public SMSContent(string messageData )
        {
            messageContent = messageData;
        }


        public string getMessage()
        {
            return (messageContent);
        }
    }
}
