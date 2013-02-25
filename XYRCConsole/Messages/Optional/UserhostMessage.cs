using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Optional
{
    /// <summary>
    /// Used to retrieve a list of information about up to 5 nicknames.
    /// </summary>
    class UserhostMessage : OptionalMessage
    {
        public UserhostMessage(String message) : base(message) { }
    }
}
