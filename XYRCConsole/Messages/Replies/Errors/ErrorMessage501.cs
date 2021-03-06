﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Returned by the server to indicate that a MODE message
    /// was sent with a nickname parameter and that the a mode
    /// flag sent was not recognized.
    /// </summary>
    class ErrorMessage501 : ErrorRepliesMessage
    {
        public ErrorMessage501(String message) : base(message, 501, "ERR_UMODEUNKNOWNFLAG", ":Unknown MODE flag") { }
    }
}
