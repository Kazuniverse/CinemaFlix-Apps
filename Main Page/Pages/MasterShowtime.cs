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
            TimeSpan p = TimeSpan.Parse(maskedTextBox1.Text);

            s.MovieID = m;
            s.StudioID = st;
            s.ShowTime = p;
            s.ShowtimeCode = maskedTextBox2.Text;

            db.Showtimes.AddOrUpdate(s);
            db.SaveChanges();
            OnLoad(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(null);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            showtimesBindingSource1.DataSource = db.Showtimes
                .Where(p => p.ShowtimeCode.Contains(textBox9.Text))
                .ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Showtimes s)
            {
                if (e.ColumnIndex == aksi1.Index)
                {
                    var ss = db.Showtimes
                        .AsNoTracking()
                        .FirstOrDefault(p => p.ShowtimeID == s.ShowtimeID);

                    showtimesBindingSource.DataSource = ss;
                }
                if (e.ColumnIndex == aksi2.Index)
                {
                    db.Showtimes.Remove(s);
                    db.SaveChanges();
                    OnLoad(null);
                }
            }
        }
    }
}
