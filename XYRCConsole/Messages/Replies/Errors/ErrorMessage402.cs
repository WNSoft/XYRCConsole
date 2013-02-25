using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Used to indicate the server name given currently doesn't exist.
    /// </summary>
    class ErrorMessage402 : ErrorRepliesMessage
    {
        public ErrorMessage402(String message) : base(message) { }
    }
}
