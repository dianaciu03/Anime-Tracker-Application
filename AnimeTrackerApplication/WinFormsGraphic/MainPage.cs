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

        private void btnDisplayAllAnime_Click(object sender, EventArgs e)
        {
            UpdateAnimeListview(animeManager.GetAllAnime());
        }

        private void UpdateAnimeListview(List<Anime> animes)
        {
            lvwAnime.Items.Clear();
            foreach (Anime a in animes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = a.Id;
                item.Tag = a;
                item.SubItems.Add(a.Name);
                item.SubItems.Add(a.Studio);
                item.SubItems.Add(a.Rating.ToString());
                item.SubItems.Add(a.ReleaseYear.ToString());
                item.SubItems.Add(a.SeasonAnime.ToString());
                item.SubItems.Add(a.NrEpisodes.ToString());
                lvwAnime.Items.Add(item);
            }
        }
    }
}
