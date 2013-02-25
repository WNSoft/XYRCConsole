using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// When responding to the MOTD message and the MOTD file
    /// is found, the file is displayed line by line, with
    /// each line no longer than 80 characters, using
    /// RPL_MOTD format replies.  These should be surrounded
    /// by a RPL_MOTDSTART (before the RPL_MOTDs) and an
    /// RPL_ENDOFMOTD (after).
    /// </summary>
    class ResponseMessage376 : CommandResponsesMessage
    {
        public ResponseMessage376(String message) : base(message, 376, "RPL_ENDOFMOTD", ":End of /MOTD command") { }
    }
}
