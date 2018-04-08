using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    public class Action
    {
        public string Command { get; set; }
        public string Parameter { get; set; }
        public string Value { get; set; }

        public Action(string Command,string Parameter="",string Value="")
        {
            this.Command = Command;
            this.Parameter = Parameter;
            this.Value = Value;
        }
        public override string ToString()
        {
            string action = Command;
            if (Parameter != string.Empty)
            {
                action += " - " + Parameter;
                if(Value != string.Empty)
                {
                    action += " - " + Value;
                }
            }
            return action;
        }
    }
}
