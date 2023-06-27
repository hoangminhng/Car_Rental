using Car_Rental.AdminForm;
using LibraryRepo.Cars;
using LibraryRepo.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Car_Rental.ViewAccountDetails;

namespace Car_Rental
{
    public partial class ViewAccountDetails : Form
    {
        private UserRepo _userRepo;
        private AccountRepo _accountRepo;

        private User _user;
        private Account _account;
        int accId;
        private Customer _customerForm;

        public ViewAccountDetails(int accountId, Customer customerForm)
        {
            _customerForm = customerForm;
            accId = accountId;
            InitializeComponent();
            LoadDetails(accountId);
        }

        private void LoadDetails(int accountId)
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();

            _user = _userRepo.getAll().FirstOrDefault(x => x.AccountId == accountId);
            _account = _accountRepo.getAll().FirstOrDefault(y => y.AccountId == accountId);

            if (_user == null || _account == null)
            {
                MessageBox.Show("User or account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDetails _userDetails = new UserDetails
            {
                AccountId = _account.AccountId,
                Username = _user.Username,
                Fullname = _account.Fullname,
                Phone = _account.Phone,
                Email = _account.Email,
                Address = _account.Address
            };

            try
            {
                txtAccountId.Text = _userDetails.AccountId.ToString();
                txtUsername.Text = _userDetails.Username;
                txtFullname.Text = _userDetails.Fullname;
                txtPhone.Text = _userDetails.Phone;
                txtEmail.Text = _userDetails.Email;
                txtAddress.Text = _userDetails.Address;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while setting the textbox values:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtAccountId.ReadOnly = true;
            txtUsername.ReadOnly = true;
        }

        public void getDataToUpdate(int accountId)
        {
            bool check = false;
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();

            if (String.IsNullOrEmpty(txtFullname.Text) || String.IsNullOrEmpty(txtAddress.Text)
                || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _account.Fullname = txtFullname.Text;
            _account.Address = txtAddress.Text;
            _account.Email = txtEmail.Text;
            _account.Phone = txtPhone.Text;

            check = _accountRepo.Update(_account);
            if (check)
            {
                MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadDetails(accountId);

        }

        public void deactivateUserAccount(int accountId)
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();

            _user = _userRepo.getAll().Where(x => x.AccountId == accountId).FirstOrDefault();

            _user.Status = 1;
            _userRepo.Update(_user);
            MessageBox.Show("Accoutn is deactivated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            _customerForm.Close();

            Login loginForm = new Login();
            loginForm.Show();
        }

        public class UserDetails
        {
            public int AccountId { get; set; }
            public string Username { get; set; }
            public string Fullname { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string Role { get; set; }
            public string Status { get; set; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getDataToUpdate(accId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deactivateUserAccount(accId);
        }
    }
}
