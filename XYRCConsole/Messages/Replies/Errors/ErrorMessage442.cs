using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned by the server whenever a client tries to
    /// perform a channel effecting command for which the
    /// client isn't a member.
    /// </summary>
    class ErrorMessage442 : ErrorRepliesMessage
    {
        public ErrorMessage442(String message) : base(message) { }
    }
}
