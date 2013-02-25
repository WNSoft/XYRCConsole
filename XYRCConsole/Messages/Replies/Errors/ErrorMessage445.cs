using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned as a response to the SUMMON command.  Must
    /// be returned by any server which does not implement it.
    /// </summary>
    class ErrorMessage445 : ErrorRepliesMessage
    {
        public ErrorMessage445(String message) : base(message, 445, "ERR_SUMMONDISABLED", ":SUMMON has been disabled") { }
    }
}
