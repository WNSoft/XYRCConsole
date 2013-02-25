using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Server's MOTD file could not be opened by the server.
    /// </summary>
    class ErrorMessage422 : ErrorRepliesMessage
    {
        public ErrorMessage422(String message) : base(message) { }
    }
}
