using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// No description in RFC 1459 (1993)
    /// </summary>
    class ResponseMessage218 : CommandResponsesMessage
    {
        public ResponseMessage218(String message) : base(message, 218, "RPL_STATSYLINE", "Y <class> <ping frequency> <connect frequency> <max sendq>") { }
    }
}
