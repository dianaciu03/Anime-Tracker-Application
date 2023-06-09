using Factory;
using Logic.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsGraphic
{
    public partial class Login : Form
    {
        private IUserManager userManager;
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

            userManager = ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                if(userManager.LoginUser(password, email))
                {
                    this.Hide();
                    MainPage mainPage = new MainPage(userManager.GetUserByEmail(email));
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
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LoginResetPass form = new LoginResetPass();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
