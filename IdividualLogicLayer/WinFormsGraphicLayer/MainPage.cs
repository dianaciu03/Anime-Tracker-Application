using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGraphicLayer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
