using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to query information about a particular user.
    /// </summary>
    class WhoisQueryMessage : UserBasedQueriesMessage
    {
        public WhoisQueryMessage(String message) : base(message) { }
    }
}
