using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to indicate the end of stats report.
    /// </summary>
    class ResponseMessage219 : CommandResponsesMessage
    {
        public ResponseMessage219(String message) : base(message) { }
    }
}
