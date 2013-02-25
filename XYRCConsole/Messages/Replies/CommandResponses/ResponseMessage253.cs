using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to show how many unknown connections the server has.
    /// </summary>
    class ResponseMessage253 : CommandResponsesMessage
    {
        public ResponseMessage253(String message) : base(message) { }
    }
}
