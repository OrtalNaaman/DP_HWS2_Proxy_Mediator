using System;

namespace DP_HWS2_Proxy_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proxy
            #endregion

            #region Mediator
            IFacebookGroup HackerUGroup = new FacebookGroup();
            IMember ortal = new Member(HackerUGroup, "ortal");
            IMember avital = new Member(HackerUGroup, "avital");
            IMember karina = new Member(HackerUGroup, "karina");
            IMember inna = new Member(HackerUGroup, "inna");
            IMember moran = new Member(HackerUGroup, "moran");

            HackerUGroup.RegisterUser(ortal);
            HackerUGroup.RegisterUser(avital);
            HackerUGroup.RegisterUser(karina);
            HackerUGroup.RegisterUser(inna);
            HackerUGroup.RegisterUser(moran);

            ortal.Send("Hello! I'm Ortal");
            moran.Send("Hello! Wellcome Ortal!");

            #endregion
        }
    }
}
