using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebIO_Playstore_Kubinger_Jaeger
{
    class AppData
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public int Rating { get; private set; }
        public int Reviews { get; private set; }
        public double Size { get; private set; } 
        public int Installs { get; private set; }
        public string Type { get; private set; }
        public uint Price { get; private set; }
        public string ContentRating { get; private set; }
        public string Genres { get; private set; }
        public DateTime LastUpdated { get; private set; }
        public string CurrentVersion { get; private set; }
        public string AndroidVersion { get; private set; }


        public AppData(string name, string category, int rating, int reviews, double size, int installs,
            string type, uint price, string contentrating, string genres, DateTime lastupdated,
            string currentversion, string androidversion)
        {
            Name = name;
            Category = category;
            Rating = rating;
            Reviews = reviews;
            Size = size;
            Installs = installs;
            Type = type;
            Price = price;
            ContentRating = contentrating;
            Genres = genres;
            LastUpdated = lastupdated;
            CurrentVersion = currentversion;
            AndroidVersion = androidversion;
        }
        public override string ToString()
        {
            return $"{Name}  |  Kategorie:{Category} | Rating:{Rating} |   Reviews:{Reviews}  | Size:{Size} | Installs:{Installs} | Type:{Type} | Price:{Price} | Rating:{ContentRating} | Genres:{Genres}  |  LastUpdate:{LastUpdated} |  Version:{CurrentVersion}  |  AndroidVersion:{AndroidVersion} \n\n";
        }

    }
}
