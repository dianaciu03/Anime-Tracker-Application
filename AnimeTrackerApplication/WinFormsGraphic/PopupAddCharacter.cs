using Factory.ManagerFactory;
using Factory.RepositoryFactory;
using Logic.Animes;
using Logic.Characters;
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
    public partial class PopupAddCharacter : Form
    {
        IAnimeManager animeManager;
        IMangaManager mangaManager;
        ICharacterManager characterManager;
        Anime anime = null;
        Manga manga = null;

        public PopupAddCharacter()
        {
            InitializeComponent();
            animeManager = AnimeManagerFactory.CreateAnimeManager(AnimeRepositoryFactory.CreateAnimeRepository());
            mangaManager = MangaManagerFactory.CreateMangaManager(MangaRepositoryFactory.CreateMangaRepository());
            characterManager = CharacterManagerFactory.CreateCharacterManager(CharacterRepositoryFactory.CreateCharacterRepository());
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                CharacterDataValidator cdv = new CharacterDataValidator();
                string gender = string.Empty;
                if (rbtnMale.Checked == true)
                    gender = rbtnMale.Text;
                else if (rbtnFemale.Checked == true)
                    gender = rbtnFemale.Text;
                else if (rbtnUnknown.Checked == true)
                    gender = rbtnUnknown.Text;

                if (cdv.IsNameValid(tbxCharacterName.Text) && cdv.IsValidImageUrl(tbxCharacterImage.Text) && cdv.IsGenderValid(gender))
                {
                    characterManager.AddCharacter(tbxCharacterName.Text, gender, tbxCharacterImage.Text, anime, manga);
                    MessageBox.Show("Character was added successfully!");
                    this.Close();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancelCharacterAddition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxAnimeTitle_TextChanged(object sender, EventArgs e)
        {
            string animeTitle = tbxAnimeTitle.Text;
            List<Anime> searchedAnime = new List<Anime>();
            searchedAnime = animeManager.GetAnimeByName(animeTitle);

            lvwAnimeCharacter.Items.Clear();
            foreach (Anime a in searchedAnime)
            {
                ListViewItem item = new ListViewItem();
                item.Text = a.Name;
                item.Tag = a;
                item.SubItems.Add(a.Studio);
                lvwAnimeCharacter.Items.Add(item);
            }
        }

        private void tbxMangaTitle_TextChanged(object sender, EventArgs e)
        {
            string mangaTitle = tbxMangaTitle.Text;
            List<Manga> searchedManga = new List<Manga>();
            searchedManga = mangaManager.GetMangaByName(mangaTitle);

            lvwMangaCharacter.Items.Clear();
            foreach (Manga m in searchedManga)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.Name;
                item.Tag = m;
                item.SubItems.Add(m.Creator);
                lvwMangaCharacter.Items.Add(item);
            }
        }

        private void lvwAnimeCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            anime = (Anime)lvwAnimeCharacter.SelectedItems[0].Tag;
        }

        private void lvwMangaCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            manga = (Manga)lvwMangaCharacter.SelectedItems[0].Tag;
        }
    }
}
