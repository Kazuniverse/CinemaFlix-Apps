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

            showtimeStatusChangesBindingSource.DataSource = db.ShowtimeStatusChanges.ToList();
            cinemasBindingSource.DataSource = db.Cinemas.ToList();
            comboBox1.SelectedIndex = -1;

            showtimesBindingSource1.AddNew();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var s = dataGridView1.Rows[e.RowIndex].DataBoundItem as Showtimes;

            if (e.ColumnIndex == showtimeStatusChangesDataGridViewTextBoxColumn.Index)
            {
                var ch = s?.ShowtimeStatusChanges
                    .OrderByDescending(i => i.Status)
                    .FirstOrDefault();

                if (ch?.Status == "Studio Changed")
                    ch.Status = "On Schedule";

                e.Value = ch?.Status ?? "On Schedule";
            }
            if (e.ColumnIndex == studiosDataGridViewTextBoxColumn.Index)
            {
                var c = s?.ShowtimeStatusChanges
                    .OrderByDescending(i => i.Status)
                    .Select(i => i.NewStudioID)
                    .FirstOrDefault();

                var cn = db.Cinemas
                    .FirstOrDefault(i => i.CinemaID == c);

                e.Value = cn?.CinemaName ?? s.Studios.Cinemas.CinemaName;
            }
                
            if (e.ColumnIndex == moviesDataGridViewTextBoxColumn.Index)
                e.Value = s?.Movies?.Title;
            if (e.ColumnIndex == lastmodif.Index)
            {
                var l = s?.ShowtimeStatusChanges
                    .OrderByDescending(i => i.Status)
                    .Select(i => i.ChangeDateTime)
                    .FirstOrDefault();

                e.Value = l?.ToString("dd:MMMM:yyyy") ?? "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            var s = showtimesBindingSource.Current as Showtimes;

            var c = new ShowtimeStatusChanges()
            {
                ShowtimeID = s.ShowtimeID,
                NewStudioID = Convert.ToInt32(comboBox2.SelectedValue ?? null),
                ChangeDateTime = DateTime.Now,
                Status = comboBox1.Text,
                Remarks = textBox5.Text
            };

            db.ShowtimeStatusChanges.Add(c);
            db.SaveChanges();
            OnLoad(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Showtimes s)
                {
                    if (e.ColumnIndex == aksi1.Index)
                    {
                        label4.Visible = true;
                        comboBox1.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        var ch = s.ShowtimeStatusChanges
                            .OrderByDescending(p => p.ChangeDateTime ?? DateTime.MinValue)
                            .FirstOrDefault();

                        if (ch != null)
                        {
                            comboBox1.Text = ch.Status;
                        }
                        else
                        {
                            comboBox1.Text = "On Schedule";
                        }
                    }
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Visible = true;
                textBox5.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label7.Visible = false;
                comboBox2.Visible = false;
                textBox5.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            OnLoad(null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showtimesBindingSource.DataSource = db.Showtimes
                .Where(p => p.Studios.Cinemas.CinemaName.Contains(textBox1.Text))
                .ToList();
        }
    }
}
