﻿using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Rental.CustormerForm
{
    public partial class Viewcar : Form
    {
        RentalRepo _rental;
        CarRepo _car;
        AccountRepo _account;
        BrandRepo _brand;
        public Viewcar(string id, string acc)
        {
            InitializeComponent();
            _rental = new RentalRepo();
            _car = new CarRepo();
            _account = new AccountRepo();
            _brand = new BrandRepo();
            textBox1.Text = id;
            textBox2.Text = acc;
            int idrental = Convert.ToInt32(textBox1.Text);
            var data = _car.getAll().Select(c => new
            {
                c.Model,
                c.Price,
                c.Seats,
                c.Fuel,
                c.Describe,
                c.Images,
                Brand = _brand.getAll().FirstOrDefault(b => b.BrandId == c.BrandId).BrandName,
                Rentalid = _rental.getAll().FirstOrDefault(r => r.CarId == 1).RentalId,
                Username = _account.getAll().FirstOrDefault(t => t.AccountId == _rental.getAll().FirstOrDefault(r => r.CarId == 1).AccountId).Fullname,
                Phone = _account.getAll().FirstOrDefault(t => t.AccountId == _rental.getAll().FirstOrDefault(r => r.CarId == 1).AccountId).Phone
            }).ToList();
            var information = data.Where(infor => infor.Rentalid == idrental);
            foreach (var item in information)
            {
                txt_name.Text = item.Model;
                txt_brand.Text = item.Brand;
                txt_description.Text = item.Describe;
                txt_owner.Text = item.Username;
                txt_seat.Text = item.Seats.ToString();
                txt_price.Text = item.Price.ToString();
                txt_phone.Text = item.Phone.ToString();
                Image image = Image.FromFile(item.Images);
                Image resizedImage = new Bitmap(204, 192);

                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(image, 0, 0, 204, 192);
                }
                img.Image = resizedImage;
            }
        }

        private void btn_rental_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            String acc = textBox2.Text;
            string price = txt_price.Text;
            new CustormerForm.HireCar(id, acc, price).ShowDialog();
        }
    }
}
