using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Generic error message used to report a failed file
    /// operation during the processing of a message.
    /// </summary>
    class ErrorMessage424 : ErrorRepliesMessage
    {
        public ErrorMessage424(String message) : base(message) { }
    }
}
