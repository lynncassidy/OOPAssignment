using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn

{
    public abstract class Message
    {
        private string sender;
        public string Sender { get => this.sender; set => this.sender = value; }
        private string recipient;
        public string Recipient { get => this.recipient; set => this.recipient = value; }
        private bool status;
        public bool Status { get => this.status; set => this.status = value; }
        private MessageContent content;
        public MessageContent Content { get => this.content; set => this.content = value; }

       



        // Constructor says user has to give these 4 things in order to make message object 
        // Constructor makes message object
        public Message(string sender, string recipient, bool status, string text)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.status = status;
            this.content = new MessageContent(text);
        }

        //MMS
        public Message(string sender, string recipient, bool status, string text, string fileName, MessageType type)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.status = status;
            this.content = new MessageContent(text, type, fileName);
        }

        //Method that returns true if sent and false if not sent
        public bool isMessageSent()
        {
            return status;
        }

       
    }
}

