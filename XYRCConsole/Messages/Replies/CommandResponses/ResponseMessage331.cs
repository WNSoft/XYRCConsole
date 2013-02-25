using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate there is no channel topic.
    /// </summary>
    class ResponseMessage331 : CommandResponsesMessage
    {
        public ResponseMessage331(String message) : base(message) { }
    }
}
