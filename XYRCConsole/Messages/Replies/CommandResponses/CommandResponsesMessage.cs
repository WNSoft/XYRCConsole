using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Numeric non-error replies which are generated in response to a command.
    /// </summary>
    class CommandResponsesMessage : RepliesMessage
    {
        public CommandResponsesMessage(String message) : base(message) { }
    }
}
