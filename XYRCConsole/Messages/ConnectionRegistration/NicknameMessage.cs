using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to give user a nickname or change the previous one.
    /// </summary>
    class NicknameMessage : ConnectionRegistrationMessage
    {
        public NicknameMessage(String message) : base(message) { }
    }
}
