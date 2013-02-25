using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// No recipient given.
    /// </summary>
    class ErrorMessage411 : ErrorRepliesMessage
    {
        public ErrorMessage411(String message) : base(message) { }
    }
}
