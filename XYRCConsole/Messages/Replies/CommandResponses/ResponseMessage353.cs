using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// To reply to a NAMES message, a reply pair consisting
    /// of RPL_NAMREPLY and RPL_ENDOFNAMES is sent by the
    /// server back to the client.  If there is no channel
    /// found as in the query, then only RPL_ENDOFNAMES is
    /// returned.  The exception to this is when a NAMES
    /// message is sent with no parameters and all visible
    /// channels and contents are sent back in a series of
    /// RPL_NAMEREPLY messages with a RPL_ENDOFNAMES to mark
    /// the end.
    /// </summary>
    class ResponseMessage353 : CommandResponsesMessage
    {
        public ResponseMessage353(String message) : base(message, 353, "RPL_NAMREPLY", "<channel> :[[@|+]<nick> [[@|+]<nick> [...]]]") { }
    }
}
