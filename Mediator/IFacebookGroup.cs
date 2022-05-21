namespace DP_HWS2_Proxy_Mediator
{
    internal interface IFacebookGroup
    {
        public void SendMessage(string message, IMember member);
        public void RegisterUser(IMember member);
    }
}