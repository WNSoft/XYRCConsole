using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to show how many clients and servers the server has.
    /// </summary>
    class ResponseMessage255 : CommandResponsesMessage
    {
        public ResponseMessage255(String message) : base(message) { }
    }
}
