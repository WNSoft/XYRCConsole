using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to manipulate channels,
    /// their properties (channel modes), and their
    /// contents (typically clients).
    /// </summary>
    class ChannelOperationsMessage : Message
    {
        public ChannelOperationsMessage(String message) : base(message) { }
    }
}
