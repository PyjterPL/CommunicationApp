using Newtonsoft.Json;

namespace CommunicationApp
{
    internal class Payload
    {
        public string Command { get; }
        public string Login { get; }
        public string Token { get; }
        public string Parameter { get; }
        public string Value { get; }

        public Payload(string command, string login, string token, string parameter = "", string value = "")
        {
            Command = command;
            Login = login;
            Token = token;
            Parameter = parameter;
            Value = value;
        }


        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}