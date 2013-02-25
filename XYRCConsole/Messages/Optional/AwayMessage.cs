using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to set an automatic reply string for any PRIVMSG commands directed at them.
    /// </summary>
    class AwayMessage : OptionalMessage
    {
        public AwayMessage(String message) : base(message) { }
    }
}
