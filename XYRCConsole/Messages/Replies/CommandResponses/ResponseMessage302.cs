using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used by USERHOST to list replies to the query list.
    /// </summary>
    class ResponseMessage302 : CommandResponsesMessage
    {
        public ResponseMessage302(String message) : base(message) { }
    }
}
