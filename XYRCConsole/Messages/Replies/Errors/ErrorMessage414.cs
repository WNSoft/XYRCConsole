using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// 412 - 414 are returned by PRIVMSG to indicate that the
    /// message wasn't delivered for some reason. ERR_NOTOPLEVEL
    /// and ERR_WILDTOPLEVEL are errors that are returned
    /// when an invalid use of "PRIVMSG $server" or
    /// "PRIVMSG #host" is attempted.
    /// </summary>
    class ErrorMessage414 : ErrorRepliesMessage
    {
        public ErrorMessage414(String message) : base(message, 414, "ERR_WILDTOPLEVEL", "<mask> :Wildcard in toplevel domain") { }
    }
}
