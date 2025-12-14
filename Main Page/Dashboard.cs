using CinemaFlix_Apps.Main_Page.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix_Apps.Main_Page
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void viewer(Form form)
        {
            ActiveMdiChild?.Close();
            form.MdiParent = this;
            form.Show();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genres = new MasterGenre();
            viewer(genres);
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mov = new MasterMovie();
            viewer(mov);
        }

        private void cinemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cin = new MasterCinema();
            viewer(cin);
        }

        private void studiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studio = new MasterStudio();
            viewer(studio);
        }

        private void showtimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pro = new MasterPromoCode();
            viewer(pro);
        }

        private void showtimesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sho = new MasterShowtime();
            viewer(sho);
        }

        private void changeShowtimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sc = new ChangeShowStatus();
            viewer(sc);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new LoginForm();
            log.Show();
            Hide();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Welcome {Session.UName} - {DateTime.Now}";
        }
    }
}
