using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to answer a query about a client's own mode.
    /// </summary>
    class ResponseMessage221 : CommandResponsesMessage
    {
        public ResponseMessage221(String message) : base(message) { }
    }
}
