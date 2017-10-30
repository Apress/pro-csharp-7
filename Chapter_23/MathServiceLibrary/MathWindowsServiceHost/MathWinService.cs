using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MathServiceLibrary;

namespace MathWindowsServiceHost
{
    public partial class MathWinService : ServiceBase
    {
        //A member variable of type ServiceHost
        private ServiceHost myHost;
        public MathWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ////Just to be safe
            //myHost?.Close();
            ////Create the service
            //myHost = new ServiceHost(typeof(MathService));
            ////The ABCs in Code!
            //Uri address = new Uri("http://localhost:8080/MathServiceLibrary");
            //WSHttpBinding binding = new WSHttpBinding();
            //Type contract = typeof(IBasicMath);

            ////Add the endpoint
            //myHost.AddServiceEndpoint(contract, binding, address);

            ////Open the host
            //myHost.Open();

            //Using the defaults
            myHost?.Close();
            // Create the host and specify a URL for an HTTP binding.
            myHost = new ServiceHost(typeof(MathService),
                new Uri("http://localhost:8080/MathServiceLibrary"));
            myHost.AddDefaultEndpoints();

            // Open the host.
            myHost.Open();
        }

        protected override void OnStop()
        {
            //Shut down the service
            myHost?.Close();
        }
    }
}
