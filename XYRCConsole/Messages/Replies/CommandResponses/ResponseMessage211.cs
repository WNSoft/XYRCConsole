using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to report statistics on a connection.
    /// </summary>
    class ResponseMessage211 : CommandResponsesMessage
    {
        public ResponseMessage211(String message) : base(message) { }
    }
}
