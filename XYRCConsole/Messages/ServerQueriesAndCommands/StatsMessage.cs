using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to query statistics of a certain server.
    /// </summary>
    class StatsMessage : ServerQueriesAndCommandsMessage
    {
        public StatsMessage(String message) : base(message) { }
    }
}
