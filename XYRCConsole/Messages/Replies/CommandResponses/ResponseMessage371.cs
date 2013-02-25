using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// A server responding to an INFO message is required to
    /// send all its 'info' in a series of RPL_INFO messages
    /// with a RPL_ENDOFINFO reply to indicate the end of the
    /// replies.
    /// </summary>
    class ResponseMessage371 : CommandResponsesMessage
    {
        public ResponseMessage371(String message) : base(message, 371, "RPL_INFO", ":<string>") { }
    }
}
