using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server by numerous commands to indicate
    /// to the client that it didn't supply enough parameters.
    /// </summary>
    class ErrorMessage461 : ErrorRepliesMessage
    {
        public ErrorMessage461(String message) : base(message, 461, "ERR_NEEDMOREPARAMS", "<command> :Not enough parameters") { }
    }
}
