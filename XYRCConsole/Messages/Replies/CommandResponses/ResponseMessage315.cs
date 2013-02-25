using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// The RPL_WHOREPLY and RPL_ENDOFWHO pair are used
    /// to answer a WHO message.  The RPL_WHOREPLY is only
    /// sent if there is an appropriate match to the WHO
    /// query.  If there is a list of parameters supplied
    /// with a WHO message, a RPL_ENDOFWHO must be sent
    /// after processing each list item with name being
    /// the item.
    /// </summary>
    class ResponseMessage315 : CommandResponsesMessage
    {
        public ResponseMessage315(String message) : base(message, 315, "RPL_ENDOFWHO", "<name> :End of /WHO list") { }
    }
}
