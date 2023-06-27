using LibraryRepo.Cars;
using LibraryRepo.Repo;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental.CustormerForm
{
    public partial class CustomerChangePassword : Form
    {
        int acc;
        UserRepo _userRepo = new UserRepo();
        User _user = new User();
        public CustomerChangePassword(int accountId)
        {
            acc = accountId;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOldPwd.Text) || String.IsNullOrEmpty(txtNewPwd.Text) || String.IsNullOrEmpty(txtConfirmPwd.Text))
            {
                MessageBox.Show("Please fill all the input field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("New Password doesnt match with each other", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int checcPwd;
            foreach (var check in _userRepo.getAll())
            {
                if(check.AccountId.Equals(acc))
                {
                    if (check.Password.Equals(txtOldPwd.Text))
                    {
                        _user = _userRepo.getAll().Where(x => x.AccountId == acc).FirstOrDefault();
                        _user.Password = txtNewPwd.Text;
                        _userRepo.Update(_user);
                        MessageBox.Show("Password Updated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Your current Password doesnt match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
