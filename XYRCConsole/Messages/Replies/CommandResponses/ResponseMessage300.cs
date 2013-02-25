using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Dummy reply number. Not used.
    /// </summary>
    class ResponseMessage300 : CommandResponsesMessage
    {
        public ResponseMessage300(String message) : base(message, 300, "RPL_NONE", "") { }
    }
}