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
    class ResponseMessage215 : CommandResponsesMessage
    {
        public ResponseMessage215(String message) : base(message, 215, "RPL_STATSILINE", "I <host> * <host> <port> <class>") { }
    }
}
