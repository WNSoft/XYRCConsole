using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the server is summoning a user.
    /// </summary>
    class ResponseMessage342 : CommandResponsesMessage
    {
        public ResponseMessage342(String message) : base(message) { }
    }
}
