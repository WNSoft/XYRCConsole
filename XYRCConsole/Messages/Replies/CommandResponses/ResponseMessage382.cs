using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// If the REHASH option is used and an operator sends
    /// a REHASH message, an RPL_REHASHING is sent back to
    /// the operator.
    /// </summary>
    class ResponseMessage382 : CommandResponsesMessage
    {
        public ResponseMessage382(String message) : base(message, 382, "RPL_REHASHING", "<config file> :Rehashing") { }
    }
}
