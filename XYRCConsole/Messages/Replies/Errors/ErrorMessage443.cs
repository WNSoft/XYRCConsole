using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned when a client tries to invite a user to
    /// a channel they are already on.
    /// </summary>
    class ErrorMessage443 : ErrorRepliesMessage
    {
        public ErrorMessage443(String message) : base(message) { }
    }
}
