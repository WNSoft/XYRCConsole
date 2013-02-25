using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent upon connection.  Used to show server info.
    /// </summary>
    class ResponseMessage004 : CommandResponsesMessage
    {
        public ResponseMessage004(String message) : base(message) { }
    }
}
