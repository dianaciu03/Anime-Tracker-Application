using Factory;
using Logic.Enums;
using Logic.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsGraphic
{
    public partial class PopupAddAccount : Form
    {
        private IUserManager userManager;
        public PopupAddAccount()
        {
            InitializeComponent();

            //fill combobox with data
            cbxRole.DataSource = new string[] { "Admin", "Maintainer" };
            cbxRole.SelectedIndex = -1;

            userManager = ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());
            tbxPassword.Text = "TempResetPass";
        }

        private void btnCancelAccountAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxName.Text;
                string email = tbxEmail.Text;
                string password = tbxPassword.Text;
                string role = cbxRole.SelectedItem.ToString();
                userManager.AddUser(name, email, password, role);
                MessageBox.Show("Account was added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
