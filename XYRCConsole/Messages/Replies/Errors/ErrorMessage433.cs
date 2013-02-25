using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned when a NICK message is processed that
    /// results in an attempt to change to a currently
    /// existing nickname.
    /// </summary>
    class ErrorMessage433 : ErrorRepliesMessage
    {
        public ErrorMessage433(String message) : base(message, 433, "ERR_NICKNAMEINUSE", "<nick> :Nickname is already in use") { }
    }
}
