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
            var m = moviesBindingSource1.Current as Movies;

            var gen = Convert.ToInt32(genreNameComboBox.SelectedValue);

            m.GenreID = gen;
            m.AgeRating = comboBox1.Text;

            db.Movies.AddOrUpdate(m);
            db.SaveChanges();
            OnLoad(null);
        }

        private void MasterMovie_Load(object sender, EventArgs e)
        {
            moviesBindingSource.DataSource = db.Movies.ToList();

            genresBindingSource.DataSource = db.Genres.ToList();

            comboBox1.SelectedIndex = -1;

            moviesBindingSource1.AddNew();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var m = (Movies)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == genresDataGridViewTextBoxColumn.Index)
                e.Value = m.Genres.GenreName.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            moviesBindingSource.DataSource = db.Movies
                .Where(p => p.Title.Contains(textBox10.Text))
                .ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Movies m)
                {
                    if (e.ColumnIndex == aksi1.Index)
                    {
                        var mm = db.Movies
                            .AsNoTracking()
                            .FirstOrDefault(p => p.MovieID == m.MovieID);

                        comboBox1.Text = m.AgeRating;
                        durationNumericUpDown.Value = m.Duration;

                        moviesBindingSource1.DataSource = mm;
                    }
                    if (e.ColumnIndex == aksi2.Index)
                    {
                        var s = db.Showtimes
                            .Where(p => p.MovieID == m.MovieID)
                            .ToList();

                        foreach (var i in s)
                        {
                            db.Showtimes.Remove(i);
                        }

                        db.Movies.Remove(m);
                        db.SaveChanges();
                        OnLoad(null);
                    }
                }
            }
            
        }
    }
}
