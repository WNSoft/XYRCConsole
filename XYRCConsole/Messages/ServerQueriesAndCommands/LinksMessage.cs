using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Used to list all servers which are known by the
    /// server answering the query.
    /// </summary>
    class LinksMessage : ServerQueriesAndCommandsMessage
    {
        public LinksMessage(String message) : base(message) { }
    }
}
