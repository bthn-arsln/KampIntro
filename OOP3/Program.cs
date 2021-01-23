using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager needCrediManager = new NeedCrediManager();

            ICrediManager vehicleCrediManager = new VehicleCrediManager();

            ICrediManager housingCrediManager = new HousingCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(needCrediManager, databaseLoggerService);

            List<ICrediManager> loans = new List<ICrediManager>() {needCrediManager, vehicleCrediManager };

            // applicationManager.MakeCrediPreliminaryInformation(loans);
        }
    }
}
