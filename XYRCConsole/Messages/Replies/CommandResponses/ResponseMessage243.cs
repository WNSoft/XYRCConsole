using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to report the allowed hosts from where user
    /// may become IRC operators.
    /// </summary>
    class ResponseMessage243 : CommandResponsesMessage
    {
        public ResponseMessage243(String message) : base(message) { }
    }
}
