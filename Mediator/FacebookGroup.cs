using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS2_Proxy_Mediator
{
    internal class FacebookGroup : IFacebookGroup
    {
        private readonly List<IMember> members = new List<IMember>();
        public void RegisterUser(IMember member)
        {
            members.Add(member);
        }

        public void SendMessage(string message, IMember member)
        {
            members.ForEach(m =>
            {
                if (m != member)
                    m.Receive(message);
            });
        }
    }
}
