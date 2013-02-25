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
    class ResponseMessage001 : CommandResponsesMessage
    {
        public ResponseMessage001(String message) : base(message, 001, "RPL_WELCOME", "Welcome to the Internet Relay Network <nick>!<user>@<host>") { }
    }
}
