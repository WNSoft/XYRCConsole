using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent by the server to a user to suggest an alternative server.
    /// </summary>
    class ResponseMessage005 : CommandResponsesMessage
    {
        public ResponseMessage005(String message) : base(message) { }
    }
}
