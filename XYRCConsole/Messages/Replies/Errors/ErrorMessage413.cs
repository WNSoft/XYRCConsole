using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned by PRIVMSG to indicate that the message wasn't delivered
    /// for some reason.  No toplevel domain specified.
    /// </summary>
    class ErrorMessage413 : ErrorRepliesMessage
    {
        public ErrorMessage413(String message) : base(message) { }
    }
}
