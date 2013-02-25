using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// No description in RFC 1459 (1993)
    /// </summary>
    class ErrorMessage474 : ErrorRepliesMessage
    {
        public ErrorMessage474(String message) : base(message, 474, "ERR_BANNEDFROMCHAN", "<channel> :Cannot join channel (+b)") { }
    }
}
 