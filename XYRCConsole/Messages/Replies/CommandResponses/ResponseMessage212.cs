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
    class ResponseMessage212 : CommandResponsesMessage
    {
        public ResponseMessage212(String message) : base(message, 212, "RPL_STATSCOMMANDS", "<command> <count>") { }
    }
}
