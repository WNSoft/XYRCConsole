using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    ///  Used to indicate the end of the reply list for a who query.
    /// </summary>
    class ResponseMessage315 : CommandResponsesMessage
    {
        public ResponseMessage315(String message) : base(message) { }
    }
}
