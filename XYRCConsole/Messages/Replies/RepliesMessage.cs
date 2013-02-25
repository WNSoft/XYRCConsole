using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies
{
    /// <summary>
    /// Numeric replies which are generated in response to a command.
    /// </summary>
    class RepliesMessage : Message
    {
        public RepliesMessage(String message) : base(message) { }
    }
}
