using LibraryRepo.Cars;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental.OwnerForm
{
    public partial class OwnerCarManagement : Form
    {
        private BrandRepo brand;
        private CarRepo car;
        private int accountID;
        private OwnerCarList ownerCarList;

        public OwnerCarManagement(int accountID, OwnerCarList parentForm)
        {
            InitializeComponent();
            brand = new BrandRepo();
            var listBrand = brand.getAll();
            cbBrand.DisplayMember = "BrandName";
            cbBrand.ValueMember = "BrandId";
            cbBrand.DataSource = listBrand;
            this.accountID = accountID;
            ownerCarList = parentForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            car = new CarRepo();
            string location = "C:\\Coding\\Car_Rental\\img";
            string path = Path.Combine(location, txtModel.Text + ".jpg");
            Car newCar = new Car
            {
                Model = txtModel.Text,
                BrandId = cbBrand.SelectedIndex + 1,
                AccountId = accountID,
                Type = cbType.Text,
                Images = path,
                Seats = (int)numSeat.Value,
                Transmission = cbTransmission.Text,
                Fuel = cbFuel.Text,
                Consumption = (int)numConsumption.Value,
                Describe = txtDescribe.Text,
                Price = (int)numPrice.Value,
                Status = 0
            };
            bool created = car.Create(newCar);
            if (created)
            {
                MessageBox.Show("Added", "Success", MessageBoxButtons.OK);
                if (ownerCarList != null)
                {
                    ownerCarList.LoadList(accountID);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK);
            }
        }

        private void ptCarImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                openFileDialog.Filter = "(*.jpg; *jpeg; *.png) | *.jpg; *jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(openFileDialog.FileName);

                    // Save the selected image to the desired folder
                    string destinationFolder = "C:\\Coding\\Car_Rental\\img";
                    string destinationPath = Path.Combine(destinationFolder, txtModel.Text + Path.GetExtension(openFileDialog.FileName));

                    File.Copy(openFileDialog.FileName, destinationPath);
                }
            }
        }
    }
}
