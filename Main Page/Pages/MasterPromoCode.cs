using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix_Apps.Main_Page.Pages
{
    public partial class MasterPromoCode : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public MasterPromoCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = promoCodesBindingSource.Current as PromoCodes;

            db.PromoCodes.Add(p);
            db.SaveChanges();
            OnLoad(null);
        }

        private void MasterPromoCode_Load(object sender, EventArgs e)
        {
            promoCodesBindingSource1.DataSource = db.PromoCodes.ToList();

            promoCodesBindingSource.AddNew();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            promoCodesBindingSource1.DataSource = db.PromoCodes
                .Where(p => p.PromoCode.Contains(textBox5.Text))
                .ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnLoad(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is PromoCodes p)
            {
                if (e.ColumnIndex == aksi1.Index)
                {
                    var pp = db.PromoCodes
                        .AsNoTracking()
                        .FirstOrDefault(l => l.PromoID == p.PromoID);

                    promoCodesBindingSource.DataSource = pp;
                }
                if (e.ColumnIndex == aksi2.Index)
                {
                    db.PromoCodes.Remove(p);
                    db.SaveChanges();
                    OnLoad(null);
                }
            }
        }
    }
}
