using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned by WHOWAS to indicate there is no history information for that nickname.
    /// </summary>
    class ErrorMessage406 : ErrorRepliesMessage
    {
        public ErrorMessage406(String message) : base(message) { }
    }
}
