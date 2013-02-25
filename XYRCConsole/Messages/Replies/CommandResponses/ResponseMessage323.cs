using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Replies RPL_LISTSTART, RPL_LIST, RPL_LISTEND mark
    /// the start, actual replies with data and end of the
    /// server's response to a LIST command.  If there are
    /// no channels available to return, only the start
    /// and end reply must be sent.
    /// </summary>
    class ResponseMessage323 : CommandResponsesMessage
    {
        public ResponseMessage323(String message) : base(message, 323, "RPL_LISTEND", ":End of /LIST") { }
    }
}
