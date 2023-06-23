using Car_Rental.OwnerForm;
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

namespace Car_Rental
{
    public partial class AddNewCar : UserControl
    {
        private int accountId;
        private Owner Owner;
        public AddNewCar(int accountID, Owner ownerForm)
        {
            InitializeComponent();
            this.accountId = accountID;
            this.Owner = ownerForm;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form addCar = new OwnerCarManagement(accountId, Owner);
            addCar.Show();
        }
    }
}
