namespace DP_HWS2_Proxy_Mediator
{
    internal interface IMember
    {
        public void Send(string message);
        public void Receive(string message);
    }
}