using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Optional messages that are not required by server implementations.
    /// </summary>
    class OptionalMessage : Message
    {
        public OptionalMessage(String message) : base(message) { }
    }
}
