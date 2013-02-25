using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Any attempts to use the KILL command on a server are
    /// to be refused and this error returned directly to the
    /// client.
    /// </summary>
    class ErrorMessage483 : ErrorRepliesMessage
    {
        public ErrorMessage483(String message) : base(message, 483, "ERR_CANTKILLSERVER", ":You cant kill a server!") { }
    }
}
