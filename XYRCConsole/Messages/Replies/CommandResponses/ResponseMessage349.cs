using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// When listing the 'exception masks' for a given channel,
    /// a server is required to send the list back using the
    /// RPL_EXCEPTLIST and RPL_ENDOFEXCEPTLIST messages.  A
    /// separate RPL_EXCEPTLIST is sent for each active mask.
    /// After the masks have been listed (or if none present)
    /// a RPL_ENDOFEXCEPTLIST MUST be sent.
    /// </summary>
    class ResponseMessage349 : CommandResponsesMessage
    {
        public ResponseMessage349(String message) : base(message, 349, "RPL_ENDOFEXCEPTLIST", "<channel> :End of channel exception list") { }
    }
}
