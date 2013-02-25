using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used by an operator to force a server to restart itself.
    /// </summary>
    class RestartCommandMessage : OptionalMessage
    {
        public RestartCommandMessage(String message) : base(message) { }
    }
}
