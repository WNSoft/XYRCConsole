using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// When listing the 'invitations masks' for a given channel,
    /// a server is required to send the list back using the
    /// RPL_INVITELIST and RPL_ENDOFINVITELIST messages.  A
    /// separate RPL_INVITELIST is sent for each active mask.
    /// After the masks have been listed (or if none present) a
    /// RPL_ENDOFINVITELIST MUST be sent.
    /// </summary>
    class ResponseMessage347 : CommandResponsesMessage
    {
        public ResponseMessage347(String message) : base(message, 347, "RPL_ENDOFINVITELIST", "<channel> :End of channel invite list") { }
    }
}
