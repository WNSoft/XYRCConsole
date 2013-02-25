using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// These replies are used with the AWAY command (if
    /// allowed).  RPL_AWAY is sent to any client sending a
    /// PRIVMSG to a client which is away.  RPL_AWAY is only
    /// sent by the server to which the client is connected.
    /// Replies RPL_UNAWAY and RPL_NOWAWAY are sent when the
    /// client removes and sets an AWAY message.
    /// </summary>
    class ResponseMessage305 : CommandResponsesMessage
    {
        public ResponseMessage305(String message) : base(message, 305, "RPL_UNAWAY", ":You are no longer marked as being away") { }
    }
}
