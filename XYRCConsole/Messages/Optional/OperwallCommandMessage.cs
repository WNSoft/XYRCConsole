using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to send a message to all operators currently online.
    /// </summary>
    class OperwallCommandMessage : OptionalMessage
    {
        public OperwallCommandMessage(String message) : base(message) { }
    }
}
