using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// The server sends Replies 001 to 004 to a user upon
    /// successful registration.
    /// </summary>
    class ResponseMessage004 : CommandResponsesMessage
    {
        public ResponseMessage004(String message) : base(message, 004, "RPL_MYINFO", "<servername> <version> <available user modes> <available channel modes>") { }
    }
}
