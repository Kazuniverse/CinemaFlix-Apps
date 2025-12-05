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
    public partial class MasterMovie : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = moviesBindingSource.Current as Movies;

            var gen = Convert.ToInt32(comboBox1.SelectedValue);

            m.GenreID = gen;

            db.Movies.AddOrUpdate(m);
            db.SaveChanges();
            OnLoad(null);
        }

        private void MasterMovie_Load(object sender, EventArgs e)
        {
            moviesBindingSource1.DataSource = db.Movies.ToList();

            genresBindingSource.DataSource = db.Genres.ToList();

            moviesBindingSource1.AddNew();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var m = dataGridView1.Rows[e.RowIndex].DataBoundItem as Movies;

            if (e.ColumnIndex == genresDataGridViewTextBoxColumn.Index)
                e.Value = m.Genres.GenreName;
        }
    }
}
