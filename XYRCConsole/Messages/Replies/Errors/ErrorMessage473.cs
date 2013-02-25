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
    class ErrorMessage473 : ErrorRepliesMessage
    {
        public ErrorMessage473(String message) : base(message, 473, "ERR_INVITEONLYCHAN", "<channel> :Cannot join channel (+i)") { }
    }
}
