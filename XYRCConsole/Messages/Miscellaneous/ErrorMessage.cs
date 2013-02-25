using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Miscellaneous
{
    /// <summary>
    /// Used by servers when reporting a serious or fatal error to its operators.
    /// </summary>
    class ErrorMessage : MiscellaneousMessage
    {
        public ErrorMessage(String message) : base(message) { }
    }
}
