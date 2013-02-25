using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Used to indicate the server name given currently
    /// doesn't exist.
    /// </summary>
    class ErrorMessage402 : ErrorRepliesMessage
    {
        public ErrorMessage402(String message) : base(message, 402, "ERR_NOSUCHSERVER", "<server name> :No such server") { }
    }
}
