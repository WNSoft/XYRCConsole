using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Sent to a user who is either (a) not on a channel
    /// which is mode +n or (b) not a chanop (or mode +v) on
    /// a channel which has mode +m set and is trying to send
    /// a PRIVMSG message to that channel.
    /// </summary>
    class ErrorMessage404 : ErrorRepliesMessage
    {
        public ErrorMessage404(String message) : base(message, 404, "ERR_CANNOTSENDTOCHAN", "<channel name> :Cannot send to channel") { }
    }
}
