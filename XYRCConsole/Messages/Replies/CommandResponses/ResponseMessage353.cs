using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to display a list of users in listed channels.
    /// </summary>
    class ResponseMessage353 : CommandResponsesMessage
    {
        public ResponseMessage353(String message) : base(message) { }
    }
}
