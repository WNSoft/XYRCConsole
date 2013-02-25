using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned to a registered client to indicate that the
    /// command sent is unknown by the server.
    /// </summary>
    class ErrorMessage421 : ErrorRepliesMessage
    {
        public ErrorMessage421(String message) : base(message) { }
    }
}
