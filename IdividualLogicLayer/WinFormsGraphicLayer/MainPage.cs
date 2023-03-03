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
        string filename = "";
        string loggedUser = "admin";
        List<CheckBox> animeGenre;
        ContentManager contentManager = new ContentManager();

        public MainPage()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;

            animeGenre = new List<CheckBox>
            { cbActionGenreAnime, cbAdventureGenreAnime, cbComedyGenreAnime, cbDramaGenreAnime, cbEcchiGenreAnime, cbFantasyGenreAnime, cbHorrorGenreAnime, cbIsekaiGenreAnime, cbMechaGenreAnime, cbMisteryGenreAnime, cbPsychologicalGenreAnime, cbRomanceGenreAnime, cbSciFiGenreAnime, cbShoujoGenreAnime, cbShounenGenreAnime, cbSliceOfLifeGenreAnime, cbSportsGenreAnime };

            cbxReleaseSeasonAnime.DataSource = Enum.GetValues(typeof(Season));
        }


        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            try
            {
                if(loggedUser == "admin")
                {
                    string name = tbxNameAnime.Text;
                    string studio = tbxStudioAnime.Text;
                    string description = tbxDescriptionAnime.Text;
                    int nrEpisodes = Convert.ToInt32(numNrEpisodesAnime.Text);
                    double rating = Convert.ToDouble(numRatingAnime.Text);
                    int releaseYear = Convert.ToInt32(numReleaseYearAnime.Text);
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

                    Content anime = new Anime(name, description, rating, releaseYear, filename, releaseSeason, nrEpisodes, studio, genres);
                    contentManager.SetAnimeId((Anime)anime);
                    lbxAnime.Items.Add(anime.GetInfoDisplay());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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

        }
    }
}
