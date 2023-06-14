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
    public partial class Owner : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int accoundId;
        public Owner()
        {
            InitializeComponent();
            random = new Random();

        }

        public Owner(int accountId)
        {
            InitializeComponent();
            random = new Random();
            this.accoundId = accountId;
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
                    Color color = SelectThemColor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    pnlTitle.BackColor = color;
                    panelLogo.BackColor = color;
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
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void Owner_Load(object sender, EventArgs e)
        {

        }
        //CRUD thông tin cá nhân
        private void btnMngAccount_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            OpenChildForm(new OwnerForm.OwnerAccount(accoundId), sender);
        }
        //xem các yêu cầu thuê xe của khách hàng đối với mình
        private void btnRequest_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        //CRUD car cho thuê của mình
        private void btnMngCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OwnerForm.OwnerCarList(accoundId), sender);
        }
    }
}
