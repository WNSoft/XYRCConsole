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
    class ErrorMessage471 : ErrorRepliesMessage
    {
        public ErrorMessage471(String message) : base(message, 471, "ERR_CHANNELISFULL", "<channel> :Cannot join channel (+l)") { }
    }
}
