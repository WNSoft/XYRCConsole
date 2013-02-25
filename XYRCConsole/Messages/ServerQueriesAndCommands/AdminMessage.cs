using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to find the name of the administrator of the given server.
    /// </summary>
    class AdminMessage : ServerQueriesAndCommandsMessage
    {
        public AdminMessage(String message) : base(message) { }
    }
}
