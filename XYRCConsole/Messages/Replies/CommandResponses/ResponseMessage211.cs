﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// No description in RFC 1459 (1993)
    /// </summary>
    class ResponseMessage211 : CommandResponsesMessage
    {
        public ResponseMessage211(String message) : base(message, 211, "RPL_STATSLINKINFO", "<linkname> <sendq> <sent messages> <sent bytes> <received messages> <received bytes> <time open>") { }
    }
}
