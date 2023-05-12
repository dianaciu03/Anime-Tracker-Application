using Factory;
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
    public partial class PopupEditManga : Form
    {
        //declare variables
        List<CheckBox> mangaGenre;
        IMangaManager mangaManager;
        Manga manga;

        public PopupEditManga(Manga m)
        {
            InitializeComponent();
            manga = m;
            mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());
            FillInDetails();   
        }

        private void FillInDetails()
        {
            //create list of genre textboxes
            mangaGenre = new List<CheckBox>
            { cbActionGenreManga, cbAdventureGenreManga, cbComedyGenreManga, cbDramaGenreManga, cbEcchiGenreManga, cbFantasyGenreManga, cbHorrorGenreManga, cbIsekaiGenreManga, cbMechaGenreManga, cbMisteryGenreManga, cbPsychologicalGenreManga, cbRomanceGenreManga, cbSciFiGenreManga, cbShoujoGenreManga, cbShounenGenreManga, cbSliceOfLifeGenreManga, cbSportsGenreManga };

            //fill combobox with data
            cbxStatusManga.DataSource = Enum.GetValues(typeof(MangaStatus));

            tbxNameManga.Text = manga.Name;
            tbxCreatorManga.Text = manga.Creator;
            tbxNrChaptersManga.Text = manga.NrChapters.ToString();
            tbxReleaseYearManga.Text = manga.ReleaseYear.ToString();
            cbxStatusManga.SelectedItem = manga.Status;
            numRatingManga.Text = manga.Rating.ToString();
            tbxDescriptionManga.Text = manga.Description;
            tbxImageURLManga.Text = manga.ImageURL;

            foreach (Genre genre in manga.GetGenres())
            {
                foreach (CheckBox cb in mangaGenre)
                {
                    if (genre.ToString() == cb.Text)
                        cb.Checked = true;
                }
            }
        }

        private void btnEditManga_Click(object sender, EventArgs e)
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
                    mangaManager.UpdateManga(manga.Id, tbxNameManga.Text, tbxCreatorManga.Text, Convert.ToInt32(tbxNrChaptersManga.Text), Convert.ToInt32(tbxReleaseYearManga.Text), (MangaStatus)cbxStatusManga.SelectedItem, Convert.ToDecimal(numRatingManga.Text), tbxDescriptionManga.Text, tbxImageURLManga.Text, genres);
                    MessageBox.Show("Manga was edited successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancelMangaEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
