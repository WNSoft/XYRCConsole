using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to show how many channels the server has.
    /// </summary>
    class ResponseMessage254 : CommandResponsesMessage
    {
        public ResponseMessage254(String message) : base(message) { }
    }
}
