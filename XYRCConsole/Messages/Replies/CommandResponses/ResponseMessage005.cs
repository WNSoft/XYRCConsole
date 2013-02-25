using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// Sent by the server to a user to suggest an alternative
    /// server.  This is often used when the connection is
    /// refused because the server is already full.
    /// </summary>
    class ResponseMessage005 : CommandResponsesMessage
    {
        public ResponseMessage005(String message) : base(message, 005, "RPL_BOUNCE", "Try server <server name>, port <port number>") { }
    }
}