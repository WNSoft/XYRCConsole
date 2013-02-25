using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned after an attempt to connect and register yourself
    /// with a server which has been setup to explicitly deny
    /// connections to you.
    /// </summary>
    class ErrorMessage465 : ErrorRepliesMessage
    {
        public ErrorMessage465(String message) : base(message) { }
    }
}
