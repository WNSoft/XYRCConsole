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
    class ResponseMessage216 : CommandResponsesMessage
    {
        public ResponseMessage216(String message) : base(message, 216, "RPL_STATSKLINE", "K <host> * <username> <port> <class>") { }
    }
}
