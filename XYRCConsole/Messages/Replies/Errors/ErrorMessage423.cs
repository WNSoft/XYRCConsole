using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by a server in response to an ADMIN message
    /// when there is an error in finding the appropriate
    /// information.
    /// </summary>
    class ErrorMessage423 : ErrorRepliesMessage
    {
        public ErrorMessage423(String message) : base(message, 423, "ERR_NOADMININFO", "<server> :No administrative info available") { }
    }
}
