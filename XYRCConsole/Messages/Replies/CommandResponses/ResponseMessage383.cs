﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// Sent by the server to a service upon successful
    /// registration.
    /// </summary>
    class ResponseMessage383 : CommandResponsesMessage
    {
        public ResponseMessage383(String message) : base(message, 383, "RPL_YOURESERVICE", "You are service <servicename>") { }
    }
}
