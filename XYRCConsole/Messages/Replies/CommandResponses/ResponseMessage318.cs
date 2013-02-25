using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent to indicate the end of the whois list.
    /// </summary>
    class ResponseMessage318 : CommandResponsesMessage
    {
        public ResponseMessage318(String message) : base(message) { }
    }
}
