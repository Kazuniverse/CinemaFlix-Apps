using CinemaFlix_Apps.Main_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFlix_Apps.Login_Register
{
    public partial class RegisForm : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public RegisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = usersBindingSource.Current as Users;

            var idCheck = db.Users
                .Where(p => p.EmployeeID == textBox4.Text)
                .Any();

            if (textBox5.Text == textBox6.Text && !idCheck && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {
                db.Users.Add(u);
                db.SaveChanges();
                var dash = new Dashboard();
                dash.Show();
                Hide();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            var log = new LoginForm();
            log.Show();
            Hide();
        }
    }
}
