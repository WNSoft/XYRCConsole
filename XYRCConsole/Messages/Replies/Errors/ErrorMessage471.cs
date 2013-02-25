using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned if trying to join a full channel.
    /// </summary>
    class ErrorMessage471 : ErrorRepliesMessage
    {
        public ErrorMessage471(String message) : base(message) { }
    }
}
