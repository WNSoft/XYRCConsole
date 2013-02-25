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
    class ResponseMessage214 : CommandResponsesMessage
    {
        public ResponseMessage214(String message) : base(message, 214, "RPL_STATSNLINE", "N <host> * <name> <port> <class>") { }
    }
}
