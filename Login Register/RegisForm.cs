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

            var nameCheck = db.Users
                .Where(p => p.Username == textBox1.Text)
                .Any();

            if (textBox5.Text == textBox6.Text && !idCheck && !nameCheck && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(maskedTextBox1.Text) || maskedTextBox1.TextLength > 15 || maskedTextBox1.TextLength < 10 && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text))
            {
                Session.UID = u.UserID;
                Session.UName = u.FullName; 
                Session.Role = u.Role;
                db.Users.Add(u);
                db.SaveChanges();
                var dash = new Dashboard();
                dash.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Data!");
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
