﻿using DAL.Repositories;
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
using Logic.Mangas;
using static Azure.Core.HttpHeader;
using Logic.Characters;
using Logic.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Globalization;
using Logic.Profiles;

namespace WinFormsGraphic
{
    public partial class MainPage : Form
    {
        //declare variables
        IAnimeManager animeManager;
        IMangaManager mangaManager;
        ICharacterManager characterManager;
        IUserManager userManager;
        User currentUser;
        List<RadioButton> animeSort;
        List<RadioButton> mangaSort;
        TabPage currentTab;

        public MainPage(User user)
        {
            InitializeComponent();
            InitializeForm();
            InitializeManagers();
            currentUser = user;
        }

        private void InitializeManagers()
        {
            animeManager = ManagerFactory.CreateAnimeManager(RepositoryFactory.CreateAnimeRepository());
            mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());
            characterManager = ManagerFactory.CreateCharacterManager(RepositoryFactory.CreateCharacterRepository());
            userManager = ManagerFactory.CreateUserManager(RepositoryFactory.CreateUserRepository());
            currentTab = tabControl.SelectedTab;
        }

        private void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //initilize anime search
            cbxSeasonSearchAnime.DataSource = Enum.GetValues(typeof(Season));
            cbxGenreSearchAnime.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearch_Click(this, EventArgs.Empty);
            animeSort = new List<RadioButton>
            { rbtnAnimeNameAsc, rbtnAnimeNameDesc, rbtnAnimeStudioAsc, rbtnAnimeStudioDesc, rbtnAnimeReleaseYearAsc, rbtnAnimeReleaseYearDesc, rbtnAnimeRatingAsc, rbtnAnimeRatingDesc };
            rbtnAnimeNameAsc.Checked = true;

            //initilize manga search
            cbxMangaStatus.DataSource = Enum.GetValues(typeof(MangaStatus));
            cbxGenreManga.DataSource = Enum.GetValues(typeof(Genre));
            btnClearSearchManga_Click(this, EventArgs.Empty);
            mangaSort = new List<RadioButton>
            { rbtnMangaNameAsc, rbtnMangaNameDesc, rbtnMangaCreatorAsc, rbtnMangaCreatorDesc, rbtnMangaReleaseYearAsc, rbtnMangaReleaseYearDesc, rbtnMangaRatingAsc, rbtnMangaRatingDesc };
            rbtnMangaNameAsc.Checked = true;

            //initilize character search
            rbtnCharacterNameAsc.Checked = true;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedTab == tabCreateAccount)
            {
                if(currentUser is not Admin)
                {
                    tabControl.SelectedTab = currentTab;
                    MessageBox.Show("You don't have access to this page!");
                }
            }
            else
            {
                currentTab = tabControl.SelectedTab;
            }
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

                case "Creator ↑":
                    sortBy = "Creator";
                    ascending = true;
                    return (sortBy, ascending);

                case "Creator ↓":
                    sortBy = "Creator";
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
                List<Anime> searchedAnime = animeManager.GetSearchedAnime(tbxNameSearchAnime.Text, tbxStudioSearchAnime.Text, Convert.ToInt32(numNrEpisodesFromSearchAnime.Text), Convert.ToInt32(numNrEpisodesToSearchAnime.Text), tbxReleaseYearSearchAnime.Text, cbxSeasonSearchAnime.Text, cbxGenreSearchAnime.Text, Convert.ToDecimal(numRatingLowerAnime.Text), Convert.ToDecimal(numRatingUpperAnime.Text));
                UpdateAnimeListview(searchedAnime);
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
            string option = "Name ↑";
            try
            {
                foreach (RadioButton rbtn in mangaSort)
                {
                    if (rbtn.Checked == true)
                    {
                        option = rbtn.Text;
                        break;
                    }
                }
                (string sortBy, bool ascending) = GetSortingParameters(option);
                UpdateMangaListView(mangaManager.GetAllManga(sortBy, ascending));
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
            try
            {
                List<Manga> searchedManga = mangaManager.GetSearchedManga(tbxNameManga.Text, tbxCreatorManga.Text, Convert.ToInt32(numChaptersFromManga.Text), Convert.ToInt32(numChaptersToManga.Text), tbxReleaseYearManga.Text, cbxMangaStatus.Text, cbxGenreManga.Text, Convert.ToDecimal(numRatingLowerManga.Text), Convert.ToDecimal(numRatingUpperManga.Text));
                UpdateMangaListView(searchedManga);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
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
                if (c.AnimeId != null && c.AnimeId != 0)
                {
                    Anime anime = animeManager.GetAnimeById(c.AnimeId);
                    item.SubItems.Add(anime.Name);
                }
                else
                {
                    item.SubItems.Add(string.Empty);
                }
                if (c.MangaId != null && c.MangaId != 0)
                {
                    Manga manga = mangaManager.GetMangaById(c.MangaId);
                    item.SubItems.Add(manga.Name);
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

        private void btnSearchCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = string.Empty;
                if(rbtnMale.Checked)
                {
                    gender = rbtnMale.Text;
                }
                else if(rbtnFemale.Checked)
                {
                    gender = rbtnFemale.Text;
                }
                else if(rbtnUnknown.Checked)
                {
                    gender = rbtnUnknown.Text;
                }

                List<Anime> animes = new List<Anime>();
                if (!String.IsNullOrEmpty(tbxAnimeCharacterSearch.Text))
                {
                    animes = animeManager.GetAnimeByName(tbxAnimeCharacterSearch.Text);
                }

                List<Manga> mangas = new List<Manga>();
                if (!String.IsNullOrEmpty(tbxMangaCharacterSearch.Text))
                {
                    mangas = mangaManager.GetMangaByName(tbxMangaCharacterSearch.Text);
                }

                List<Character> searchedCharacters = characterManager.GetSearchedCharacters(tbxCharacterName.Text, gender, animes, mangas);
                UpdateCharactersListView(searchedCharacters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        //
        //ACCOUNT TAB
        //
        private void btnCreateMaintainer_Click(object sender, EventArgs e)
        {
            PopupAddAccount form = new PopupAddAccount();
            form.ShowDialog();
        }

        
    }
}
