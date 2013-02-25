using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Any command requiring 'chanop' privileges (such as
    /// MODE messages) must return this error if the client
    /// making the attempt is not a chanop on the specified
    /// channel.
    /// </summary>
    class ErrorMessage482 : ErrorRepliesMessage
    {
        public ErrorMessage482(String message) : base(message, 482, "ERR_CHANOPRIVSNEEDED", "<channel> :You're not channel operator") { }
    }
}
