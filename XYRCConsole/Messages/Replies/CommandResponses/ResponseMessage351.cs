using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Reply by the server showing its version details.
    /// The version is the version of the software being
    /// used (including any patchlevel revisions) and the
    /// debuglevel is used to indicate if the server is
    /// running in "debug mode".
    ///
    /// The "comments" field may contain any comments about
    /// the version or further version details.
    /// </summary>
    class ResponseMessage351 : CommandResponsesMessage
    {
        public ResponseMessage351(String message) : base(message, 351, "RPL_VERSION", "<version>.<debuglevel> <server> :<comments>") { }
    }
}
