using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to change the characteristics of a channel.
    /// </summary>
    class ChannelModesMessage : ModeMessage
    {
        public ChannelModesMessage(String message) : base(message) { }
    }
}
