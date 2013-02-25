using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to query the version of the server program.
    /// </summary>
    class VersionMessage : ServerQueriesAndCommandsMessage
    {
        public VersionMessage(String message) : base(message) { }
    }
}
