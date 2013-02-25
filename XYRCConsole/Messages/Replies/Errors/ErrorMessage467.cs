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
    class ErrorMessage467 : ErrorRepliesMessage
    {
        public ErrorMessage467(String message) : base(message, 467, "ERR_KEYSET", "<channel> :Channel key already set") { }
    }
}
