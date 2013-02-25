using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to remove user from the list of active users for
    /// all given channels listed in the parameter string.
    /// </summary>
    class PartMessage : ChannelOperationsMessage
    {
        public PartMessage(String message) : base(message) { }
    }
}
