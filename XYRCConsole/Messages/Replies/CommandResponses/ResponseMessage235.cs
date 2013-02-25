using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// When listing services in reply to a SERVLIST message,
    /// a server is required to send the list back using the
    /// RPL_SERVLIST and RPL_SERVLISTEND messages.  A separate
    /// RPL_SERVLIST is sent for each service.  After the
    /// services have been listed (or if none present) a
    /// RPL_SERVLISTEND MUST be sent.
    /// </summary>
    class ResponseMessage235 : CommandResponsesMessage
    {
        public ResponseMessage235(String message) : base(message, 235, "RPL_SERVLISTEND", "<mask> <type> :End of service listing") { }
    }
}
