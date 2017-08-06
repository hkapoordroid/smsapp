using System;
using System.Collections.Generic;
namespace XFSMS.Models
{
    public class Chat
    {
        string ChatTitle{ get; set; }
        string ChatIcon{ get; set; }
        List<Message> _Messages { get; set; }
        List<User> _Members { get; set; }

        public Chat()
        {
        }
    }
}
