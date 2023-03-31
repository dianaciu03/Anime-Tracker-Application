using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using DAL;
using Logic.Enums;
using DAL.Repositories;
using Logic.Animes;

namespace WinFormsGraphic
{
    public partial class PopupAddAnime : Form
    {
        //declare variables
        List<CheckBox> animeGenre;
        private IAnime _animeDataHandler;
        AnimeManager animeManager;

        public PopupAddAnime()
        {
            InitializeComponent();
            InitializeForm();

            //change to factory later
            _animeDataHandler = new AnimeRepository();
            animeManager = new AnimeManager(_animeDataHandler);
        }

        private void InitializeForm()
        {
            //create list of genre textboxes
            animeGenre = new List<CheckBox>
            { cbActionGenreAnime, cbAdventureGenreAnime, cbComedyGenreAnime, cbDramaGenreAnime, cbEcchiGenreAnime, cbFantasyGenreAnime, cbHorrorGenreAnime, cbIsekaiGenreAnime, cbMechaGenreAnime, cbMisteryGenreAnime, cbPsychologicalGenreAnime, cbRomanceGenreAnime, cbSciFiGenreAnime, cbShoujoGenreAnime, cbShounenGenreAnime, cbSliceOfLifeGenreAnime, cbSportsGenreAnime };

            //fill combobox with data
            cbxReleaseSeasonAnime.DataSource = Enum.GetValues(typeof(Season));
        }

        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            try
            {
                AnimeDataValidator adv = new AnimeDataValidator();
                List<Genre> genres = new List<Genre>();
                //check all cboxes 
                foreach (CheckBox cb in animeGenre)
                {
                    if (cb.Checked)
                    {
                        genres.Add((Genre)Enum.Parse(typeof(Genre), cb.Text));
                    }
                }
                if (adv.IsNameValid(tbxNameAnime.Text) && adv.IsStudioValid(tbxStudioAnime.Text) && adv.IsDescriptionValid(tbxDescriptionAnime.Text) && adv.IsNrEpisodesValid(tbxNrEpisodes.Text) && adv.IsRatingValid(numRatingAnime.Text) && adv.IsYearValid(tbxReleaseYearAnime.Text) && adv.IsSeasonValid((Season)cbxReleaseSeasonAnime.SelectedItem) && adv.IsPathValid(tbxImageURL.Text))

                

                //create anime object bases on all the inputted data
                //animeManager.AddAnime(name, description, rating, releaseYear, filename, releaseSeason, nrEpisodes, studio, genres);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancelAnimeAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
