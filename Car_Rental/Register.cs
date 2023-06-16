using LibraryRepo.Cars;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Register : Form
    {
        UserRepo userRepo = new UserRepo();
        AccountRepo accRepo = new AccountRepo();

        public Register()
        {
            this.Load += Register_Load;
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            List<string> roles = new List<string>
            {
                "Lessee",
                "Renter"
            };
            roleBox.DataSource = roles;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPwd.Text) || string.IsNullOrEmpty(txtCPwd.Text)
                    || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(roleBox.Text)
                    || string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPwd.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPwd.Text != txtCPwd.Text)
                {
                    MessageBox.Show("Password and Confirm Password must match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email format!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(txtPhone.Text))
                {
                    MessageBox.Show("Invalid phone number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedRole = roleBox.SelectedItem.ToString();
                int role;
                if (selectedRole == "Renter")
                {
                    role = 1;
                }
                else
                {
                    role = 2;
                }
                User user = new User();
                user.Status = 0;
                user.Role = role;
                user.Username = txtUsername.Text;
                user.Password = txtPwd.Text;
                MessageBox.Show(user.Status + " " + user.Username + " " + user.Password + " " + user.Role, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool check = userRepo.Create(user);


                int userId = user.AccountId;
                Account acc = new Account();
                bool checkAccCreate = false;

                if (check)
                {
                    acc.AccountId = userId;
                    acc.Address = txtAddress.Text;
                    acc.Email = txtEmail.Text;
                    acc.Phone = txtPhone.Text;
                    acc.Fullname = txtFullname.Text;
                    checkAccCreate = accRepo.Create(acc);
                }
                else
                {
                    MessageBox.Show("Registration user failed successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (checkAccCreate)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form LoginForm = new Login();
                    LoginForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
