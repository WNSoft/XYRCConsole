using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used for finding details on a particular user or group of users.
    /// </summary>
    class UserBasedQueriesMessage : Message
    {
        public UserBasedQueriesMessage(String message) : base(message) { }
    }
}
