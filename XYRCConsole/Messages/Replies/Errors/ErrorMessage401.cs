using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Used to indicate the nickname parameter supplied
    /// to a command is currently unused.
    /// </summary>
    class ErrorMessage401 : ErrorRepliesMessage
    {
        public ErrorMessage401(String message) : base(message, 401, "ERR_NOSUCHNICK", "<nickname> :No such nick/channel") { }
    }
}
