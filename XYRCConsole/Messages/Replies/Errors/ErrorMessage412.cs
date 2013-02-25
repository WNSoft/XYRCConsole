using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned by PRIVMSG to indicate that the message wasn't delivered
    /// for some reason.  No text to send.
    /// </summary>
    class ErrorMessage412 : ErrorRepliesMessage
    {
        public ErrorMessage412(String message) : base(message) { }
    }
}
