using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned by PRIVMSG to indicate that the message wasn't delivered
    /// for some reason.  Wildcard in toplevel domain.
    /// </summary>
    class ErrorMessage414 : ErrorRepliesMessage
    {
        public ErrorMessage414(String message) : base(message) { }
    }
}
