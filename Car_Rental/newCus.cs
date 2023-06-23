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

namespace Car_Rental
{
    public partial class newCus : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        CarRepo context;
        RentalRepo _rental;
        AccountRepo _account;
        UserRepo _user;
        BrandRepo _brand;
        public List<ListCarcs> itemCars;
        public List<ListCarcs> itemCarsFilter;
        BrandRepo listofBrand = new BrandRepo();

        public newCus(int idaccount)
        {
            InitializeComponent();
            random = new Random();
            context = new CarRepo();
            _brand = new BrandRepo();
            _rental = new RentalRepo();
            _account = new AccountRepo();
            _user = new UserRepo();
            int acc = idaccount;
            var brand = _brand.getAll();
            combobrand.DataSource = new BindingSource() { DataSource = brand };
            var data = context.getAll().Select(p => new
            {
                Namecar = p.Model,
                Price = p.Price,
                Img = p.Images,
                CarID = p.CarId,
                //Rentalid = _rental.getAll().FirstOrDefault(r => r.CarId == p.CarId)?.RentalId,
                Username = _account.getAll().FirstOrDefault(t => t.AccountId == p.AccountId)?.Fullname
            }).ToList();

            var list = new ListCarcs[data.Count];
            int i = 0;
            itemCars = new List<ListCarcs>();
            itemCarsFilter = new List<ListCarcs>();
            foreach (var item in data)
            {
                list[i] = new ListCarcs();
                list[i].uri_car = item.Img;
                list[i].name = item.Namecar;
                list[i].price = (int)item.Price;
                list[i].idrental = (int)(item.CarID);
                list[i].owner = item.Username;
                list[i].idaccount = acc;
                list[i].LoadImageAsync();
                itemCars.Add(list[i]);
                itemCarsFilter.Add(list[i]);
                i++;
            }
            carList.Controls.AddRange(list);
        }

        private Color SelectThemColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object sender)
        {
            DisableButton();
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    Color color = Color.FromArgb(142, 188, 237);
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point);
                    //label1.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }

            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //this.pnlShow.Controls.Add(childForm);
            //this.pnlShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //pnlShow.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(153, 180, 209);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void newCus_Load(object sender, EventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            carList.Controls.Clear();
            context = new CarRepo();
            _brand = new BrandRepo();
            _rental = new RentalRepo();
            _account = new AccountRepo();
            _user = new UserRepo();
            string txt_name = txt_search.Text;
            String namebrand = combobrand.Text;
            var __brand = _brand.getAll().FirstOrDefault(t => t.BrandName == namebrand);
            int id = __brand.BrandId;
            var data = context.getAll().Select(p => new
            {
                Namecar = p.Model,
                Price = p.Price,
                BrandId = p.BrandId,
                Img = p.Images,
                Username = _account.getAll().FirstOrDefault(t => t.AccountId ==
                            _rental.getAll().FirstOrDefault(r => r.CarId == p.CarId).AccountId).Fullname

            }).ToList();
            var filter = data.Where(p => p.BrandId == id && p.Namecar.Contains(txt_name, StringComparison.OrdinalIgnoreCase)).ToList();
            var list = new ListCarcs[filter.Count];
            int i = 0;
            itemCars = new List<ListCarcs>();
            itemCarsFilter = new List<ListCarcs>();
            foreach (var item in filter)
            {
                list[i] = new ListCarcs();
                list[i].uri_car = @"D://Car_Rental//Car_Rental//Resources//" + item.Img;
                list[i].name = item.Namecar;
                list[i].price = (int)item.Price;
                list[i].owner = item.Username;
                list[i].LoadImageAsync();
                itemCars.Add(list[i]);
                itemCarsFilter.Add(list[i]);
                i++;
            }
            if (filter.Count == 0)
            {
                message.Visible = true;
            }
            else
            {
                message.Visible = false;
                var brand = _brand.getAll();
                combobrand.DataSource = new BindingSource() { DataSource = brand };
                carList.Controls.AddRange(list);
            }
        }
    }
}
