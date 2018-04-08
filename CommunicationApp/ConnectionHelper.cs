using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp
{
    internal static class ConnectionHelper
    {
        public static string Login = "pyjterpl93@gmail.com.google";
        public static string Token = "D5EA4D0B5D74A644E91E51E709CC6C52";
        private static string chaarrAdress = "https://chaarr.future-processing.pl/";
        private static string simulationAdress = "https://simulation.future-processing.pl/";
        public static RestRequest CreateRequest(string payload = "")
        {
            RestRequest request;
            if (payload == "")
            {
                request = new RestRequest(Method.GET);
            }
            else
            {
                request = new RestRequest(Method.POST);
            }

            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");

            request.AddParameter("application/json", payload, ParameterType.RequestBody);
            return request;
        }
        public static string GetParametersAdress(bool simulationSelected)
        {
            if (simulationSelected)
            {
               return ConnectionHelper.simulationAdress + "describe?login=" + ConnectionHelper.Login + "&token=" + ConnectionHelper.Token;
            }
            else
            {
               return ConnectionHelper.chaarrAdress + "describe?login=" + ConnectionHelper.Login + "&token=" + ConnectionHelper.Token;
            }
        }
        public static string ExecuteAdress(bool simulationSelected)
        {
            if (simulationSelected)
            {
                return ConnectionHelper.simulationAdress + "execute";
            }
            else
            {
                return ConnectionHelper.chaarrAdress + "execute";
            }
        }
    }
}
