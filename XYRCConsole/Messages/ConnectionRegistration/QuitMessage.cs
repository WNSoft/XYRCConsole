using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to end a client session.
    /// </summary>
    class QuitMessage : ConnectionRegistrationMessage
    {
        public QuitMessage(String message) : base(message) { }
    }
}
