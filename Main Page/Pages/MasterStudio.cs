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

            db.Studios.AddOrUpdate(s);
            db.SaveChanges();
            OnLoad(null);
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
    }
}
