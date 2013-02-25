using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to list services currently on the network.
    /// </summary>
    class ResponseMessage234 : CommandResponsesMessage
    {
        public ResponseMessage234(String message) : base(message) { }
    }
}
