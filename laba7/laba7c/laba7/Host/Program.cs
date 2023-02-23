using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary.Service)))
            {
                host.Open();
                Console.WriteLine($"the service is ready at {host.BaseAddresses[0].AbsoluteUri}");
                Console.WriteLine("Press <Enter> to stop the service");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
