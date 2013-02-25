using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Sent to a user who is either not on a channel which is mode +n or
    /// not a chanop (or mode +v) on a channel which has mode +m
    /// set and is trying to send a PRIVMSG message to that channel.
    /// </summary>
    class ErrorMessage404 : ErrorRepliesMessage
    {
        public ErrorMessage404(String message) : base(message) { }
    }
}
