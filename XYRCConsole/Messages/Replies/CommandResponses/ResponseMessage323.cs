using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate end of the response to a list command.
    /// </summary>
    class ResponseMessage323 : CommandResponsesMessage
    {
        public ResponseMessage323(String message) : base(message) { }
    }
}
