using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned to a registered client to indicate that the
    /// command sent is unknown by the server.
    /// </summary>
    class ErrorMessage421 : ErrorRepliesMessage
    {
        public ErrorMessage421(String message) : base(message, 421, "ERR_UNKNOWNCOMMAND", "<command> :Unknown command") { }
    }
}
