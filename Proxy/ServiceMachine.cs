using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS2_Proxy_Mediator
{
    internal class ServiceMachine : ICitizenReceivesAService
    {
        private ICitizenReceivesAService interiorOffice;
        public Citizen citizenGetService;

        public ServiceMachine(ICitizenReceivesAService interiorOffice, Citizen citizenGetService)
        {
            this.interiorOffice = interiorOffice;
            this.citizenGetService = citizenGetService;
        }

        public void ChangeAddress(Citizen citizen,string address)
        {
            interiorOffice.ChangeAddress(citizen,address);
        }

        public void PassportRenewal(Citizen citizen)
        {
            interiorOffice.PassportRenewal(citizen);
        }

        public void ViewMyInformation(Citizen citizen)
        {
            interiorOffice.ViewMyInformation(citizen);
        }
    }
}
