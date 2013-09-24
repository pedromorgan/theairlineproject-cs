using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirportCSVReader
{
    public class CSVReader
    {
        private List<AirportCSVObject> Airports;
        public string File { get; set; }
        public CSVReader(string file)
        {
            this.Airports = new List<AirportCSVObject>();
            this.File = file;
            readCSVList();
        }
        //reads the list of airports
        private void readCSVList()
        {
            string line;

            //  System.IO.StreamReader file =
            //  new System.IO.StreamReader(Environment.CurrentDirectory + "\\data\\plugins\\airports.csv");

            System.IO.StreamReader file = new System.IO.StreamReader(this.File);

            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                string iata = data[0].Replace('"', ' ').Trim();
                string name = data[1].Replace('"', ' ').Trim();
                string city = data[2].Replace('"', ' ').Trim();
                string country = data[3].Replace('"', ' ').Trim();
                string latitude = data[5].Replace('"', ' ').Trim();
                string longitude = data[6].Replace('"', ' ').Trim();


                this.Airports.Add(new AirportCSVObject(iata, name, city, country, latitude, longitude));
            }

            file.Close();
        }

        //returns an Airports CSV Object
        public AirportCSVObject findAirport(string iata)
        {
            return Airports.Find(delegate(AirportCSVObject o) { return o.IATA.ToUpper() == iata.ToUpper(); });

        }
    }
    public class AirportCSVObject
    {
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string IATA { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public AirportCSVObject(string iata, string name, string town, string country, string latitude, string longitude)
        {
            this.Name = name;
            this.IATA = iata;
            this.Country = country;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Town = town;
        }
    }
}
