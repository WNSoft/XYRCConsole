using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned if trying to join a channel with an invalid key.
    /// </summary>
    class ErrorMessage475 : ErrorRepliesMessage
    {
        public ErrorMessage475(String message) : base(message) { }
    }
}
