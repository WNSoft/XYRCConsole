using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server to indicate that the client
    /// must be registered before the server will allow it
    /// to be parsed in detail.
    /// </summary>
    class ErrorMessage451 : ErrorRepliesMessage
    {
        public ErrorMessage451(String message) : base(message, 451, "ERR_NOTREGISTERED", ":You have not registered") { }
    }
}
