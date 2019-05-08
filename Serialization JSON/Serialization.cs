using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace Serialization_JSON
{
    [DataContract]
    public class Serialization
    {
        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string CountryRu { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string CityRu { get; set; }

        public Serialization(string country, string countryRu, string city, string cityRu)
        {
            Country = country;
            CountryRu = countryRu;
            City = city;
            CityRu = cityRu;
        }

    }
}
