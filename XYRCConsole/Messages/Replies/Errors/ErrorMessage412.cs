using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// 412 - 414 are returned by PRIVMSG to indicate that the
    /// message wasn't delivered for some reason.
    /// </summary>
    class ErrorMessage412 : ErrorRepliesMessage
    {
        public ErrorMessage412(String message) : base(message, 412, "ERR_NOTEXTTOSEND", ":No text to send") { }
    }
}
