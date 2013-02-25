using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to list channels and their topics.
    /// </summary>
    class ListMessage : ChannelOperationsMessage
    {
        public ListMessage(String message) : base(message) { }
    }
}
