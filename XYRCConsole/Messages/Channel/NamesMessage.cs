using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to list all nicknames that are visible on a
    /// channel.
    /// </summary>
    class NamesMessage : ChannelOperationsMessage
    {
        public NamesMessage(String message) : base(message) { }
    }
}
