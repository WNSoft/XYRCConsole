using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Miscellaneous
{
    /// <summary>
    /// Used to test the presence of an active client at the
    /// other end of the connection.
    /// </summary>
    class PingMessage : MiscellaneousMessage
    {
        public PingMessage(String message) : base(message) { }
    }
}
