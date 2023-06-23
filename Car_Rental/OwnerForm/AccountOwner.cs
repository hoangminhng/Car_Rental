using LibraryRepo.Cars;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental.OwnerForm
{
    public partial class AccountOwner : UserControl
    {
        AccountRepo accountRepo;
        UserRepo userRepo;
        private int AccountOwnerID;
        public AccountOwner(int accountID)
        {
            InitializeComponent();
            AccountOwnerID = accountID;
            loadData(accountID);
        }

        public void loadData(int accoundId)
        {
            accountRepo = new AccountRepo();
            Account account = accountRepo.getAll().Where(a => a.AccountId == accoundId).FirstOrDefault();

            txtEmail.Text = account.Email.ToString();
            txtFullName.Text = account.Fullname.ToString();
            txtPhone.Text = account.Phone.ToString();
            txtAddress.Text = account.Address.ToString();
        }

        public Boolean ValidatePhone(string phone)
        {
            string pattern = @"^\d{11}$";
            Boolean result = Regex.IsMatch(phone, pattern);
            return result;
        }

        private Boolean ValidateEmail(string email)
        {
            string pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
            Boolean result = Regex.IsMatch(email, pattern);
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("All input are required, try again", "Notice", MessageBoxButtons.OK);
            }
            else if (!ValidateEmail(txtEmail.Text.ToString()))
            {
                MessageBox.Show("Invalid email format, try again", "Notice", MessageBoxButtons.OK);
            }
            else if (!ValidatePhone(txtPhone.Text.ToString()))
            {
                MessageBox.Show("Invalid phone format, try again", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                AccountRepo accountRepo = new AccountRepo();
                Account account = accountRepo.getAll().FirstOrDefault(p => p.AccountId == AccountOwnerID, null);

                account.Email = txtEmail.Text.ToString();
                account.Fullname = txtFullName.Text.ToString();
                account.Phone = txtPhone.Text.ToString();
                account.Address = txtAddress.Text.ToString();

                accountRepo.Update(account);
                MessageBox.Show("Update successfully", "Notice", MessageBoxButtons.OK);
            }
        }
    }
}
