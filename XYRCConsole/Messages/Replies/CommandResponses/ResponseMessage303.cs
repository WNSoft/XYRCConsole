using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Reply format used by ISON to list replies to the
    /// query list.
    /// </summary>
    class ResponseMessage303 : CommandResponsesMessage
    {
        public ResponseMessage303(String message) : base(message, 303, "RPL_ISON", ":[<nick> {<space><nick>}]") { }
    }
}