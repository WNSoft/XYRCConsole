using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to set a 'connection password'.
    /// </summary>
    class PasswordMessage : ConnectionRegistrationMessage
    {
        public PasswordMessage(String message) : base(message) { }
    }
}
