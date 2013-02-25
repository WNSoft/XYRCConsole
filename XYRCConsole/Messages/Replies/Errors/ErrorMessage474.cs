using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned if trying to join a channel which the user is
    /// banned from.
    /// </summary>
    class ErrorMessage474 : ErrorRepliesMessage
    {
        public ErrorMessage474(String message) : base(message) { }
    }
}
 