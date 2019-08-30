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
        public SMS(string sender, string recipient, bool status, string content) : base(sender, recipient, status, content)
        {

        }

    }   
    
}
    
    // Method to store text data 
    //class SMSContent
    //{
    //    private string messageContent;

    //    public SMSContent(string messageData )
    //    {
    //        messageContent = messageData;
    //    }


        //public string getMessage()
        //{
        //    return (messageContent);
        //}

        //Message GROUP
        
  
