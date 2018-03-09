using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownManager
{
    public class Messages
    {
        public Messages(string m, string t)
        {
            message = m;
            messageType = t;
        }

        private string message;
        private string messageType;

        public string getMessage()
        {
            return message;
        }
        public string getMessageType()
        {
            return messageType;
        }
    }
}
