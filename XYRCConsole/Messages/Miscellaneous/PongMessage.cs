using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Miscellaneous
{
    /// <summary>
    /// Used to reply to a ping message.
    /// </summary>
    class PongMessage : MiscellaneousMessage
    {
        public PongMessage(String message) : base(message) { }
    }
}
