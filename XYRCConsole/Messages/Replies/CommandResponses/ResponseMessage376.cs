using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the end of the message of the day.
    /// </summary>
    class ResponseMessage376 : CommandResponsesMessage
    {
        public ResponseMessage376(String message) : base(message) { }
    }
}
