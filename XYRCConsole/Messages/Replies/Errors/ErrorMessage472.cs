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
    class ErrorMessage472 : ErrorRepliesMessage
    {
        public ErrorMessage472(String message) : base(message, 472, "ERR_UNKNOWNMODE", "<char> :is unknown mode char to me") { }
    }
}
