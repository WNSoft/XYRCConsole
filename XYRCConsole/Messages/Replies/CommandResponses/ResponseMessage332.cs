using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When sending a TOPIC message to determine the
    /// channel topic, one of two replies is sent.  If
    /// the topic is set, RPL_TOPIC is sent back else
    /// RPL_NOTOPIC.
    /// </summary>
    class ResponseMessage332 : CommandResponsesMessage
    {
        public ResponseMessage332(String message) : base(message, 332, "RPL_TOPIC", "<channel> :<topic>") { }
    }
}
