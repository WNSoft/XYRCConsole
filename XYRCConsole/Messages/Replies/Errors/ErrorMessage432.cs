using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned after receiving a NICK message which contains
    /// characters which do not fall in the defined set.
    /// </summary>
    class ErrorMessage432 : ErrorRepliesMessage
    {
        public ErrorMessage432(String message) : base(message, 432, "ERR_ERRONEUSNICKNAME", "<nick> :Erroneus nickname") { }
    }
}
