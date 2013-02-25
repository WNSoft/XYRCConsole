using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Used to indicate the given channel name is invalid.
    /// </summary>
    class ErrorMessage403 : ErrorRepliesMessage
    {
        public ErrorMessage403(String message) : base(message, 403, "ERR_NOSUCHCHANNEL", "<channel name> :No such channel") { }
    }
}
