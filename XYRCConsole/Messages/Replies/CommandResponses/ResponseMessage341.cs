using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server to indicate that the
    /// attempted INVITE message was successful and is
    /// being passed onto the end client.
    /// </summary>
    class ResponseMessage341 : CommandResponsesMessage
    {
        public ResponseMessage341(String message) : base(message, 341, "RPL_INVITING", "<channel> <nick>") { }
    }
}
