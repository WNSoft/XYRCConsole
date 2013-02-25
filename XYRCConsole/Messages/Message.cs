using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYRCConsole
{
    /// <summary>
    /// Messages sent to or from an IRC server.
    /// </summary>
    class Message
    {
        private String prefix = "";
        private String command = "";
        private String[] parameters = new string[] { };
        public Message(String message)
        {
            parse(message);
        }
        public Message(String prefix, String command, String[] parameters)
        {
            this.prefix = prefix;
            this.command = command;
            this.parameters = parameters;
        }
        public String getPrefix()
        {
            return prefix;
        }
        public String getCommand()
        {
            return command;
        }
        public String[] getParameters()
        {
            return parameters;
        }
        private void parse(String message)
        {
            int i = -1;
            int j = message.IndexOf(" :");
            String trailing = "";
            if (message.StartsWith(":"))
            {
                i = message.IndexOf(" ");
                prefix = message.Substring(1, i - 1);
            }
            if (j >= 0)
            {
                trailing = message.Substring(j + 2);
            }
            else
            {
                j = message.Length;
            }
            var commandAndParameters = message.Substring(i + 1, j - i - 1).Split(' ');
            command = commandAndParameters.First();
            if (commandAndParameters.Length > 1)
                parameters = commandAndParameters.Skip(1).ToArray();
            if (!String.IsNullOrEmpty(trailing))
            {
                parameters = parameters.Concat(new string[] { trailing }).ToArray();
            }
        }
    }
}
