using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used by client to start listening a specific channel.
    /// </summary>
    class JoinMessage : ChannelOperationsMessage
    {
        public JoinMessage(String message) : base(message) { }
    }
}
