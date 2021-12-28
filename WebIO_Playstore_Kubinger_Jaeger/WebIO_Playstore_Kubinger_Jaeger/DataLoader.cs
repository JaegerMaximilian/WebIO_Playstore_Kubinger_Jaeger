using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WebIO_Playstore_Kubinger_Jaeger
{
    class DataLoader
    {
        public List<AppData> Apps = new List<AppData>();

        public DataLoader(string url)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, "apps.csv");

            using (StreamReader sr = new StreamReader("apps.csv"))
            {
                /*
                 * HAB DIR DAS PARSEN DER CSV DATEI ÜBERLASSEN DA ES DIE BESTE ÜBUNG IST, DAS ANDERE
                 * IST NUR SCHREIBARBEIT
                 */
            }
        }

        public List<AppData> FilterByPrice(uint MinPrice, uint MaxPrice)
        {
            List<AppData> FilteredApps = new List<AppData>();
            foreach (var app in this.Apps)
            {
                if (app.Price >= MinPrice && app.Price <= MaxPrice) FilteredApps.Add(app);
            }
            return FilteredApps;
        }
        public List<AppData> FilterByReviews(int MinReviews, int MaxReviews)
        {
            List<AppData> FilteredApps = new List<AppData>();
            foreach (var app in this.Apps)
            {
                if (app.Reviews >= MinReviews && app.Reviews <= MaxReviews) FilteredApps.Add(app);
            }
            return FilteredApps;
        }
        public List<AppData> FilterBySize(double MinSize, double MaxSize)
        {
            List<AppData> FilteredApps = new List<AppData>();
            foreach (var app in this.Apps)
            {
                if (app.Size >= MinSize && app.Size <= MaxSize) FilteredApps.Add(app);
            }
            return FilteredApps;
        }
    }
}
