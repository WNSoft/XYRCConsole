using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server to any link which tries to change
    /// part of the registered details (such as password or user
    /// details from second USER message).
    /// </summary>
    class ErrorMessage462 : ErrorRepliesMessage
    {
        public ErrorMessage462(String message) : base(message, 462, "ERR_ALREADYREGISTRED", ":You may not reregister") { }
    }
}
