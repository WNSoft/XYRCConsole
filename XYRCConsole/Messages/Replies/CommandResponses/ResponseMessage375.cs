using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the start of the message of the day.
    /// </summary>
    class ResponseMessage375 : CommandResponsesMessage
    {
        public ResponseMessage375(String message) : base(message) { }
    }
}
