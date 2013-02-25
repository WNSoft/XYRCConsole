using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When replying to the TIME message, a server must send
    /// the reply using the RPL_TIME format above.  The string
    /// showing the time need only contain the correct day and
    /// time there.  There is no further requirement for the
    /// time string.
    /// </summary>
    class ResponseMessage391 : CommandResponsesMessage
    {
        public ResponseMessage391(String message) : base(message, 391, "RPL_TIME", "<server> :<string showing server's local time>") { }
    }
}
