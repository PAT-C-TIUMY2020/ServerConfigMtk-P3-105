using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceMtk_P2_20180140105;

namespace ServerConfigMtk_P3_20180140105
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Matematika));
                hostObj.Open();
                Console.WriteLine("Server is Ready!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch(Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
