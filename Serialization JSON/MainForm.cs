using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Data.Entity;

namespace Serialization_JSON
{
    
    public partial class MainForm : Form
    {
        LocationContext db;
        public MainForm()
        {
            InitializeComponent();

            db = new LocationContext();

            db.Locations.Load();

            dataGridView1.DataSource = db.Locations.Local.ToBindingList();
        }

        private void addLocation()
        {
            Location location = new Location();

            location.City = tBCity.Text;
            location.CityRu = tBCityRu.Text;
            location.Country = tBCountry.Text;
            location.CountryRu = tBCountryRu.Text;

            db.Locations.Add(location);

            db.SaveChanges();
        }

        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            addLocation();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Location> locations = db.Locations.Local.ToList();

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Location>));

            using (FileStream fs = new FileStream("locations.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, locations);
            }


        }
    }

    

}
