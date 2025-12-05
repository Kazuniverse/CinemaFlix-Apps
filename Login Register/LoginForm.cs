using CinemaFlix_Apps.Login_Register;
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

namespace CinemaFlix_Apps
{
    public partial class LoginForm : Form
    {
        CinemaFlixEntities db = new CinemaFlixEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = db.Users
                .Where(u => u.Username == textBox1.Text)
                .FirstOrDefault();

            var valid = user != null && textBox2.Text == user.Password;

            if (user != null && valid)
            {
                Session.UID = user.UserID;
                Session.UName = user.FullName;
                Session.Role = user.Role;
                MessageBox.Show("Login Successfull!");
                var dash = new Dashboard();
                dash.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Data!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var reg = new RegisForm();
            reg.Show();
            Hide();
        }
    }
}
