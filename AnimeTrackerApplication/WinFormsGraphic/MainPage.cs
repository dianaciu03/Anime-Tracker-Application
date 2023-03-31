using DAL.Repositories;
using Logic.Animes;
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
    public partial class MainPage : Form
    {
        //declare variables
        AnimeManager animeManager;

        public MainPage()
        {
            InitializeComponent();
            InitializeForm();
            InitializeManagers();
        }

        private void InitializeManagers()
        {
            IAnime _animeDataHandler = new AnimeRepository();
            animeManager = new AnimeManager(_animeDataHandler);
        }

        private void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            PopupAddAnime form = new PopupAddAnime();
            form.ShowDialog();
        }

        private void btnEditAnime_Click(object sender, EventArgs e)
        {

        }
    }
}
