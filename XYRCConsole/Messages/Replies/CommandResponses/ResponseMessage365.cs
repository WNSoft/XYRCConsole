using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the end of the reply to a links command.
    /// </summary>
    class ResponseMessage365 : CommandResponsesMessage
    {
        public ResponseMessage365(String message) : base(message) { }
    }
}
