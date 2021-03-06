﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 2812 (2000)
    /// The RPL_TRACE* are all returned by the server in
    /// response to the TRACE message.  How many are
    /// returned is dependent on the TRACE message and
    /// whether it was sent by an operator or not.  There
    /// is no predefined order for which occurs first.
    /// Replies RPL_TRACEUNKNOWN, RPL_TRACECONNECTING and
    /// RPL_TRACEHANDSHAKE are all used for connections
    /// which have not been fully established and are either
    /// unknown, still attempting to connect or in the
    /// process of completing the 'server handshake'.
    /// RPL_TRACELINK is sent by any server which handles
    /// a TRACE message and has to pass it on to another
    /// server.  The list of RPL_TRACELINKs sent in
    /// response to a TRACE command traversing the IRC
    /// network should reflect the actual connectivity of
    /// the servers themselves along that path.
    /// RPL_TRACENEWTYPE is to be used for any connection
    /// which does not fit in the other categories but is
    /// being displayed anyway.
    /// RPL_TRACEEND is sent to indicate the end of the list.
    /// </summary>
    class ResponseMessage262 : CommandResponsesMessage
    {
        public ResponseMessage262(String message) : base(message, 262, "RPL_TRACEEND", "<server name> <version & debug level> :End of TRACE") { }
    }
}
