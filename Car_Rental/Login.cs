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
        private AccountRepo accountRepo = new AccountRepo();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPassword.Text) && String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username and password can not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var users = userRepo.getAll();
                    var user = users.First(x => x.Username == txtUsername.Text);
                    if (txtPassword.Text == user.Password)
                    {
                        if (user.Role == 0)
                        {
                            this.Hide();
                            Form adminForm = new Admin();
                            adminForm.ShowDialog();
                        }
                        else if (user.Role == 1)
                        {
                            this.Hide();
                            var accounts = accountRepo.getAll();
                            var account = accounts.First(a => a.UserId == user.UserId);
                            Form customerForm = new Customer(account.AccountId);
                            customerForm.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            Form ownerForm = new Owner();
                            ownerForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User not exist in system", "Error", MessageBoxButtons.OK);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Register();
            this.Hide();
            form.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
