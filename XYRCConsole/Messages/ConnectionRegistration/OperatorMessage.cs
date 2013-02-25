using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used by a normal user to obtain operator privileges.
    /// </summary>
    class OperatorMessage : ConnectionRegistrationMessage
    {
        public OperatorMessage(String message) : base(message) { }
    }
}
