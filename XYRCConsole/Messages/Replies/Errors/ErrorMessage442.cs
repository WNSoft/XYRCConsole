using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server whenever a client tries to
    /// perform a channel effecting command for which the
    /// client isn't a member.
    /// </summary>
    class ErrorMessage442 : ErrorRepliesMessage
    {
        public ErrorMessage442(String message) : base(message, 442, "ERR_NOTONCHANNEL", "<channel> :You're not on that channel") { }
    }
}
