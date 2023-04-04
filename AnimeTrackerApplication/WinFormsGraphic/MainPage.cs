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
            IAnimeRepository _animeDataHandler = new AnimeRepository();
            animeManager = new AnimeManager(_animeDataHandler);
        }

        private void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;
            cbxSeasonSearchAnime.DataSource = Enum.GetValues(typeof(Season));
            cbxGenreSearchAnime.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearch_Click(this, EventArgs.Empty);
        }

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

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            tbxNameSearchAnime.Text = string.Empty;
            tbxStudioSearchAnime.Text = string.Empty;
            numNrEpisodesFromSearchAnime.Text = "1";
            numNrEpisodesToSearchAnime.Text = "1";
            tbxReleaseYearSearchAnime.Text = string.Empty;
            cbxGenreSearchAnime.SelectedIndex = -1;
            cbxSeasonSearchAnime.SelectedIndex = -1;
            numRatingSearchAnime.Text = "1";
        }
    }
}
