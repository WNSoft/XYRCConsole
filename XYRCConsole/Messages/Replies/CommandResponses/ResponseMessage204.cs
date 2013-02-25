using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to display trace op reply.  Returned by the server in
    /// response to the TRACE message.
    /// </summary>
    class ResponseMessage204 : CommandResponsesMessage
    {
        public ResponseMessage204(String message) : base(message) { }
    }
}
