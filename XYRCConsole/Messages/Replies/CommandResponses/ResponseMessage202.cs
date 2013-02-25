﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// Used to display trace handshaking reply.  Returned by the server in
    /// response to the TRACE message.
    /// </summary>
    class ResponseMessage202: CommandResponsesMessage
    {
        public ResponseMessage202(String message) : base(message) { }
    }
}