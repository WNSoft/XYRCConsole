using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the end of the reply to a names command.
    /// </summary>
    class ResponseMessage366 : CommandResponsesMessage
    {
        public ResponseMessage366(String message) : base(message) { }
    }
}
