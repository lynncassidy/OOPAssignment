using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn
{
    public class MessageContent
    {
        private MessageType type;
        public MessageType Type { get => this.type; }
        private string text;
        public string Text { get => this.text; }
        private string fileName;
        public string FileName { get => this.fileName; }


        //For SMS
        public MessageContent(string text)
        {
            this.text = text;
            this.type = MessageType.Text;
        }

        //For MMS
        public MessageContent(string text, MessageType type, string fileName)
        {
            this.type = type;
            this.fileName = fileName;
            this.text = text;
        }

    }
}
