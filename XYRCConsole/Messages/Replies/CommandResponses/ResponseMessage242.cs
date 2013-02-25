using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// No description in RFC 1459 (1993)
    /// </summary>
    class ResponseMessage242 : CommandResponsesMessage
    {
        public ResponseMessage242(String message) : base(message, 242, "RPL_STATSUPTIME", ":Server Up %d days %d:%02d:%02d") { }
    }
}
