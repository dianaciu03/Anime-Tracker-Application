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
        private User user;
        public LoginResetPass(User user)
        {
            InitializeComponent();
            InitializeForm();
            this.user = user;
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
                if(user.Email == email)
                {
                    if(tbPassword.Text == tbxConfirmPassword.Text)
                    {
                        userManager.UpdateUser(user, tbxConfirmPassword.Text);
                        User updatedUser = userManager.GetUserById(user.Id);

                        this.Hide();
                        LoginResetPass form = new LoginResetPass(updatedUser);
                        form.ShowDialog();
                        this.Close();
                    }
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
