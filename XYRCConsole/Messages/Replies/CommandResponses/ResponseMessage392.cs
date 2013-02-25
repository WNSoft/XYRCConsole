using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// If the USERS message is handled by a server, the
    /// replies RPL_USERSTART, RPL_USERS, RPL_ENDOFUSERS and
    /// RPL_NOUSERS are used.  RPL_USERSSTART must be sent
    /// first, following by either a sequence of RPL_USERS
    /// or a single RPL_NOUSER.  Following this is
    /// RPL_ENDOFUSERS.
    /// </summary>
    class ResponseMessage392 : CommandResponsesMessage
    {
        public ResponseMessage392(String message) : base(message, 392, "RPL_USERSSTART", ":UserID   Terminal  Host") { }
    }
}
