using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    ///  Used to tell about quitting or dead servers
    /// </summary>
    class ServerQuitMessage : ConnectionRegistrationMessage
    {
        public ServerQuitMessage(String message) : base(message) { }
    }
}
