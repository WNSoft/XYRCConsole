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
    class ResponseMessage243 : CommandResponsesMessage
    {
        public ResponseMessage243(String message) : base(message, 243, "RPL_STATSOLINE", "O <hostmask> * <name>") { }
    }
}
