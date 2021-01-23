using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICrediManager crediManager, ILoggerService loggerService)
        {
            crediManager.Calculate();
            loggerService.Log();
        }
        public void MakeCrediPreliminaryInformation(List<ICrediManager> loans)
        {
            foreach (var credi in loans)
            {
                credi.Calculate();
            }
        }
    }
}
