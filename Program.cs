using System;

namespace DP_HWS2_Proxy_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proxy
            var interiorOffice = new InteriorOffice();
            Citizen agam = new Citizen("Agam", "Shalev", 546878168, DateTime.Parse("14/04/1991 05:04:30"), false);
            Citizen michael = new Citizen("Michael", "Nachum", 556897201, DateTime.Parse("27/08/1988 13:30:25"));
            interiorOffice.AddNewCitizen(agam);
            interiorOffice.AddNewCitizen(michael);
            interiorOffice.GiveNewPassport(michael);

            var michaelInInteriorOffice = new ServiceMachine(interiorOffice,michael);
            ServiceMachineOperation(michaelInInteriorOffice);
            #endregion

            #region Mediator
            //IFacebookGroup HackerUGroup = new FacebookGroup();
            //IMember ortal = new Member(HackerUGroup, "ortal");
            //IMember avital = new Member(HackerUGroup, "avital");
            //IMember karina = new Member(HackerUGroup, "karina");
            //IMember inna = new Member(HackerUGroup, "inna");
            //IMember moran = new Member(HackerUGroup, "moran");

            //HackerUGroup.RegisterUser(ortal);
            //HackerUGroup.RegisterUser(avital);
            //HackerUGroup.RegisterUser(karina);
            //HackerUGroup.RegisterUser(inna);
            //HackerUGroup.RegisterUser(moran);

            //ortal.Send("Hello! I'm Ortal");
            //moran.Send("Hello! Wellcome Ortal!");

            #endregion
        }

        public static void ServiceMachineOperation (ServiceMachine michaelInInteriorOffice)
        {
            Console.WriteLine("\nWelcome to Interior Office of Israel! your detailes in the office:");
            michaelInInteriorOffice.ViewMyInformation(michaelInInteriorOffice.citizenGetService);
            Console.WriteLine("\nIf you want to renewal you passport please enter Y, otherwise enter any other key:");
            string userChoice = Console.ReadLine();
            if (userChoice.ToUpper() == "Y")
                michaelInInteriorOffice.PassportRenewal(michaelInInteriorOffice.citizenGetService);
            Console.WriteLine("\nIf you want to change your address please enter Y, otherwise enter any other key:");
            userChoice = Console.ReadLine();
            if (userChoice.ToUpper() == "Y")
            {
                Console.WriteLine("Enter your new address:");
                string newAddress = Console.ReadLine();
                michaelInInteriorOffice.ChangeAddress(michaelInInteriorOffice.citizenGetService, newAddress);
                Console.WriteLine("\nYour updated details:");
                michaelInInteriorOffice.ViewMyInformation(michaelInInteriorOffice.citizenGetService);
            }              
        }
    }
}
