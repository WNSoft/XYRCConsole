using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to query for information about a nickname which no longer exists.
    /// </summary>
    class WhowasMessage : UserBasedQueriesMessage
    {
        public WhowasMessage(String message) : base(message) { }
    }
}
