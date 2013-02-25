using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned as a response to the SUMMON command. Must be
    /// returned by any server which does not implement it.
    /// </summary>
    class ErrorMessage445 : ErrorRepliesMessage
    {
        public ErrorMessage445(String message) : base(message) { }
    }
}
