using Car_Rental.CustormerForm;
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
    public partial class ListCarcs : UserControl
    {
        public ListCarcs()
        {
            InitializeComponent();
        }
        public Task<Image> LoadImageFromFileAsync(string url)
        {
            return Task.Run(() =>
            {
                Image img = Image.FromFile(url);
                Image resizedImage = new Bitmap(216, 135);

                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(img, 0, 0, 216, 135);
                }

                img.Dispose();

                return resizedImage;
            });
        }

        public string _uricar;
        public string uri_car
        {
            set
            {
                this._uricar = value;
            }
            get { return _uricar; }
        }

        public async void LoadImageAsync()
        {
            var image = await LoadImageFromFileAsync(this.uri_car);
            img.BackgroundImage = image;

        }
        public int _idaccount;
        public int idaccount
        {
            set
            {
                this._idaccount = value;
                textBox2.Text = value.ToString();
            }
            get { return _idaccount; }
        }
        public int _idrental;
        public int idrental
        {
            set
            {
                _idrental = value;
                textBox1.Text = value.ToString();
            }
            get { return this._idrental; }
        }
        public string _name;
        public string name
        {
            set
            {
                _name = value;
                txt_name.Text = value;
            }
            get { return this._name; }
        }

        public int _price;
        public int price
        {
            set
            {
                _price = value;
                txt_price.Text = value.ToString();
            }
            get { return this._price; }
        }

        public string _owner;

        public string owner
        {
            set
            {
                _owner = value;
                txt_owner.Text = value;
            }
            get { return this._owner; }
        }
        private void btn_hire_Click(object sender, EventArgs e)
        {
            string CarID = textBox1.Text;
            String acc = textBox2.Text;
            string price = txt_price.Text;
            new CustormerForm.HireCar(CarID, acc, price).ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string carID = textBox1.Text;
            String idOwner = textBox2.Text;
            new CustormerForm.Viewcar(carID, idOwner).ShowDialog();
        }
    }
}
