using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent upon connection.  Used to show server creation date.
    /// </summary>
    class ResponseMessage003 : CommandResponsesMessage
    {
        public ResponseMessage003(String message) : base(message) { }
    }
}
