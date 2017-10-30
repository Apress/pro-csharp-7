using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Console Based WCF Host *****");

      //using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService),
      //    new Uri[]{new Uri("http://localhost:8080/MagicEightBallServer")}))
      using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
      {
        // Open the host and start listening for incoming messages.
        serviceHost.Open();
        DisplayHostInfo(serviceHost);
        // Keep the service running until Enter key is pressed.
        Console.WriteLine("The service is ready.");
        Console.WriteLine("Press the Enter key to terminate service.");
        Console.ReadLine();
      }
    }

    #region Show all the ABCs exposed from the host.
    static void DisplayHostInfo(ServiceHost host)
    {
        Console.WriteLine();
        Console.WriteLine("***** Host Info *****");

        foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
        {
            Console.WriteLine("Address: {0}", se.Address);
            Console.WriteLine("Binding: {0}", se.Binding.Name);
            Console.WriteLine("Contract: {0}", se.Contract.Name);
        }
        Console.WriteLine("**********************");
    }
    #endregion
  }
}
