using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    internal class Log
    {
        public List<Action> Actions { get; set; }
        public Response Response { get; set; }
        public Log()
        {
            this.Actions = new List<Action>();
        }
        public override string ToString()
        {
            short iterator = 0;
            string logInfo = "Actions:" + Environment.NewLine;
            foreach (Action Action in Actions)
            {
                iterator++;
                logInfo += iterator.ToString() + ". " + Action.ToString() + Environment.NewLine;
            }
            logInfo += Response.ToString(true);//important informations only
            return logInfo;
        }
    }
}
