using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to invite users to a channel.
    /// </summary>
    class InviteMessage : ChannelOperationsMessage
    {
        public InviteMessage(String message) : base(message) { }
    }
}
