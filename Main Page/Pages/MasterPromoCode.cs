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
    }
}
