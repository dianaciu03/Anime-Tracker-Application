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

namespace WinFormsGraphic
{
    public partial class LoginResetPass : Form
    {
        private IUserManager userManager;

        public LoginResetPass()
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
                User user = userManager.GetUserByEmail(email);
                if(user != null)
                {
                    if(tbPassword.Text == tbxConfirmPassword.Text)
                    {
                        userManager.UpdateUser(user, tbxConfirmPassword.Text);
                        User updatedUser = userManager.GetUserById(user.Id);
                        this.Hide();
                        MainPage form = new MainPage(updatedUser);
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        labelErorrMessage.Visible = true;
                    }
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
    }
}
