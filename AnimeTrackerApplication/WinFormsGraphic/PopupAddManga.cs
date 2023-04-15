using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Logic.Enums;
using Logic.Mangas;
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
    public partial class PopupAddManga : Form
    {
        //declare variables
        List<CheckBox> mangaGenre;
        IMangaManager mangaManager;

        public PopupAddManga()
        {
            InitializeComponent();
            InitializeForm();
            mangaManager = MangaManagerFactory.CreateMangaManager(MangaRepositoryFactory.CreateMangaRepository());
        }

        private void InitializeForm()
        {
            //create list of genre textboxes
            mangaGenre = new List<CheckBox>
            { cbActionGenreManga, cbAdventureGenreManga, cbComedyGenreManga, cbDramaGenreManga, cbEcchiGenreManga, cbFantasyGenreManga, cbHorrorGenreManga, cbIsekaiGenreManga, cbMechaGenreManga, cbMisteryGenreManga, cbPsychologicalGenreManga, cbRomanceGenreManga, cbSciFiGenreManga, cbShoujoGenreManga, cbShounenGenreManga, cbSliceOfLifeGenreManga, cbSportsGenreManga };

            //fill combobox with data
            cbxStatusManga.DataSource = Enum.GetValues(typeof(MangaStatus));

            //reset fields
            cbxStatusManga.SelectedIndex = -1;
            numRatingManga.Value = 0;
        }

        private void btnCancelMangaAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddManga_Click(object sender, EventArgs e)
        {
            try
            {
                MangaDataValidator mdv = new MangaDataValidator();
                List<Genre> genres = new List<Genre>();
                //check all cboxes 
                foreach (CheckBox cb in mangaGenre)
                {
                    if (cb.Checked)
                    {
                        genres.Add((Genre)Enum.Parse(typeof(Genre), cb.Text));
                    }
                }
                if (mdv.IsNameValid(tbxNameManga.Text) && mdv.IsCreatorValid(tbxCreatorManga.Text) && mdv.IsNrChaptersValid(tbxNrChaptersManga.Text) && mdv.IsYearValid(tbxReleaseYearManga.Text) && mdv.IsStatusValid((MangaStatus)cbxStatusManga.SelectedItem) && mdv.IsRatingValid(numRatingManga.Text) && mdv.IsDescriptionValid(tbxDescriptionManga.Text) && mdv.IsValidImageUrl(tbxImageURLManga.Text))
                {
                    mangaManager.AddManga(tbxNameManga.Text, tbxDescriptionManga.Text, Convert.ToDecimal(numRatingManga.Text), Convert.ToInt32(tbxReleaseYearManga.Text), tbxImageURLManga.Text, (MangaStatus)cbxStatusManga.SelectedItem, Convert.ToInt32(tbxNrChaptersManga.Text), tbxCreatorManga.Text, genres);
                    MessageBox.Show("Manga was added successfully!");
                    this.Close();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
