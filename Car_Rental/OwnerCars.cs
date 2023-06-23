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
    public partial class OwnerCars : UserControl
    {
        public OwnerCars()
        {
            InitializeComponent();
        }

        public Task<Image> LoadImageFromFileAsync(string url)
        {
            return Task.Run(() =>
            {
                Image img = Image.FromFile(url);


                using (Graphics graphics = Graphics.FromImage(img))
                {
                    graphics.DrawImage(img, 0, 0, 216, 135);
                }

                img.Dispose();

                return img;
            });
        }

        public int _CarId { get; set; }
        public int Car_ID
        {
            set
            {
                this._CarId = value;
                txtCarID.Text = value.ToString();
            }
            get { return _CarId; }
        }
        public string _Model { get; set; }
        public string Model
        {
            set
            {
                this._Model = value;
                txtModel.Text = value;
            }
            get { return _Model; }
        }
        public string _Img;
        public string Img
        {
            set
            {
                this._Img = value;
                Image carImage = Image.FromFile(Img);
                imgCar.Image = carImage;
                imgCar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            get { return _Img; }
        }
        public async void LoadImageAsync()
        {
            var image = await LoadImageFromFileAsync(this.Img);
            imgCar.BackgroundImage = image;
        }

        public string _BranchName { get; set; }
        public string Brandname
        {
            set
            {
                this._BranchName = value;
                txtBrand.Text = value;
            }
            get { return _BranchName; }
        }
        public string _Type { get; set; }
        public string Type
        {
            set
            {
                this._Type = value;
                txtType.Text = value;
            }
            get { return _Type; }
        }
        public decimal? _Price { get; set; }
        public decimal? Price
        {
            set
            {
                this._Price = value;
                txtPrice.Text = value.ToString();
            }
            get { return _Price; }
        }
        public string _Status { get; set; }
        public string Status
        {
            set
            {
                this._Status = value;
                txtStatus.Text = value;
            }
            get { return _Status; }
        }

    }
}
