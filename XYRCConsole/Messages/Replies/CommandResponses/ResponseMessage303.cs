using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Reply used by ISON to list replies to the query list.
    /// </summary>
    class ResponseMessage303 : CommandResponsesMessage
    {
        public ResponseMessage303(String message) : base(message) { }
    }
}
