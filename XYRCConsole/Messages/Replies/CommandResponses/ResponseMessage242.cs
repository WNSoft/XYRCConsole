using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to report the server uptime.
    /// </summary>
    class ResponseMessage242 : CommandResponsesMessage
    {
        public ResponseMessage242(String message) : base(message) { }
    }
}
