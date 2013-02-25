using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent when the client removes an AWAY message.
    /// </summary>
    class ResponseMessage305 : CommandResponsesMessage
    {
        public ResponseMessage305(String message) : base(message) { }
    }
}
