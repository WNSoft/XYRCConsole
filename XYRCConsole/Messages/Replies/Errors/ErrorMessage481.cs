using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Any command requiring operator privileges to operate must
    /// return this error to indicate the attempt was unsuccessful.
    /// </summary>
    class ErrorMessage481 : ErrorRepliesMessage
    {
        public ErrorMessage481(String message) : base(message) { }
    }
}
