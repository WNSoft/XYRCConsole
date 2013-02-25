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
    class ResponseMessage348 : CommandResponsesMessage
    {
        public ResponseMessage348(String message) : base(message, 348, "RPL_EXCEPTLIST", "<channel> <exceptionmask>") { }
    }
}
