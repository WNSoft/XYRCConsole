using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to give users who are on a host running an IRC server a message asking them to please join IRC.
    /// </summary>
    class SummonMessage : OptionalMessage
    {
        public SummonMessage(String message) : base(message) { }
    }
}
