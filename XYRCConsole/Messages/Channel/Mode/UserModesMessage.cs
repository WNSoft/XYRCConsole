using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to change either how the client is seen
    /// by others or what 'extra' messages the client is sent.
    /// </summary>
    class UserModesMessage : ModeMessage
    {
        public UserModesMessage(String message) : base(message) { }
    }
}
