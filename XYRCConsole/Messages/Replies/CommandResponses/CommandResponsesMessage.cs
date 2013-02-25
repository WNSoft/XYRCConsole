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
    class CommandResponsesMessage : RepliesMessage
    {
        public CommandResponsesMessage(String message, int numeric, String name, String replyString) : base(message, numeric, name, replyString) { }
    }
}
