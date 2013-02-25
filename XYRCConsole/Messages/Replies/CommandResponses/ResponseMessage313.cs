using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Replies 311 - 313, 317 - 319 are all replies
    /// generated in response to a WHOIS message.  Given that
    /// there are enough parameters present, the answering
    /// server must either formulate a reply out of the above
    /// numerics (if the query nick is found) or return an
    /// error reply.  The '*' in RPL_WHOISUSER is there as
    /// the literal character and not as a wild card.  For
    /// each reply set, only RPL_WHOISCHANNELS may appear
    /// more than once (for long lists of channel names).
    /// The '@' and '+' characters next to the channel name
    /// indicate whether a client is a channel operator or
    /// has been granted permission to speak on a moderated
    /// channel.  The RPL_ENDOFWHOIS reply is used to mark
    /// the end of processing a WHOIS message.
    /// </summary>
    class ResponseMessage313 : CommandResponsesMessage
    {
        public ResponseMessage313(String message) : base(message, 313, "RPL_WHOISOPERATOR", "<nick> :is an IRC operator") { }
    }
}
