using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to display trace unknown reply.  Returned by the server in
    /// response to the TRACE message.
    /// </summary>
    class ResponseMessage203 : CommandResponsesMessage
    {
        public ResponseMessage203(String message) : base(message) { }
    }
}
