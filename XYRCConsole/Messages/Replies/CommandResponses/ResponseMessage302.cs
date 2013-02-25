using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole.Messages.Replies.CommandResponses
{
    /// <summary>
    /// From: RFC 1459 (1993)
    /// Reply format used by USERHOST to list replies to
    /// the query list.  The reply string is composed as
    /// follows:
    /// 
    /// reply ::= nick['*'] '=' '+'|'-'hostname
    /// 
    /// The '*' indicates whether the client has registered
    /// as an Operator.  The '-' or '+' characters represent
    /// whether the client has set an AWAY message or not
    /// respectively.
    /// </summary>
    class ResponseMessage302 : CommandResponsesMessage
    {
        public ResponseMessage302(String message) : base(message, 302, "RPL_USERHOST", ":[<reply>{<space><reply>}]") { }
    }
}