using Car_Rental.OwnerForm;

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

        public AddNewCar()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form addCar = new OwnerCarManagement(accountId, Owner);
            addCar.Show();
        }
    }
}
