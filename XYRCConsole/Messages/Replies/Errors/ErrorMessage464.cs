using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned to indicate a failed attempt at registering a
    /// connection for which a password was required and was
    /// either not given or incorrect.
    /// </summary>
    class ErrorMessage464 : ErrorRepliesMessage
    {
        public ErrorMessage464(String message) : base(message) { }
    }
}
