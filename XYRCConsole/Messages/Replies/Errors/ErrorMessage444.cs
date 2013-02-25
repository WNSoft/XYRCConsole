using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the summon after a SUMMON command for a
    /// user was unable to be performed since they were not
    /// logged in.
    /// </summary>
    class ErrorMessage444 : ErrorRepliesMessage
    {
        public ErrorMessage444(String message) : base(message, 444, "ERR_NOLOGIN", "<user> :User not logged in") { }
    }
}
