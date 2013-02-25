using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by a server answering a SUMMON message to
    /// indicate that it is summoning that user.
    /// </summary>
    class ResponseMessage342 : CommandResponsesMessage
    {
        public ResponseMessage342(String message) : base(message, 342, "RPL_SUMMONING", "<user> :Summoning user to IRC") { }
    }
}
