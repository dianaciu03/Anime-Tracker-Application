using DAL.Repositories;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Logic.Contents;
using Logic.Enums;
using Microsoft.VisualBasic.Devices;
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
    public partial class PopupEditAnime : Form
    {
        //declare variables
        List<CheckBox> cbAnimeGenre;
        IAnimeManager animeManager;
        Anime anime;

        public PopupEditAnime(Anime a)
        {
            InitializeComponent();
            anime = a;
            animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());
            FillInDetails();
        }

        private void FillInDetails()
        {
            cbAnimeGenre = new List<CheckBox>
            { cbActionGenreAnime, cbAdventureGenreAnime, cbComedyGenreAnime, cbDramaGenreAnime, cbEcchiGenreAnime, cbFantasyGenreAnime, cbHorrorGenreAnime, cbIsekaiGenreAnime, cbMechaGenreAnime, cbMisteryGenreAnime, cbPsychologicalGenreAnime, cbRomanceGenreAnime, cbSciFiGenreAnime, cbShoujoGenreAnime, cbShounenGenreAnime, cbSliceOfLifeGenreAnime, cbSportsGenreAnime };
            cbxReleaseSeasonAnime.DataSource = Enum.GetValues(typeof(Season));

            tbxNameAnime.Text = anime.Name;
            tbxStudioAnime.Text = anime.Studio;
            tbxNrEpisodes.Text = anime.NrEpisodes.ToString();
            tbxReleaseYearAnime.Text = anime.ReleaseYear.ToString();
            cbxReleaseSeasonAnime.SelectedItem = anime.SeasonAnime;
            numRatingAnime.Text = anime.Rating.ToString();
            tbxDescriptionAnime.Text = anime.Description;
            tbxImageURL.Text = anime.ImageURL;

            foreach (Genre genre in anime.GetGenres())
            {
                foreach (CheckBox cb in cbAnimeGenre)
                {
                    if (genre.ToString() == cb.Text)
                        cb.Checked = true;
                }
            }
        }

        private void btnCancelAnimeAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAnime_Click(object sender, EventArgs e)
        {
            try
            {
                AnimeDataValidator adv = new AnimeDataValidator();
                List<Genre> genres = new List<Genre>();
                //check all cboxes 
                foreach (CheckBox cb in cbAnimeGenre)
                {
                    if (cb.Checked)
                    {
                        genres.Add((Genre)Enum.Parse(typeof(Genre), cb.Text));
                    }
                }
                if (adv.IsNameValid(tbxNameAnime.Text) && adv.IsStudioValid(tbxStudioAnime.Text) && adv.IsNrEpisodesValid(tbxNrEpisodes.Text) && adv.IsYearValid(tbxReleaseYearAnime.Text) && adv.IsSeasonValid((Season)cbxReleaseSeasonAnime.SelectedItem) && adv.IsRatingValid(numRatingAnime.Text) && adv.IsDescriptionValid(tbxDescriptionAnime.Text) && adv.IsValidImageUrl(tbxImageURL.Text))
                {
                    animeManager.UpdateAnime(anime.Id, tbxNameAnime.Text, tbxDescriptionAnime.Text, Convert.ToDecimal(numRatingAnime.Text), Convert.ToInt32(tbxReleaseYearAnime.Text), tbxImageURL.Text, (Season)cbxReleaseSeasonAnime.SelectedItem, Convert.ToInt32(tbxNrEpisodes.Text), tbxStudioAnime.Text, genres);
                    MessageBox.Show("Anime was successfully edited!");
                }
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
