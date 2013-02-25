using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Used to indicate the given channel name is invalid.
    /// </summary>
    class ErrorMessage403 : ErrorRepliesMessage
    {
        public ErrorMessage403(String message) : base(message) { }
    }
}
