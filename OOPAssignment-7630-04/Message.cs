using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn

{
    public class Message
    {
        private string sender { get => this.sender; set => this.sender = value; }
        private List <string> recipient { get => this.recipient; set => this.recipient = value; }
        private bool status { get => this.status; set => this.status = value; }


        // Constructor says user has to give these 3 things in order to work
        public Message(string sender, List<string> recipient, bool status)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.status = status;
           
        }



            public List<string> getRecipient()
            {
                Console.WriteLine("Enter the recipients number here: ");
                sender = Console.ReadLine();
                return (recipient);
            }

            public bool getReceivedStatus()
            {
                //if
                return (status);
            }

            public string getSender()
            {
                Console.WriteLine("Enter your number here: ");
                sender = Console.ReadLine();
                return (sender);
            }
            //Method to get recipient from user



        }
}
