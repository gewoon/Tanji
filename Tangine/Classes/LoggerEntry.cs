using FlashInspect.ActionScript;
using Sulakore.Communication;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tangine.Classes
{
    public class LoggerEntry
    {
        public string Input { get; set; }
        public bool isStructureEntry { get; }
        public DataInterceptedEventArgs Args { get; set; }

        public LoggerEntry() {
            if (Input == null) return;

            new LoggerEntry(Input);
        }
        public LoggerEntry(string input)
        {
            Input = input;

            if (input.StartsWith("{l}{u:") && input.EndsWith("}"))
            {
                isStructureEntry = true;
                Args = new DataInterceptedEventArgs(new HMessage(input), 0, null);
            }
            else
            {
                bool fromServer = input.StartsWith("Outgoing");
                string[] splitted = Regex.Split(input, fromServer ? "-> " : "<- ");

                var Packet = new HMessage(HMessage.ToBytes(splitted[1]),
                    fromServer ? HDestination.Server : HDestination.Client);

                Args = new DataInterceptedEventArgs(Packet, 0, null);
            }
        }

        public bool isValid()
        {
            if (Input.StartsWith("{l}{u:") && Input.EndsWith("}")) return true;

            if (string.IsNullOrWhiteSpace(Input)) return false;
            if (!Input.Contains("->") && !Input.Contains("<-")) return false;
            if (!Input.StartsWith("Outgoing") && !Input.StartsWith("Incoming")) return false;
            
            return true;
        }
    }
}
