using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent upon connection.  Used to welcome user.
    /// </summary>
    class ResponseMessage001 : CommandResponsesMessage
    {
        public ResponseMessage001(String message) : base(message) { }
    }
}
