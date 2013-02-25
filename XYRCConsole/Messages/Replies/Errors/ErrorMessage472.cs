using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned if mode is not recognized.
    /// </summary>
    class ErrorMessage472 : ErrorRepliesMessage
    {
        public ErrorMessage472(String message) : base(message) { }
    }
}
