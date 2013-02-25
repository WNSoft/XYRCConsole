using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Miscellaneous
{
    /// <summary>
    ///  Used to cause a client-server connection to be
    ///  closed by the server which has the actual connection.
    /// </summary>
    class KillMessage : MiscellaneousMessage
    {
        public KillMessage(String message) : base(message) { }
    }
}
