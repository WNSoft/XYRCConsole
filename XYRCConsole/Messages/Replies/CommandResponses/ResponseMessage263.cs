using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// When a server drops a command without processing it,
    /// it MUST use the reply RPL_TRYAGAIN to inform the
    /// originating client.
    /// </summary>
    class ResponseMessage263 : CommandResponsesMessage
    {
        public ResponseMessage263(String message) : base(message, 263, "RPL_TRYAGAIN", "<command> :Please wait a while and try again.") { }
    }
}
