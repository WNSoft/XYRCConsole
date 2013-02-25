using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// When replying to a WHOWAS message, a server must use
    /// the replies RPL_WHOWASUSER, RPL_WHOISSERVER or
    /// ERR_WASNOSUCHNICK for each nickname in the presented
    /// list.  At the end of all reply batches, there must
    /// be RPL_ENDOFWHOWAS (even if there was only one reply
    /// and it was an error).
    /// </summary>
    class ResponseMessage314 : CommandResponsesMessage
    {
        public ResponseMessage314(String message) : base(message, 314, "RPL_WHOWASUSER", "<nick> <user> <host> * :<real name>") { }
    }
}
