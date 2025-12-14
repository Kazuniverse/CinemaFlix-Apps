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
    public partial class MasterStudio : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterStudio()
        {
            InitializeComponent();
        }

        private void MasterStudio_Load(object sender, EventArgs e)
        {
            studiosBindingSource1.DataSource = db.Studios.ToList();

            cinemasBindingSource.DataSource = db.Cinemas.ToList();

            studiosBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = studiosBindingSource.Current as Studios;

            var c = Convert.ToInt32(cinemaNameComboBox.SelectedValue);

            s.CinemaID = c;

            var sCheck = db.Studios
                .Where(p => p.CinemaID == c)
                .Select(p => p.StudioNumber)
                .FirstOrDefault();

            if (studioNumberTextBox.Text == sCheck)
            {
                MessageBox.Show("Use Anothe Studio Number!");
            }
            else if (cinemaNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Chosee At Least 1 Cinema Name!");
            }
            else if (cinemaNameComboBox.SelectedIndex == -1 && studioNumberTextBox.Text == sCheck)
            {
                MessageBox.Show("Invalid Studio Number And Cinema Name!");
            }
            else
            {
                db.Studios.AddOrUpdate(s);
                db.SaveChanges();
                OnLoad(null);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var s = dataGridView1.Rows[e.RowIndex].DataBoundItem as Studios;

            if (e.ColumnIndex == cinemasDataGridViewTextBoxColumn.Index)
                e.Value = s?.Cinemas?.CinemaName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Studios s)
            {
                if (e.ColumnIndex == aksi1.Index)
                {
                    var ss = db.Studios.AsNoTracking().FirstOrDefault(p => p.StudioID == s.StudioID);

                    studiosBindingSource.DataSource = ss;
                }
                if (e.ColumnIndex == aksi2.Index)
                {
                    db.Studios.Remove(s);
                    db.SaveChanges();
                    OnLoad(null);
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            studiosBindingSource1.DataSource = db.Studios
                .Where(p => p.StudioNumber.Contains(textBox9.Text) || p.Cinemas.CinemaName.Contains(textBox9.Text))
                .ToList();
        }
    }
}
