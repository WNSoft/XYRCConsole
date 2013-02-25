using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned if trying to join an invite only channel.
    /// </summary>
    class ErrorMessage473 : ErrorRepliesMessage
    {
        public ErrorMessage473(String message) : base(message) { }
    }
}
