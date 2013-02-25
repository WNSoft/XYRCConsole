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
    class ErrorMessage475 : ErrorRepliesMessage
    {
        public ErrorMessage475(String message) : base(message, 475, "ERR_BADCHANNELKEY", "<channel> :Cannot join channel (+k)") { }
    }
}
