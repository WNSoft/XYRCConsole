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
    class ResponseMessage219 : CommandResponsesMessage
    {
        public ResponseMessage219(String message) : base(message, 219, "RPL_ENDOFSTATS", "<stats letter> :End of /STATS report") { }
    }
}
