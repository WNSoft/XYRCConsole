using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Sent upon connection.  Used to display user host.
    /// </summary>
    class ResponseMessage002 : CommandResponsesMessage
    {
        public ResponseMessage002(String message) : base(message) { }
    }
}
