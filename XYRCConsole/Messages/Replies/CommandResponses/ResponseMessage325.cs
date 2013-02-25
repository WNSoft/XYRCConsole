using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// No description in RFC 2812 (2000)
    /// </summary>
    class ResponseMessage325 : CommandResponsesMessage
    {
        public ResponseMessage325(String message) : base(message, 325, "RPL_UNIQOPIS", "<channel> <nickname>") { }
    }
}
