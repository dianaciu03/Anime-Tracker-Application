using IdividualLogicLayer;
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
        //declare (and initialize) variables
        string filename = String.Empty;
        List<CheckBox> animeGenre;
        ContentManager contentManager = new ContentManager();

        public MainPage()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            //fix background image
            this.BackgroundImageLayout = ImageLayout.Stretch;

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
                string name = tbxNameAnime.Text;
                string studio = tbxStudioAnime.Text;
                string description = tbxDescriptionAnime.Text;
                int nrEpisodes = Convert.ToInt32(numNrEpisodesAnime.Text);
                double rating = Convert.ToDouble(numRatingAnime.Text);
                int releaseYear = Convert.ToInt32(tbxReleaseYearAnime.Text);
                Season releaseSeason = (Season)cbxReleaseSeasonAnime.SelectedItem;
                List<Genre> genres = new List<Genre>();
                    
                //check all cboxes 
                foreach(CheckBox cb in animeGenre)
                {
                    if(cb.Checked)
                    {
                        genres.Add((Genre)Enum.Parse(typeof(Genre), cb.Text));
                    }
                }

                //create anime object bases on all the inputted data
                if(!String.IsNullOrEmpty(filename))
                {
                    Content anime = new Anime(name, description, rating, releaseYear, filename, releaseSeason, nrEpisodes, studio, genres);
                    contentManager.SetAnimeId((Anime)anime);
                    contentManager.AddContentToList(anime);
                    filename = String.Empty;
                }
                UpdateAnimeListBox();

            }
            catch(FormatException)
            {
                MessageBox.Show("The year should only be composed of numbers!");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void UpdateAnimeListBox()
        {
            try
            {
                contentManager.ContentApplication
                .Where(content => content is Anime)
                .ToList()
                .ForEach(anime => lbxAnime.Items.Add((Anime)anime));
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("There is no anime data to show.");
            }
            
        }

        private void btnBrowseImgAnime_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filename);
            }
        }

        private void btnDisplayAllAnime_Click(object sender, EventArgs e)
        {
            UpdateAnimeListBox();
        }

        private void lbxAnime_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Anime tempAnime = lbxAnime.SelectedItem as Anime;
                MessageBox.Show(tempAnime.GetInfoDetailed());
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
