using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_HWS2_Proxy_Mediator
{
    internal class InteriorOffice : IInteriorOffice, ICitizenReceivesAService
    {
        private readonly List<Citizen> Citizens = new List<Citizen>();


        public void AddNewCitizen(Citizen citizen)
        {
            Citizens.Add(citizen);
        }

        public void ChangeAddress(Citizen citizen, string address)
        {
            citizen.Address = address;
        }

        public void GiveNewPassport(Citizen citizen)
        {
            DateTime now = DateTime.Now.Date;
            Console.WriteLine($"New passport was given on {now}");
            citizen.PassportCreateDate = now;
        }

        public void PassportRenewal(Citizen citizen)
        {
            DateTime now = DateTime.Now.Date;
            Console.WriteLine($"Passport renewed on {now}");
            citizen.PassportCreateDate = now;
        }

        public void ViewMyInformation(Citizen citizen)
        {
            Console.WriteLine(citizen);
        }
    }
}
