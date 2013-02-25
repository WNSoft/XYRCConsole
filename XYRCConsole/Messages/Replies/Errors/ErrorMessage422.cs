using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Server's MOTD file could not be opened by the server.
    /// </summary>
    class ErrorMessage422 : ErrorRepliesMessage
    {
        public ErrorMessage422(String message) : base(message, 422, "ERR_NOMOTD", ":MOTD File is missing") { }
    }
}
