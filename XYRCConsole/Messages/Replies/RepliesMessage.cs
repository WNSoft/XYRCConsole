using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// The following is a list of numeric replies which are
    /// generated in response to the commands given above.
    /// Each numeric is given with its number, name and reply
    /// string.
    /// </summary>
    class RepliesMessage : Message
    {
        private int numeric;
        private String name;
        private String replyString;
        public RepliesMessage(String message, int numeric, String name, String replyString) : base(message)
        {
            this.numeric = numeric;
            this.name = name;
            this.replyString = replyString;
        }
        public int getNumeric()
        {
            return numeric;
        }
        public String getName()
        {
            return name;
        }
        public String getReplyString()
        {
            return replyString;
        }
    }
}
