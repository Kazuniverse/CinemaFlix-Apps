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
    public partial class MasterShowtime : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterShowtime()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MasterShowtime_Load(object sender, EventArgs e)
        {
            showtimesBindingSource1.DataSource = db.Showtimes.ToList();

            moviesBindingSource.DataSource = db.Movies.ToList();
            studiosBindingSource.DataSource = db.Studios.ToList();

            showtimesBindingSource.AddNew();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var s = dataGridView1.Rows[e.RowIndex].DataBoundItem as Showtimes;

            if (e.ColumnIndex == moviesDataGridViewTextBoxColumn.Index)
                e.Value = s?.Movies?.Title;
            if (e.ColumnIndex == studiosDataGridViewTextBoxColumn.Index)
                e.Value = s?.Studios?.StudioNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = showtimesBindingSource.Current as Showtimes;

            var m = Convert.ToInt32(comboBox1.SelectedValue);
            var st = Convert.ToInt32(comboBox2.SelectedValue);

            s.MovieID = m;
            s.StudioID = st;

            db.Showtimes.AddOrUpdate(s);
            db.SaveChanges();
            OnLoad(null);
        }
    }
}
