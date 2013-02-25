using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to change mode of usernames and channels.
    /// </summary>
    class ModeMessage : ChannelOperationsMessage
    {
        public ModeMessage(String message) : base(message) { }
    }
}
