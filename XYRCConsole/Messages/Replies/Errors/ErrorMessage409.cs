using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// PING or PONG message missing the originator parameter
    /// which is required since these commands must work without
    /// valid prefixes.
    /// </summary>
    class ErrorMessage409 : ErrorRepliesMessage
    {
        public ErrorMessage409(String message) : base(message, 409, "ERR_NOORIGIN", ":No origin specified") { }
    }
}
