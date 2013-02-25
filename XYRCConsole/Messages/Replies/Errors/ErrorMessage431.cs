using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned when a nickname parameter expected for a
    /// command and isn't found.
    /// </summary>
    class ErrorMessage431 : ErrorRepliesMessage
    {
        public ErrorMessage431(String message) : base(message, 431, "ERR_NONICKNAMEGIVEN", ":No nickname given") { }
    }
}
