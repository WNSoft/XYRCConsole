using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Any attempts to use the KILL command on a server are to
    /// be refused and this error returned directly to the client.
    /// </summary>
    class ErrorMessage483 : ErrorRepliesMessage
    {
        public ErrorMessage483(String message) : base(message) { }
    }
}
