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

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var genres = new MasterGenre();
            genres.MdiParent = this;
            genres.Show();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mov = new MasterMovie();
            mov.MdiParent = this;
            mov.Show();
        }

        private void cinemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cin = new MasterCinema();
            cin.MdiParent = this;
            cin.Show();
        }

        private void studiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studio = new MasterStudio();
            studio.MdiParent = this;
            studio.Show();
        }

        private void showtimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pro = new MasterPromoCode();
            pro.MdiParent = this;
            pro.Show();
        }

        private void showtimesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sho = new MasterShowtime();
            sho.MdiParent = this;
            sho.Show();
        }

        private void changeShowtimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sc = new ChangeShowStatus();
            sc.MdiParent = this;
            sc.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new LoginForm();
            log.MdiParent = this;
            log.Show();
        }
    }
}
