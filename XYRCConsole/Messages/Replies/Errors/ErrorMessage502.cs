using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Error sent to any user trying to view or change the
    /// user mode for a user other than themselves.
    /// </summary>
    class ErrorMessage502 : ErrorRepliesMessage
    {
        public ErrorMessage502(String message) : base(message, 502, "ERR_USERSDONTMATCH", ":Cant change mode for other users") { }
    }
}
