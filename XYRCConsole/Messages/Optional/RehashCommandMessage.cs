using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used by the operator to force the server to re-read and process its configuration file.
    /// </summary>
    class RehashCommandMessage : OptionalMessage
    {
        public RehashCommandMessage(String message) : base(message) { }
    }
}
