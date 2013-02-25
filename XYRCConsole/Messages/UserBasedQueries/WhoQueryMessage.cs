using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used by a client to generate a query which
    /// returns a list of information which 'matches'
    /// the name parameter given by the client.
    /// In the absence of the name parameter, all
    /// visible users are listed.
    /// </summary>
    class WhoQueryMessage : UserBasedQueriesMessage
    {
        public WhoQueryMessage(String message) : base(message) { }
    }
}
