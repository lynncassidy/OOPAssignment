using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLynn
{
    public class MMS : Message
    {
        private bool picture;
        private bool audio;
        private bool video;

        public MMS(string sender, List<string> recipient, bool status) : base(sender, recipient, status)
        {

        }
    }

    class MMSContent
    {
        //method to check if audio, video or image
    }
}
