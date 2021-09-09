using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipRegistration
{
    public partial class MainMenu : Form
    {
        private MainPage mp;
        private MemberRegistration mr;
        private MemberSearch ms;
        private FitnessClass fc;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Set Mainpage form in the MainMenu form
            mp = new MainPage();
            mp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mp.StartPosition = FormStartPosition.Manual;  // The form's position is determined by the location property
            mp.Location = new Point(200, 0); // Set the new location
            mp.TopLevel = false;
            this.Controls.Add(mp);
            mp.Show();

            // Set MemberRegistration form in the MainMenu form
            mr = new MemberRegistration();
            mr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mr.StartPosition = FormStartPosition.Manual;  // The form's position is determined by the location property
            mr.Location = new Point(200, 0); // Set the new location
            mr.TopLevel = false;
            this.Controls.Add(mr);

            // Set MemberSearch form in the MainMenu form
            ms = new MemberSearch();
            ms.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ms.StartPosition = FormStartPosition.Manual;  // The form's position is determined by the location property
            ms.Location = new Point(200, 0); // Set the new location
            ms.TopLevel = false;
            this.Controls.Add(ms);

            // Set FitnessClass form in the MainMenu form
            fc = new FitnessClass();
            fc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fc.StartPosition = FormStartPosition.Manual;  // The form's position is determined by the location property
            fc.Location = new Point(200, 0); // Set the new location
            fc.TopLevel = false;
            this.Controls.Add(fc);
        }

        private void Button_MainMenu_Click(object sender, EventArgs e)
        {
            Set_Button_Color(sender, e);
            mr.Hide();
            ms.Hide();
            fc.Hide();
            mp.Show();
        }

        private void Button_NewMember_Click(object sender, EventArgs e)
        {
            Set_Button_Color(sender, e);
            mp.Hide();
            ms.Hide();
            fc.Hide();
            mr.Show();
        }

        private void Button_SearchMember_Click(object sender, EventArgs e)
        {
            Set_Button_Color(sender, e);
            mp.Hide();
            mr.Hide();
            fc.Hide();
            ms.Show();
        }

        private void Button_FitnessClass_Click(object sender, EventArgs e)
        {
            Set_Button_Color(sender, e);
            mp.Hide();
            mr.Hide();
            ms.Hide();
            fc.Show();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Set_Button_Color(object sender, EventArgs e)   // Maintain the background colour of the button which is selected
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(215, 110, 0);

            foreach (Button bt in b.Parent.Controls.OfType<Button>())   // Maintain the background colour of the buttons which are not selected
            {
                if (bt != b)
                    bt.BackColor = Color.FromArgb(33, 37, 41);
            }
        }
    }
}
