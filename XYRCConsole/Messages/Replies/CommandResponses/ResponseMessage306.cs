using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent when the client sets an AWAY message.
    /// </summary>
    class ResponseMessage306 : CommandResponsesMessage
    {
        public ResponseMessage306(String message) : base(message) { }
    }
}
