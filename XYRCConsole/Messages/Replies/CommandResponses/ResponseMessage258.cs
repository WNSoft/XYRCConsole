using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When replying to an ADMIN message, a server
    /// is expected to use replies RLP_ADMINME
    /// through to RPL_ADMINEMAIL and provide a text
    /// message with each.  For RPL_ADMINLOC1 a
    /// description of what city, state and country
    /// the server is in is expected, followed by
    /// details of the university and department
    /// (RPL_ADMINLOC2) and finally the administrative
    /// contact for the server (an email address here
    /// is required) in RPL_ADMINEMAIL.
    /// </summary>
    class ResponseMessage258 : CommandResponsesMessage
    {
        public ResponseMessage258(String message) : base(message, 258, "RPL_ADMINLOC2", ":<admin info>") { }
    }
}
