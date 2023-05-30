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
        public PopupAddAccount()
        {
            InitializeComponent();

            //fill combobox with data
            // Get all types in the assembly
            Type[] allTypes = Assembly.GetExecutingAssembly().GetTypes();

            // Filter the types that are subclasses of ParentClass
            Type[] subclasses = allTypes.Where(type => type.IsSubclassOf(typeof(User))).ToArray();

            // Add the names of the subclasses to the ComboBox data source
            cbxRole.DataSource = subclasses.Select(subclass => subclass.Name).ToList();

        }

        private void btnCancelAccountAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
