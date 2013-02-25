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
    class ResponseMessage241 : CommandResponsesMessage
    {
        public ResponseMessage241(String message) : base(message, 241, "RPL_STATSLLINE", "L <hostmask> * <servername> <maxdepth>") { }
    }
}
