using LibraryRepo.Repo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Login : Form
    {
        private UserRepo userRepo = new UserRepo();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var users = userRepo.getAll();
                var user = users.First(x => x.Username == txtUsername.Text);
                if (user.Role == 0)
                {
                    this.Hide();
                    Form adminForm = new Admin();
                    adminForm.ShowDialog();
                }
                else if (user.Role == 1)
                {
                    this.Hide();
                    Form customerForm = new Customer();
                    customerForm.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Form ownerForm = new Owner();
                    ownerForm.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.ShowDialog();
        }
    }
}
