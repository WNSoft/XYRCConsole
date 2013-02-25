using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// To answer a query about a client's own mode,
    /// RPL_UMODEIS is sent back.
    /// </summary>
    class ResponseMessage221 : CommandResponsesMessage
    {
        public ResponseMessage221(String message) : base(message, 221, "RPL_UMODEIS", "<user mode string>") { }
    }
}
