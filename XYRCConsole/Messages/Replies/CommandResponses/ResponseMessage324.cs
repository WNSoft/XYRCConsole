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
    class ResponseMessage324 : CommandResponsesMessage
    {
        public ResponseMessage324(String message) : base(message, 324, "RPL_CHANNELMODEIS", "<channel> <mode> <mode params>") { }
    }
}
