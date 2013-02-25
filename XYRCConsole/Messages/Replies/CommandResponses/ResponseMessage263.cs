using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used when a server drops a command without processing it.
    /// </summary>
    class ResponseMessage263 : CommandResponsesMessage
    {
        public ResponseMessage263(String message) : base(message) { }
    }
}
