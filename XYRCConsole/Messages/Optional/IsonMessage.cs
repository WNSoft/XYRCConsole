using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to get a response about whether a given nickname is currently on IRC.
    /// </summary>
    class IsonMessage : OptionalMessage
    {
        public IsonMessage(String message) : base(message) { }
    }
}
