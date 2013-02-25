using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to forcibly remove a user from a channel.
    /// </summary>
    class KickMessage : ChannelOperationsMessage
    {
        public KickMessage(String message) : base(message) { }
    }
}
