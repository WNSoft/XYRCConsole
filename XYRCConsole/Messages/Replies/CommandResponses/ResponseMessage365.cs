using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// In replying to the LINKS message, a server must send
    /// replies back using the RPL_LINKS numeric and mark the
    /// end of the list using an RPL_ENDOFLINKS reply
    /// </summary>
    class ResponseMessage365 : CommandResponsesMessage
    {
        public ResponseMessage365(String message) : base(message, 365, "RPL_ENDOFLINKS", "<mask> :End of /LINKS list") { }
    }
}
