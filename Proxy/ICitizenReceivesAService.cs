namespace DP_HWS2_Proxy_Mediator
{
    internal interface ICitizenReceivesAService
    {
        public void ViewMyInformation(Citizen citizen);
        public void PassportRenewal(Citizen citizen);
        public void ChangeAddress(Citizen citizen, string address);
    }
}