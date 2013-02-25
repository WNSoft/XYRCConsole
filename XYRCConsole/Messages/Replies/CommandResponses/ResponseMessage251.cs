using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to show how many users, services, and servers the server has.
    /// </summary>
    class ResponseMessage251 : CommandResponsesMessage
    {
        public ResponseMessage251(String message) : base(message) { }
    }
}
