using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned when a NICK message is processed that results
    /// in an attempt to change to a currently existing nickname.
    /// </summary>
    class ErrorMessage433 : ErrorRepliesMessage
    {
        public ErrorMessage433(String message) : base(message) { }
    }
}
