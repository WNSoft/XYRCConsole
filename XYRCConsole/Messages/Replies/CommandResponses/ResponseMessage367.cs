using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When listing the active 'bans' for a given channel,
    /// a server is required to send the list back using the
    /// RPL_BANLIST and RPL_ENDOFBANLIST messages.  A separate
    /// RPL_BANLIST is sent for each active banid.  After the
    /// banids have been listed (or if none present) a
    /// RPL_ENDOFBANLIST must be sent.
    /// </summary>
    class ResponseMessage367 : CommandResponsesMessage
    {
        public ResponseMessage367(String message) : base(message, 367, "RPL_BANLIST", "<channel> <banid>") { }
    }
}
