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
    class ResponseMessage213 : CommandResponsesMessage
    {
        public ResponseMessage213(String message) : base(message, 213, "RPL_STATSCLINE", "C <host> * <name> <port> <class>") { }
    }
}
