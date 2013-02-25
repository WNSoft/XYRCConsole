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
    class ResponseMessage244 : CommandResponsesMessage
    {
        public ResponseMessage244(String message) : base(message, 244, "RPL_STATSHLINE", "H <hostmask> * <servername>") { }
    }
}
