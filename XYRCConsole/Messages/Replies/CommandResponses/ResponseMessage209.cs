using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to display trace class reply.  Returned by the server in
    /// response to the TRACE message.
    /// </summary>
    class ResponseMessage209 : CommandResponsesMessage
    {
        public ResponseMessage209(String message) : base(message) { }
    }
}
