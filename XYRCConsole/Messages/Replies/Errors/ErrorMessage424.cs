using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Generic error message used to report a failed
    /// file operation during the processing of a
    /// message.
    /// </summary>
    class ErrorMessage424 : ErrorRepliesMessage
    {
        public ErrorMessage424(String message) : base(message, 424, "ERR_FILEERROR", ":File error doing <file op> on <file>") { }
    }
}
