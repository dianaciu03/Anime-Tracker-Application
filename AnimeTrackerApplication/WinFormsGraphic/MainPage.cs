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
using Logic.Characters;
using Logic.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Globalization;

namespace WinFormsGraphic
{
    public partial class MainPage : Form
    {
        //declare variables
        IAnimeManager animeManager;
        IMangaManager mangaManager;
        ICharacterManager characterManager;
        List<RadioButton> animeSort;

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
            characterManager = CharacterManagerFactory.CreateCharacterManager(CharacterRepositoryFactory.CreateCharacterRepository());
        }

        private void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //initilize anime search
            cbxSeasonSearchAnime.DataSource = Enum.GetValues(typeof(Season));
            cbxGenreSearchAnime.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearch_Click(this, EventArgs.Empty);
            //create list of radiobuttons for anime
            animeSort = new List<RadioButton>
            { rbtnAnimeNameAsc, rbtnAnimeNameDesc, rbtnAnimeStudioAsc, rbtnAnimeStudioDesc, rbtnAnimeReleaseYearAsc, rbtnAnimeReleaseYearDesc, rbtnAnimeRatingAsc, rbtnAnimeRatingDesc };
            rbtnAnimeNameAsc.Checked = true;

            //initilize manga search
            cbxMangaStatus.DataSource = Enum.GetValues(typeof(MangaStatus));
            cbxGenreManga.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearchManga_Click(this, EventArgs.Empty);
            rbtnMangaNameAsc.Checked = true;

            //initilize character search
            rbtnCharacterNameAsc.Checked = true;
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
            string option = "Name ↑"; 
            try
            {
                foreach (RadioButton rbtn in animeSort)
                {
                    if (rbtn.Checked == true)
                    {
                        option = rbtn.Text;
                        break;
                    }
                }
                (string sortBy, bool ascending) = GetSortingParameters(option);
                UpdateAnimeListview(animeManager.GetAllAnime(sortBy, ascending));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private (string sortBy, bool ascending) GetSortingParameters(string option)
        {
            string sortBy = "Name";
            bool ascending = true;
            switch (option)
            {
                case "Name ↑":
                    sortBy = "Name";
                    ascending = true;
                    return (sortBy, ascending);

                case "Name ↓":
                    sortBy = "Name";
                    ascending = false;
                    return (sortBy, ascending);

                case "Studio ↑":
                    sortBy = "Studio";
                    ascending = true;
                    return (sortBy, ascending);

                case "Studio ↓":
                    sortBy = "Studio";
                    ascending = false;
                    return (sortBy, ascending);

                case "Release year ↑":
                    sortBy = "ReleaseYear";
                    ascending = true;
                    return (sortBy, ascending);

                case "Release year ↓":
                    sortBy = "ReleaseYear";
                    ascending = false;
                    return (sortBy, ascending);

                case "Rating ↑":
                    sortBy = "Rating";
                    ascending = true;
                    return (sortBy, ascending);

                case "Rating ↓":
                    sortBy = "Rating";
                    ascending = false;
                    return (sortBy, ascending);

                default:
                    return (sortBy, ascending);
            }
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
            lvwAnime.ListViewItemSorter = null;
            lvwAnime.Update();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            cbxGenreSearchAnime.SelectedIndex = -1;
            tbxNameSearchAnime.Text = string.Empty;
            tbxStudioSearchAnime.Text = string.Empty;
            numNrEpisodesFromSearchAnime.Value = 0;
            numNrEpisodesToSearchAnime.Value = 0;
            tbxReleaseYearSearchAnime.Text = string.Empty;
            cbxSeasonSearchAnime.SelectedIndex = -1;
            numRatingLowerAnime.Value = 0;
            numRatingUpperAnime.Value = 0;
        }

        private void btnSearchAnime_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvwAnime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Anime anime = (Anime)lvwAnime.SelectedItems[0].Tag;
            MessageBox.Show(anime.GetInfoDetailed());
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
            try
            {
                Manga manga = (Manga)lvwManga.SelectedItems[0].Tag;
                PopupEditManga form = new PopupEditManga(manga);
                form.ShowDialog();
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

        private void btnRemoveManga_Click(object sender, EventArgs e)
        {
            try
            {
                Manga manga = (Manga)lvwManga.SelectedItems[0].Tag;
                //Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to remove " + manga.Name + "?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks Yes, remove the selected item
                if (result == DialogResult.Yes)
                {
                    mangaManager.DeleteManga(manga.Id);
                    MessageBox.Show("Manga has been successfully deleted!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a manga to remove!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDisplayAllManga_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateMangaListView(mangaManager.GetAllManga());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMangaListView(List<Manga> mangas)
        {
            lvwManga.Items.Clear();
            foreach (Manga m in mangas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.Name;
                item.Tag = m;
                item.SubItems.Add(m.Creator);
                item.SubItems.Add(m.Rating.ToString());
                item.SubItems.Add(m.ReleaseYear.ToString());
                item.SubItems.Add(m.Status.ToString());
                item.SubItems.Add(m.NrChapters.ToString());
                lvwManga.Items.Add(item);
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
            numRatingLowerManga.Value = 0;
            numRatingUpperManga.Value = 0;
        }

        private void btnSearchManga_Click(object sender, EventArgs e)
        {

        }

        //
        //CHARACTER TAB
        //
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            PopupAddCharacter form = new PopupAddCharacter();
            form.ShowDialog();
        }

        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                Character character = (Character)lvwCharacters.SelectedItems[0].Tag;
                PopupEditCharacter form = new PopupEditCharacter(character);
                form.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a character to edit details!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDisplayAllCharacters_Click(object sender, EventArgs e)
        {
            List<Character> characters = characterManager.GetAllCharacters();
            foreach (Character c in characters)
            {
                if (c.AnimeId > 0)
                {
                    Anime anime = animeManager.GetAnimeById(c.AnimeId);
                    c.FromAnime = anime;
                }
                if (c.MangaId > 0)
                {
                    Manga manga = mangaManager.GetMangaById(c.MangaId);
                    c.FromManga = manga;
                }
            }
            UpdateCharactersListView(characters);
        }

        private void UpdateCharactersListView(List<Character> characters)
        {
            lvwCharacters.Items.Clear();
            foreach (Character c in characters)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Name;
                item.Tag = c;
                item.SubItems.Add(c.Gender);
                if (c.FromAnime != null)
                {
                    item.SubItems.Add(c.FromAnime.Name);
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }
                if (c.FromManga != null)
                {
                    item.SubItems.Add(c.FromManga.Name);
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }
                item.SubItems.Add(c.NrLikes.ToString());
                item.SubItems.Add(c.NrDislikes.ToString());
                lvwCharacters.Items.Add(item);
            }
        }
        private void btnRemoveCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                Character character = (Character)lvwCharacters.SelectedItems[0].Tag;
                //Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to remove " + character.Name + "?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks Yes, remove the selected item
                if (result == DialogResult.Yes)
                {
                    characterManager.DeleteCharacter(character.Id);
                    MessageBox.Show("Character has been successfully deleted!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a character to remove!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnClearFieldsCharacter_Click(object sender, EventArgs e)
        {
            tbxCharacterName.Text = string.Empty;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            rbtnUnknown.Checked = false;
            tbxAnimeCharacterSearch.Text = string.Empty;
            tbxMangaCharacterSearch.Text = string.Empty;
        }

    }
}
