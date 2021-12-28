using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIO_Playstore_Kubinger_Jaeger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string URLFitness = "https://fhwels.s3.eu-central-1.amazonaws.com/PRO1UE_WS21/HealthFitnessApps.CSV";
            string URLPhotography = "https://fhwels.s3.eu-central-1.amazonaws.com/PRO1UE_WS21/PhotographyApps.CSV";
            string URLWeather = "https://fhwels.s3.eu-central-1.amazonaws.com/PRO1UE_WS21/WeatherApps.CSV";

            DataLoader Apps1 = new DataLoader(URLFitness);
            //Apps2
            //Apps3
        }
    }
}
