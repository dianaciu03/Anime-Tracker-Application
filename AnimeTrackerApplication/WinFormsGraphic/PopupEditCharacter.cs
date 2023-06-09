using Factory;
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
    public partial class PopupEditCharacter : Form
    {
        IAnimeManager animeManager;
        IMangaManager mangaManager;
        ICharacterManager characterManager;
        Anime anime = null;
        Manga manga = null;
        Character character;

        public PopupEditCharacter(Character c)
        {
            InitializeComponent();
            this.character = c;
            animeManager = ManagerFactory.CreateAnimeManager(RepositoryFactory.CreateAnimeRepository());
            mangaManager = ManagerFactory.CreateMangaManager(RepositoryFactory.CreateMangaRepository());
            characterManager = ManagerFactory.CreateCharacterManager(RepositoryFactory.CreateCharacterRepository());
            FillInDetails();
        }

        private void FillInDetails()
        {
            tbxCharacterName.Text = character.Name;
            tbxCharacterImage.Text = character.Image;
            if (character.Gender == rbtnMale.Text)
                rbtnMale.Checked = true;
            else if (character.Gender == rbtnFemale.Text)
                rbtnFemale.Checked = true;
            else if (character.Gender == rbtnUnknown.Text)
                rbtnUnknown.Checked = true;

            if(character.FromAnime != null)
            {
                ListViewItem item = new ListViewItem();
                item.Text = character.FromAnime.Name;
                item.Tag = character.FromAnime;
                item.SubItems.Add(character.FromAnime.Studio);
                lvwAnimeCharacter.Items.Add(item);
            }

            if (character.FromManga != null)
            {
                ListViewItem item = new ListViewItem();
                item.Text = character.FromManga.Name;
                item.Tag = character.FromManga;
                item.SubItems.Add(character.FromManga.Creator);
                lvwMangaCharacter.Items.Add(item);
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

        private void btnEditCharacter_Click(object sender, EventArgs e)
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
                    characterManager.UpdateCharacter(character.Id, tbxCharacterName.Text, gender, tbxCharacterImage.Text, anime, manga, character.NrLikes, character.NrDislikes);
                    MessageBox.Show("Character was edited successfully!");
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
