using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            //manually initialize some visual elements of the form
            this.BackgroundImageLayout = ImageLayout.Stretch;
            labelErorrMessage.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//hardcode login
            try
            {
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                if (email == "main" && password == "123")
                {
                    this.Hide();
                    MainPage mainPage = new MainPage();
                    mainPage.ShowDialog();
                    this.Close();
                }
                else
                {
                    labelErorrMessage.Visible = true;
                }
            }
            catch (Exception)
            {
                labelErorrMessage.Visible = true;
                return;
            }
        }

    }
}
