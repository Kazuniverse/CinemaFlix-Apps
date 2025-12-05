using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix_Apps.Main_Page.Pages
{
    public partial class MasterCinema : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterCinema()
        {
            InitializeComponent();
        }

        private void MasterCinema_Load(object sender, EventArgs e)
        {
            cinemasBindingSource1.DataSource = db.Cinemas.ToList();

            cinemasBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = cinemasBindingSource.Current as Cinemas;

            db.Cinemas.AddOrUpdate(c);
            db.SaveChanges();
            OnLoad(null);
        }
    }
}
