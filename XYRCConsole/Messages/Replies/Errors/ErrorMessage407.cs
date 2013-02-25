using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned to a client which is attempting to send PRIVMSG/NOTICE
    /// using the user@host destination format and for a user@host
    /// which has several occurrences.
    /// </summary>
    class ErrorMessage407 : ErrorRepliesMessage
    {
        public ErrorMessage407(String message) : base(message) { }
    }
}
