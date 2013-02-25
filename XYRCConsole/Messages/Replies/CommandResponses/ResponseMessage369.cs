using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When replying to a WHOWAS message, a server must use
    /// the replies RPL_WHOWASUSER, RPL_WHOISSERVER or
    /// ERR_WASNOSUCHNICK for each nickname in the presented
    /// list.  At the end of all reply batches, there must
    /// be RPL_ENDOFWHOWAS (even if there was only one reply
    /// and it was an error).
    /// </summary>
    class ResponseMessage369 : CommandResponsesMessage
    {
        public ResponseMessage369(String message) : base(message, 369, "RPL_ENDOFWHOWAS", "<nick> :End of WHOWAS") { }
    }
}
