using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by a server to a client when it detects a
    /// nickname collision (registered of a NICK that already
    /// exists by another server)
    /// </summary>
    class ErrorMessage436 : ErrorRepliesMessage
    {
        public ErrorMessage436(String message) : base(message, 436, "ERR_NICKCOLLISION", "<nick> :Nickname collision KILL") { }
    }
}
