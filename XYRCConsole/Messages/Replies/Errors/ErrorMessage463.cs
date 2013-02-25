﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.Errors
{
    /// <summary>
    /// Returned to a client which attempts to register with a
    /// server which does not been setup to allow connections
    /// from the host the attempted connection is tried.
    /// </summary>
    class ErrorMessage463 : ErrorRepliesMessage
    {
        public ErrorMessage463(String message) : base(message) { }
    }
}
