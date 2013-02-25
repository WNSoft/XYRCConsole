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
    class ErrorMessage411 : ErrorRepliesMessage
    {
        public ErrorMessage411(String message) : base(message, 411, "ERR_NORECIPIENT", ":No recipient given (<command>)") { }
    }
}
