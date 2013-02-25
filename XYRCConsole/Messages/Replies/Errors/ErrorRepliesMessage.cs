using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Numeric error replies which are generated in response to a command.
    /// </summary>
    class ErrorRepliesMessage : RepliesMessage
    {
        public ErrorRepliesMessage(String message) : base(message) { }
    }
}
