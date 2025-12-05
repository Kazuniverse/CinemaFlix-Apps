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
    public partial class ChangeShowStatus : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public ChangeShowStatus()
        {
            InitializeComponent();
        }

        private void ChangeShowStatus_Load(object sender, EventArgs e)
        {
            showtimesBindingSource.DataSource = db.Showtimes.ToList();

            showtimesBindingSource.AddNew();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var s = dataGridView1.Rows[e.RowIndex].DataBoundItem as Showtimes;

            if (e.ColumnIndex == showtimeStatusChangesDataGridViewTextBoxColumn.Index)
            {
                var ch = s?.ShowtimeStatusChanges
                    .OrderByDescending(i => i.Status)
                    .FirstOrDefault();

                e.Value = ch?.Status ?? "On Schedule";
            }
            if (e.ColumnIndex == studiosDataGridViewTextBoxColumn.Index)
                e.Value = s?.Studios?.StudioNumber;
            if (e.ColumnIndex == moviesDataGridViewTextBoxColumn.Index)
                e.Value = s?.Movies?.Title;
            if (e.ColumnIndex == lastmodif.Index)
            {
                var l = s?.ShowtimeStatusChanges
                    .OrderByDescending(i => i.Status)
                    .Select(i => i.ChangeDateTime)
                    .FirstOrDefault();

                e.Value = l?.ToString("HH;mm;ss") ?? "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = showtimesBindingSource1.Current as Showtimes;

            var c = Convert.ToInt32(comboBox1.SelectedValue);
            var st = Convert.ToInt32(comboBox2.SelectedValue);

            s.StudioID = st;
            var l = s.ShowtimeStatusChanges
                .Where(u => u.ChangeID == c)
                .Select(u => u.ChangeID)
                .FirstOrDefault();

            db.Showtimes.AddOrUpdate(s);
            db.SaveChanges();
            OnLoad(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                label4.Visible = true;
                comboBox1.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            textBox5.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
        }
    }
}
