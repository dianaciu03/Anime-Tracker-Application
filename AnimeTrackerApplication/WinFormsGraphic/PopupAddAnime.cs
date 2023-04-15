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
using Microsoft.VisualBasic.Devices;
using Factory.ManagerFactory;
using Factory.RepositoryFactory;

namespace WinFormsGraphic
{
    public partial class PopupAddAnime : Form
    {
        //declare variables
        List<CheckBox> animeGenre;
        IAnimeManager animeManager;

        public PopupAddAnime()
        {
            InitializeComponent();
            InitializeForm();
            animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());
        }

        private void InitializeForm()
        {
            //create list of genre textboxes
            animeGenre = new List<CheckBox>
            { cbActionGenreAnime, cbAdventureGenreAnime, cbComedyGenreAnime, cbDramaGenreAnime, cbEcchiGenreAnime, cbFantasyGenreAnime, cbHorrorGenreAnime, cbIsekaiGenreAnime, cbMechaGenreAnime, cbMisteryGenreAnime, cbPsychologicalGenreAnime, cbRomanceGenreAnime, cbSciFiGenreAnime, cbShoujoGenreAnime, cbShounenGenreAnime, cbSliceOfLifeGenreAnime, cbSportsGenreAnime };

            //fill combobox with data
            cbxReleaseSeasonAnime.DataSource = Enum.GetValues(typeof(Season));

            //reset elements
            cbxReleaseSeasonAnime.SelectedIndex = -1;
            numRatingAnime.Value = 0;
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
                if (adv.IsNameValid(tbxNameAnime.Text) && adv.IsStudioValid(tbxStudioAnime.Text) && adv.IsNrEpisodesValid(tbxNrEpisodes.Text) && adv.IsYearValid(tbxReleaseYearAnime.Text) && adv.IsSeasonValid((Season)cbxReleaseSeasonAnime.SelectedItem) && adv.IsRatingValid(numRatingAnime.Text) && adv.IsDescriptionValid(tbxDescriptionAnime.Text) && adv.IsValidImageUrl(tbxImageURL.Text))
                {
                    animeManager.AddAnime(tbxNameAnime.Text, tbxDescriptionAnime.Text, Convert.ToDecimal(numRatingAnime.Text), Convert.ToInt32(tbxReleaseYearAnime.Text), tbxImageURL.Text, (Season)cbxReleaseSeasonAnime.SelectedItem, Convert.ToInt32(tbxNrEpisodes.Text), tbxStudioAnime.Text, genres);
                    MessageBox.Show("Anime was added successfully!");
                    this.Close();
                }  
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
