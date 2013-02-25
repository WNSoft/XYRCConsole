using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// In processing an LUSERS message, the server
    /// sends a set of replies from RPL_LUSERCLIENT,
    /// RPL_LUSEROP, RPL_USERUNKNOWN,
    /// RPL_LUSERCHANNELS and RPL_LUSERME.  When
    /// replying, a server must send back
    /// RPL_LUSERCLIENT and RPL_LUSERME.  The other
    /// replies are only sent back if a non-zero count
    /// is found for them.
    /// </summary>
    class ResponseMessage252 : CommandResponsesMessage
    {
        public ResponseMessage252(String message) : base(message, 252, "RPL_LUSEROP", "<integer> :operator(s) online") { }
    }
}
