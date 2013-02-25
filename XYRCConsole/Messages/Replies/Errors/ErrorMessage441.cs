using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server to indicate that the target
    /// user of the command is not on the given channel.
    /// </summary>
    class ErrorMessage441 : ErrorRepliesMessage
    {
        public ErrorMessage441(String message) : base(message, 441, "ERR_USERNOTINCHANNEL", "<nick> <channel> :They aren't on that channel") { }
    }
}
