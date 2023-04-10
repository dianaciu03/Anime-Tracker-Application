using DAL.Repositories;
using Logic.Animes;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Factory;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Mangas;
using static Azure.Core.HttpHeader;

namespace WinFormsGraphic
{
    public partial class MainPage : Form
    {
        //declare variables
        IAnimeManager animeManager;
        IMangaManager mangaManager;
        //List<RadioButton> animeSort;

        public MainPage()
        {
            InitializeComponent();
            InitializeForm();
            InitializeManagers();   
        }

        private void InitializeManagers()
        {
            animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());
            mangaManager = MangaManagerFactory.CreateMangaManager(MangaRepositoryFactory.CreateMangaRepository());
        }

        private void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //initilize anime search
            cbxSeasonSearchAnime.DataSource = Enum.GetValues(typeof(Season));
            cbxGenreSearchAnime.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearch_Click(this, EventArgs.Empty);
            //create list of genre textboxes
            //animeSort = new List<RadioButton>
            //{ rbtnAnimeNameAsc, rbtnAnimeNameDesc, rbtnAnimeStudioAsc, rbtnAnimeStudioDesc, rbtnAnimeReleaseYearAsc, rbtnAnimeReleaseYearDesc, rbtnAnimeRatingAsc, rbtnAnimeRatingDesc };
            rbtnAnimeNameAsc.Checked = true;

            //initilize manga search
            cbxMangaStatus.DataSource = Enum.GetValues(typeof(MangaStatus));
            cbxGenreManga.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearchManga_Click(this, EventArgs.Empty);
            rbtnMangaNameAsc.Checked = true;
        }

        //
        //ANIME TAB
        //
        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            PopupAddAnime form = new PopupAddAnime();
            form.ShowDialog();
        }

        private void btnEditAnime_Click(object sender, EventArgs e)
        {
            try
            {
                Anime anime = (Anime)lvwAnime.SelectedItems[0].Tag;
                PopupEditAnime form = new PopupEditAnime(anime);
                form.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an anime to edit details!");
            }
        }

        private void btnRemoveAnime_Click(object sender, EventArgs e)
        {
            try
            {
                Anime anime = (Anime)lvwAnime.SelectedItems[0].Tag;
                //Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to remove " + anime.Name + "?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks Yes, remove the selected item
                if (result == DialogResult.Yes)
                {
                    animeManager.DeleteAnime(anime.Id);
                    MessageBox.Show("Anime has been successfully deleted!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an anime to edit details!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDisplayAllAnime_Click(object sender, EventArgs e)
        {
            //int option;
            //foreach(RadioButton rbtn in animeSort)
            //{
            //    if(rbtn.Checked == true)
            //    {
            //        UpdateAnimeListview(animeManager.SortAnime());
            //        break;
            //    }
            //}
            UpdateAnimeListview(animeManager.GetAllAnime());
        }

        private void UpdateAnimeListview(List<Anime> animes)
        {
            lvwAnime.Items.Clear();
            foreach (Anime a in animes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = a.Name;
                item.Tag = a;
                item.SubItems.Add(a.Studio);
                item.SubItems.Add(a.Rating.ToString());
                item.SubItems.Add(a.ReleaseYear.ToString());
                item.SubItems.Add(a.SeasonAnime.ToString());
                item.SubItems.Add(a.NrEpisodes.ToString());
                lvwAnime.Items.Add(item);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbxNameSearchAnime.Text = string.Empty;
            tbxStudioSearchAnime.Text = string.Empty;
            numNrEpisodesFromSearchAnime.Value = 0;
            numNrEpisodesToSearchAnime.Value = 0;
            tbxReleaseYearSearchAnime.Text = string.Empty;
            cbxGenreSearchAnime.SelectedIndex = -1;
            cbxSeasonSearchAnime.SelectedIndex = -1;
            numRatingSearchAnime.Value = 0;
        }

        private void btnSearchAnime_Click(object sender, EventArgs e)
        {

        }

        //
        //MANGA TAB
        //
        private void btnAddManga_Click(object sender, EventArgs e)
        {
            PopupAddManga form = new PopupAddManga();
            form.ShowDialog();
        }

        private void btnEditManga_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveManga_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAllManga_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMangaListView(List<Manga> mangas)
        {
            lvwAnime.Items.Clear();
            foreach (Anime a in animes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = a.Name;
                item.Tag = a;
                item.SubItems.Add(a.Studio);
                item.SubItems.Add(a.Rating.ToString());
                item.SubItems.Add(a.ReleaseYear.ToString());
                item.SubItems.Add(a.SeasonAnime.ToString());
                item.SubItems.Add(a.NrEpisodes.ToString());
                lvwAnime.Items.Add(item);
            }
        }

        private void btnClearSearchManga_Click(object sender, EventArgs e)
        {
            tbxCreatorManga.Text = string.Empty;
            tbxNameManga.Text = string.Empty;
            numChaptersFromManga.Value = 0;
            numChaptersToManga.Value = 0;
            tbxReleaseYearManga.Text = string.Empty;
            cbxGenreManga.SelectedIndex = -1;
            cbxMangaStatus.SelectedIndex = -1;
            numRatingManga.Value = 0;
        }

        private void btnSearchManga_Click(object sender, EventArgs e)
        {

        }

        
    }
}
