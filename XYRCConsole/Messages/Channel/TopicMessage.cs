using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to change or view the topic of a channel.
    /// </summary>
    class TopicMessage : ChannelOperationsMessage
    {
        public TopicMessage(String message) : base(message) { }
    }
}
