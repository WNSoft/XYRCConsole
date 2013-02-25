using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// If a client sends an OPER message and the server has not been
    /// configured to allow connections from the client's host as
    /// an operator, this error must be returned.
    /// </summary>
    class ErrorMessage491 : ErrorRepliesMessage
    {
        public ErrorMessage491(String message) : base(message) { }
    }
}
