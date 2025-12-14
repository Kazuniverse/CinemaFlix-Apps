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
    public partial class MasterGenre : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterGenre()
        {
            InitializeComponent();
        }

        private void MasterGenre_Load(object sender, EventArgs e)
        {
            genresBindingSource1.DataSource = db.Genres.ToList();

            genresBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var g = genresBindingSource.Current as Genres;

            db.Genres.AddOrUpdate(g);
            db.SaveChanges();
            OnLoad(null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            genresBindingSource1.DataSource = db.Genres
                .Where(p => p.GenreName.Contains(textBox1.Text))
                .ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is  Genres g)
            {
                if (e.ColumnIndex == aksi1.Index)
                {
                    var gg = db.Genres.AsNoTracking().FirstOrDefault(p => p.GenreID == g.GenreID);

                    genresBindingSource.DataSource = gg;
                }
                if (e.ColumnIndex == aksi2.Index)
                {
                    db.Genres.Remove(g);
                    db.SaveChanges();
                    OnLoad(null);
                }
            }
        }
    }
}
