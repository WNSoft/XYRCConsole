using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Sent to a user when they have joined the maximum
    /// number of allowed channels and they try to join
    /// another channel.
    /// </summary>
    class ErrorMessage405 : ErrorRepliesMessage
    {
        public ErrorMessage405(String message) : base(message, 405, "ERR_TOOMANYCHANNELS", "<channel name> :You have joined too many channels") { }
    }
}
