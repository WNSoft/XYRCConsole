using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the end of a service listing.
    /// </summary>
    class ResponseMessage235 : CommandResponsesMessage
    {
        public ResponseMessage235(String message) : base(message) { }
    }
}
