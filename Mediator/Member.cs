using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS2_Proxy_Mediator
{
    internal class Member : IMember
    {
        private readonly IFacebookGroup group;
        private string name;

        public Member(IFacebookGroup group, string name)
        {
            this.group = group;
            this.name = name;
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{name} recevied: {message}");
        }

        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name} sending: {message}");
            Console.ForegroundColor = ConsoleColor.Green;
            group.SendMessage(message, this);
            Console.ResetColor();
        }
    }
}
