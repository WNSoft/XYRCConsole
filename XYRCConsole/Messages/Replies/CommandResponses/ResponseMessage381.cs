using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// RPL_YOUREOPER is sent back to a client which has
    /// just successfully issued an OPER message and gained
    /// operator status.
    /// </summary>
    class ResponseMessage381 : CommandResponsesMessage
    {
        public ResponseMessage381(String message) : base(message, 381, "RPL_YOUREOPER", ":You are now an IRC operator") { }
    }
}
