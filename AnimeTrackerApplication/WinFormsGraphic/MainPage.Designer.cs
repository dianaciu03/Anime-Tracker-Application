namespace WinFormsGraphic
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.labelTitleWorldOfAnime = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAnime = new System.Windows.Forms.TabPage();
            this.BroupBoxSortAnime = new System.Windows.Forms.GroupBox();
            this.rbtnAnimeRatingDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeRatingAsc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeReleaseYearDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeReleaseYearAsc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeStudioDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeStudioAsc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeNameDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeNameAsc = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllAnime = new System.Windows.Forms.Button();
            this.btnRemoveAnime = new System.Windows.Forms.Button();
            this.btnAddAnime = new System.Windows.Forms.Button();
            this.lvwAnime = new System.Windows.Forms.ListView();
            this.colAnimeName = new System.Windows.Forms.ColumnHeader();
            this.colAnimeStudio = new System.Windows.Forms.ColumnHeader();
            this.colAnimeRating = new System.Windows.Forms.ColumnHeader();
            this.colAnimeReleaseYear = new System.Windows.Forms.ColumnHeader();
            this.colAnimeReleaseSeason = new System.Windows.Forms.ColumnHeader();
            this.colAnimeNrEpisodes = new System.Windows.Forms.ColumnHeader();
            this.btnEditAnime = new System.Windows.Forms.Button();
            this.groupBoxSearchAnime = new System.Windows.Forms.GroupBox();
            this.numRatingUpperAnime = new System.Windows.Forms.NumericUpDown();
            this.labelRatingToAnime = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.tbxReleaseYearSearchAnime = new System.Windows.Forms.TextBox();
            this.numRatingLowerAnime = new System.Windows.Forms.NumericUpDown();
            this.labelRatingSearchAnime = new System.Windows.Forms.Label();
            this.cbxSeasonSearchAnime = new System.Windows.Forms.ComboBox();
            this.labelReleaseSeasonSearchAnime = new System.Windows.Forms.Label();
            this.btnSearchAnime = new System.Windows.Forms.Button();
            this.cbxGenreSearchAnime = new System.Windows.Forms.ComboBox();
            this.labelGenreSearchAnime = new System.Windows.Forms.Label();
            this.labelYearSearchAnime = new System.Windows.Forms.Label();
            this.numNrEpisodesToSearchAnime = new System.Windows.Forms.NumericUpDown();
            this.labelNrEpisodesToSearchAnime = new System.Windows.Forms.Label();
            this.numNrEpisodesFromSearchAnime = new System.Windows.Forms.NumericUpDown();
            this.labelNrEpisodesFromSearchAnime = new System.Windows.Forms.Label();
            this.tbxStudioSearchAnime = new System.Windows.Forms.TextBox();
            this.labelStudioSearchAnime = new System.Windows.Forms.Label();
            this.tbxNameSearchAnime = new System.Windows.Forms.TextBox();
            this.labelNameSearchAnime = new System.Windows.Forms.Label();
            this.tabManga = new System.Windows.Forms.TabPage();
            this.btnRemoveManga = new System.Windows.Forms.Button();
            this.btnAddManga = new System.Windows.Forms.Button();
            this.btnEditManga = new System.Windows.Forms.Button();
            this.groupBoxSortManga = new System.Windows.Forms.GroupBox();
            this.rbtnMangaRatingDesc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaRatingAsc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaReleaseYearDesc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaReleaseYearAsc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaCreatorDesc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaCreatorAsc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaNameDesc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaNameAsc = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllManga = new System.Windows.Forms.Button();
            this.lvwManga = new System.Windows.Forms.ListView();
            this.columnNameManga = new System.Windows.Forms.ColumnHeader();
            this.columnCreator = new System.Windows.Forms.ColumnHeader();
            this.columnRatingManga = new System.Windows.Forms.ColumnHeader();
            this.columnReleaseYearManga = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.columnNrChapters = new System.Windows.Forms.ColumnHeader();
            this.groupBoxSearchManga = new System.Windows.Forms.GroupBox();
            this.numRatingUpperManga = new System.Windows.Forms.NumericUpDown();
            this.btnClearSearchManga = new System.Windows.Forms.Button();
            this.tbxReleaseYearManga = new System.Windows.Forms.TextBox();
            this.labelRatingToManga = new System.Windows.Forms.Label();
            this.cbxMangaStatus = new System.Windows.Forms.ComboBox();
            this.labelMangaStatus = new System.Windows.Forms.Label();
            this.numRatingLowerManga = new System.Windows.Forms.NumericUpDown();
            this.btnSearchManga = new System.Windows.Forms.Button();
            this.cbxGenreManga = new System.Windows.Forms.ComboBox();
            this.labelRatingFromManga = new System.Windows.Forms.Label();
            this.labelGenreManga = new System.Windows.Forms.Label();
            this.labelReleaseYearManga = new System.Windows.Forms.Label();
            this.numChaptersToManga = new System.Windows.Forms.NumericUpDown();
            this.labelChaptersToManga = new System.Windows.Forms.Label();
            this.numChaptersFromManga = new System.Windows.Forms.NumericUpDown();
            this.labelNrChaptersFromManga = new System.Windows.Forms.Label();
            this.tbxCreatorManga = new System.Windows.Forms.TextBox();
            this.labelCreatorManga = new System.Windows.Forms.Label();
            this.tbxNameManga = new System.Windows.Forms.TextBox();
            this.labeNameManga = new System.Windows.Forms.Label();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.btnRemoveCharacter = new System.Windows.Forms.Button();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.groupBoxSortCharacters = new System.Windows.Forms.GroupBox();
            this.rbtnNrDislikesDesc = new System.Windows.Forms.RadioButton();
            this.rbtnNrDislikesAsc = new System.Windows.Forms.RadioButton();
            this.rbtnNrLikesDesc = new System.Windows.Forms.RadioButton();
            this.rbtnNrLikesAsc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaCharacterDesc = new System.Windows.Forms.RadioButton();
            this.rbtnMangaCharacterAsc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeCharacterDesc = new System.Windows.Forms.RadioButton();
            this.rbtnAnimeCharacterAsc = new System.Windows.Forms.RadioButton();
            this.rbtnCharacterNameDesc = new System.Windows.Forms.RadioButton();
            this.rbtnCharacterNameAsc = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllCharacters = new System.Windows.Forms.Button();
            this.lvwCharacters = new System.Windows.Forms.ListView();
            this.columnNameCharacter = new System.Windows.Forms.ColumnHeader();
            this.columnGenderCharacter = new System.Windows.Forms.ColumnHeader();
            this.columnAnimeCharacter = new System.Windows.Forms.ColumnHeader();
            this.columnMangaCharacter = new System.Windows.Forms.ColumnHeader();
            this.columnNrLikes = new System.Windows.Forms.ColumnHeader();
            this.columnNrDislikes = new System.Windows.Forms.ColumnHeader();
            this.groupBoxSearchCharacters = new System.Windows.Forms.GroupBox();
            this.labelFromContentCharacter = new System.Windows.Forms.Label();
            this.tbxMangaCharacterSearch = new System.Windows.Forms.TextBox();
            this.labelMangaCharacter = new System.Windows.Forms.Label();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.labelCharacterGender = new System.Windows.Forms.Label();
            this.btnClearFieldsCharacter = new System.Windows.Forms.Button();
            this.tbxAnimeCharacterSearch = new System.Windows.Forms.TextBox();
            this.btnSearchCharacter = new System.Windows.Forms.Button();
            this.labelAnimeCharacter = new System.Windows.Forms.Label();
            this.tbxCharacterName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.tabCreateAccount = new System.Windows.Forms.TabPage();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnCreateMaintainer = new System.Windows.Forms.Button();
            this.lvwAccounts = new System.Windows.Forms.ListView();
            this.columnHeader1Name = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2Username = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3JoinDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4Role = new System.Windows.Forms.ColumnHeader();
            this.groupBoxSearchAccount = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.labelYears = new System.Windows.Forms.Label();
            this.tbxYears = new System.Windows.Forms.TextBox();
            this.btnClearFieldsAccount = new System.Windows.Forms.Button();
            this.labelExperience = new System.Windows.Forms.Label();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.labelRoles = new System.Windows.Forms.Label();
            this.tbxNameAccount = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.lvwReviews = new System.Windows.Forms.ListView();
            this.columnHeaderUsernameReview = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderRatingReview = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescriptionReview = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPostDate = new System.Windows.Forms.ColumnHeader();
            this.groupBoxSearchReview = new System.Windows.Forms.GroupBox();
            this.btnClearFieldsReview = new System.Windows.Forms.Button();
            this.btnSearchReview = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.cbxAnime = new System.Windows.Forms.CheckBox();
            this.cbxManga = new System.Windows.Forms.CheckBox();
            this.numRatingReview = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSortReviews = new System.Windows.Forms.GroupBox();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnPostDateDesc = new System.Windows.Forms.RadioButton();
            this.rbtnPostDateAsc = new System.Windows.Forms.RadioButton();
            this.rbtnRatingDesc = new System.Windows.Forms.RadioButton();
            this.rbtnRatingAsc = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllReviews = new System.Windows.Forms.Button();
            this.btnRemoveReview = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAnime.SuspendLayout();
            this.BroupBoxSortAnime.SuspendLayout();
            this.groupBoxSearchAnime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingUpperAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingLowerAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesToSearchAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesFromSearchAnime)).BeginInit();
            this.tabManga.SuspendLayout();
            this.groupBoxSortManga.SuspendLayout();
            this.groupBoxSearchManga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingUpperManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingLowerManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersToManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersFromManga)).BeginInit();
            this.tabCharacters.SuspendLayout();
            this.groupBoxSortCharacters.SuspendLayout();
            this.groupBoxSearchCharacters.SuspendLayout();
            this.tabCreateAccount.SuspendLayout();
            this.groupBoxSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabReviews.SuspendLayout();
            this.groupBoxSearchReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingReview)).BeginInit();
            this.groupBoxSortReviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleWorldOfAnime
            // 
            this.labelTitleWorldOfAnime.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleWorldOfAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitleWorldOfAnime.ForeColor = System.Drawing.Color.Indigo;
            this.labelTitleWorldOfAnime.Location = new System.Drawing.Point(14, 9);
            this.labelTitleWorldOfAnime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitleWorldOfAnime.Name = "labelTitleWorldOfAnime";
            this.labelTitleWorldOfAnime.Size = new System.Drawing.Size(1856, 74);
            this.labelTitleWorldOfAnime.TabIndex = 1;
            this.labelTitleWorldOfAnime.Text = "World of Anime";
            this.labelTitleWorldOfAnime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.tabControl.Controls.Add(this.tabAnime);
            this.tabControl.Controls.Add(this.tabManga);
            this.tabControl.Controls.Add(this.tabCharacters);
            this.tabControl.Controls.Add(this.tabReviews);
            this.tabControl.Controls.Add(this.tabCreateAccount);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(56, 97);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(80, 9);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1805, 902);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabAnime
            // 
            this.tabAnime.BackColor = System.Drawing.Color.Thistle;
            this.tabAnime.Controls.Add(this.BroupBoxSortAnime);
            this.tabAnime.Controls.Add(this.btnRemoveAnime);
            this.tabAnime.Controls.Add(this.btnAddAnime);
            this.tabAnime.Controls.Add(this.lvwAnime);
            this.tabAnime.Controls.Add(this.btnEditAnime);
            this.tabAnime.Controls.Add(this.groupBoxSearchAnime);
            this.tabAnime.Location = new System.Drawing.Point(4, 46);
            this.tabAnime.Name = "tabAnime";
            this.tabAnime.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnime.Size = new System.Drawing.Size(1797, 852);
            this.tabAnime.TabIndex = 0;
            this.tabAnime.Text = "Anime";
            // 
            // BroupBoxSortAnime
            // 
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeRatingDesc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeRatingAsc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeReleaseYearDesc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeReleaseYearAsc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeStudioDesc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeStudioAsc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeNameDesc);
            this.BroupBoxSortAnime.Controls.Add(this.rbtnAnimeNameAsc);
            this.BroupBoxSortAnime.Controls.Add(this.btnDisplayAllAnime);
            this.BroupBoxSortAnime.Location = new System.Drawing.Point(15, 452);
            this.BroupBoxSortAnime.Name = "BroupBoxSortAnime";
            this.BroupBoxSortAnime.Size = new System.Drawing.Size(515, 273);
            this.BroupBoxSortAnime.TabIndex = 42;
            this.BroupBoxSortAnime.TabStop = false;
            this.BroupBoxSortAnime.Text = "Sort anime by:";
            // 
            // rbtnAnimeRatingDesc
            // 
            this.rbtnAnimeRatingDesc.AutoSize = true;
            this.rbtnAnimeRatingDesc.Location = new System.Drawing.Point(268, 152);
            this.rbtnAnimeRatingDesc.Name = "rbtnAnimeRatingDesc";
            this.rbtnAnimeRatingDesc.Size = new System.Drawing.Size(110, 30);
            this.rbtnAnimeRatingDesc.TabIndex = 45;
            this.rbtnAnimeRatingDesc.TabStop = true;
            this.rbtnAnimeRatingDesc.Text = "Rating ↓";
            this.rbtnAnimeRatingDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeRatingAsc
            // 
            this.rbtnAnimeRatingAsc.AutoSize = true;
            this.rbtnAnimeRatingAsc.Location = new System.Drawing.Point(32, 152);
            this.rbtnAnimeRatingAsc.Name = "rbtnAnimeRatingAsc";
            this.rbtnAnimeRatingAsc.Size = new System.Drawing.Size(110, 30);
            this.rbtnAnimeRatingAsc.TabIndex = 44;
            this.rbtnAnimeRatingAsc.TabStop = true;
            this.rbtnAnimeRatingAsc.Text = "Rating ↑";
            this.rbtnAnimeRatingAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeReleaseYearDesc
            // 
            this.rbtnAnimeReleaseYearDesc.AutoSize = true;
            this.rbtnAnimeReleaseYearDesc.Location = new System.Drawing.Point(268, 116);
            this.rbtnAnimeReleaseYearDesc.Name = "rbtnAnimeReleaseYearDesc";
            this.rbtnAnimeReleaseYearDesc.Size = new System.Drawing.Size(175, 30);
            this.rbtnAnimeReleaseYearDesc.TabIndex = 43;
            this.rbtnAnimeReleaseYearDesc.TabStop = true;
            this.rbtnAnimeReleaseYearDesc.Text = "Release year ↓";
            this.rbtnAnimeReleaseYearDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeReleaseYearAsc
            // 
            this.rbtnAnimeReleaseYearAsc.AutoSize = true;
            this.rbtnAnimeReleaseYearAsc.Location = new System.Drawing.Point(33, 116);
            this.rbtnAnimeReleaseYearAsc.Name = "rbtnAnimeReleaseYearAsc";
            this.rbtnAnimeReleaseYearAsc.Size = new System.Drawing.Size(175, 30);
            this.rbtnAnimeReleaseYearAsc.TabIndex = 42;
            this.rbtnAnimeReleaseYearAsc.TabStop = true;
            this.rbtnAnimeReleaseYearAsc.Text = "Release year ↑";
            this.rbtnAnimeReleaseYearAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeStudioDesc
            // 
            this.rbtnAnimeStudioDesc.AutoSize = true;
            this.rbtnAnimeStudioDesc.Location = new System.Drawing.Point(268, 80);
            this.rbtnAnimeStudioDesc.Name = "rbtnAnimeStudioDesc";
            this.rbtnAnimeStudioDesc.Size = new System.Drawing.Size(109, 30);
            this.rbtnAnimeStudioDesc.TabIndex = 41;
            this.rbtnAnimeStudioDesc.TabStop = true;
            this.rbtnAnimeStudioDesc.Text = "Studio ↓";
            this.rbtnAnimeStudioDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeStudioAsc
            // 
            this.rbtnAnimeStudioAsc.AutoSize = true;
            this.rbtnAnimeStudioAsc.Location = new System.Drawing.Point(33, 80);
            this.rbtnAnimeStudioAsc.Name = "rbtnAnimeStudioAsc";
            this.rbtnAnimeStudioAsc.Size = new System.Drawing.Size(109, 30);
            this.rbtnAnimeStudioAsc.TabIndex = 40;
            this.rbtnAnimeStudioAsc.TabStop = true;
            this.rbtnAnimeStudioAsc.Text = "Studio ↑";
            this.rbtnAnimeStudioAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeNameDesc
            // 
            this.rbtnAnimeNameDesc.AutoSize = true;
            this.rbtnAnimeNameDesc.Location = new System.Drawing.Point(268, 44);
            this.rbtnAnimeNameDesc.Name = "rbtnAnimeNameDesc";
            this.rbtnAnimeNameDesc.Size = new System.Drawing.Size(106, 30);
            this.rbtnAnimeNameDesc.TabIndex = 39;
            this.rbtnAnimeNameDesc.TabStop = true;
            this.rbtnAnimeNameDesc.Text = "Name ↓";
            this.rbtnAnimeNameDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeNameAsc
            // 
            this.rbtnAnimeNameAsc.AutoSize = true;
            this.rbtnAnimeNameAsc.Location = new System.Drawing.Point(33, 44);
            this.rbtnAnimeNameAsc.Name = "rbtnAnimeNameAsc";
            this.rbtnAnimeNameAsc.Size = new System.Drawing.Size(106, 30);
            this.rbtnAnimeNameAsc.TabIndex = 38;
            this.rbtnAnimeNameAsc.TabStop = true;
            this.rbtnAnimeNameAsc.Text = "Name ↑";
            this.rbtnAnimeNameAsc.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllAnime
            // 
            this.btnDisplayAllAnime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDisplayAllAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAllAnime.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAllAnime.Location = new System.Drawing.Point(21, 200);
            this.btnDisplayAllAnime.Name = "btnDisplayAllAnime";
            this.btnDisplayAllAnime.Size = new System.Drawing.Size(472, 54);
            this.btnDisplayAllAnime.TabIndex = 37;
            this.btnDisplayAllAnime.Text = "Display all";
            this.btnDisplayAllAnime.UseVisualStyleBackColor = false;
            this.btnDisplayAllAnime.Click += new System.EventHandler(this.btnDisplayAllAnime_Click);
            // 
            // btnRemoveAnime
            // 
            this.btnRemoveAnime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRemoveAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAnime.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAnime.Location = new System.Drawing.Point(1405, 753);
            this.btnRemoveAnime.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveAnime.Name = "btnRemoveAnime";
            this.btnRemoveAnime.Size = new System.Drawing.Size(353, 72);
            this.btnRemoveAnime.TabIndex = 41;
            this.btnRemoveAnime.Text = "Remove Anime";
            this.btnRemoveAnime.UseVisualStyleBackColor = false;
            this.btnRemoveAnime.Click += new System.EventHandler(this.btnRemoveAnime_Click);
            // 
            // btnAddAnime
            // 
            this.btnAddAnime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnime.ForeColor = System.Drawing.Color.Black;
            this.btnAddAnime.Location = new System.Drawing.Point(580, 753);
            this.btnAddAnime.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddAnime.Name = "btnAddAnime";
            this.btnAddAnime.Size = new System.Drawing.Size(353, 72);
            this.btnAddAnime.TabIndex = 40;
            this.btnAddAnime.Text = "Add Anime";
            this.btnAddAnime.UseVisualStyleBackColor = false;
            this.btnAddAnime.Click += new System.EventHandler(this.btnAddAnime_Click);
            // 
            // lvwAnime
            // 
            this.lvwAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAnimeName,
            this.colAnimeStudio,
            this.colAnimeRating,
            this.colAnimeReleaseYear,
            this.colAnimeReleaseSeason,
            this.colAnimeNrEpisodes});
            this.lvwAnime.FullRowSelect = true;
            this.lvwAnime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwAnime.Location = new System.Drawing.Point(580, 29);
            this.lvwAnime.MultiSelect = false;
            this.lvwAnime.Name = "lvwAnime";
            this.lvwAnime.Size = new System.Drawing.Size(1178, 696);
            this.lvwAnime.TabIndex = 39;
            this.lvwAnime.UseCompatibleStateImageBehavior = false;
            this.lvwAnime.View = System.Windows.Forms.View.Details;
            this.lvwAnime.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwAnime_MouseDoubleClick);
            // 
            // colAnimeName
            // 
            this.colAnimeName.Text = "Name";
            this.colAnimeName.Width = 270;
            // 
            // colAnimeStudio
            // 
            this.colAnimeStudio.Text = "Studio";
            this.colAnimeStudio.Width = 210;
            // 
            // colAnimeRating
            // 
            this.colAnimeRating.Text = "Rating";
            this.colAnimeRating.Width = 140;
            // 
            // colAnimeReleaseYear
            // 
            this.colAnimeReleaseYear.Text = "Release Year";
            this.colAnimeReleaseYear.Width = 190;
            // 
            // colAnimeReleaseSeason
            // 
            this.colAnimeReleaseSeason.Text = "Season";
            this.colAnimeReleaseSeason.Width = 190;
            // 
            // colAnimeNrEpisodes
            // 
            this.colAnimeNrEpisodes.Text = "Nr episodes";
            this.colAnimeNrEpisodes.Width = 160;
            // 
            // btnEditAnime
            // 
            this.btnEditAnime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEditAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditAnime.ForeColor = System.Drawing.Color.Black;
            this.btnEditAnime.Location = new System.Drawing.Point(993, 753);
            this.btnEditAnime.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditAnime.Name = "btnEditAnime";
            this.btnEditAnime.Size = new System.Drawing.Size(353, 72);
            this.btnEditAnime.TabIndex = 38;
            this.btnEditAnime.Text = "Edit Anime";
            this.btnEditAnime.UseVisualStyleBackColor = false;
            this.btnEditAnime.Click += new System.EventHandler(this.btnEditAnime_Click);
            // 
            // groupBoxSearchAnime
            // 
            this.groupBoxSearchAnime.Controls.Add(this.numRatingUpperAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelRatingToAnime);
            this.groupBoxSearchAnime.Controls.Add(this.btnClearSearch);
            this.groupBoxSearchAnime.Controls.Add(this.tbxReleaseYearSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.numRatingLowerAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelRatingSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.cbxSeasonSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelReleaseSeasonSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.btnSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.cbxGenreSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelGenreSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelYearSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.numNrEpisodesToSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelNrEpisodesToSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.numNrEpisodesFromSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelNrEpisodesFromSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.tbxStudioSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelStudioSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.tbxNameSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.labelNameSearchAnime);
            this.groupBoxSearchAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAnime.Location = new System.Drawing.Point(15, 18);
            this.groupBoxSearchAnime.Name = "groupBoxSearchAnime";
            this.groupBoxSearchAnime.Size = new System.Drawing.Size(515, 419);
            this.groupBoxSearchAnime.TabIndex = 2;
            this.groupBoxSearchAnime.TabStop = false;
            this.groupBoxSearchAnime.Text = "Anime search:";
            // 
            // numRatingUpperAnime
            // 
            this.numRatingUpperAnime.DecimalPlaces = 1;
            this.numRatingUpperAnime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingUpperAnime.Location = new System.Drawing.Point(316, 293);
            this.numRatingUpperAnime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingUpperAnime.Name = "numRatingUpperAnime";
            this.numRatingUpperAnime.Size = new System.Drawing.Size(90, 32);
            this.numRatingUpperAnime.TabIndex = 46;
            // 
            // labelRatingToAnime
            // 
            this.labelRatingToAnime.AutoSize = true;
            this.labelRatingToAnime.Location = new System.Drawing.Point(268, 295);
            this.labelRatingToAnime.Name = "labelRatingToAnime";
            this.labelRatingToAnime.Size = new System.Drawing.Size(42, 26);
            this.labelRatingToAnime.TabIndex = 45;
            this.labelRatingToAnime.Text = "To:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.btnClearSearch.Location = new System.Drawing.Point(268, 346);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(225, 54);
            this.btnClearSearch.TabIndex = 44;
            this.btnClearSearch.Text = "Clear fields";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // tbxReleaseYearSearchAnime
            // 
            this.tbxReleaseYearSearchAnime.Location = new System.Drawing.Point(201, 168);
            this.tbxReleaseYearSearchAnime.Name = "tbxReleaseYearSearchAnime";
            this.tbxReleaseYearSearchAnime.Size = new System.Drawing.Size(155, 32);
            this.tbxReleaseYearSearchAnime.TabIndex = 43;
            // 
            // numRatingLowerAnime
            // 
            this.numRatingLowerAnime.DecimalPlaces = 1;
            this.numRatingLowerAnime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingLowerAnime.Location = new System.Drawing.Point(156, 293);
            this.numRatingLowerAnime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingLowerAnime.Name = "numRatingLowerAnime";
            this.numRatingLowerAnime.Size = new System.Drawing.Size(90, 32);
            this.numRatingLowerAnime.TabIndex = 42;
            // 
            // labelRatingSearchAnime
            // 
            this.labelRatingSearchAnime.AutoSize = true;
            this.labelRatingSearchAnime.Location = new System.Drawing.Point(21, 295);
            this.labelRatingSearchAnime.Name = "labelRatingSearchAnime";
            this.labelRatingSearchAnime.Size = new System.Drawing.Size(131, 26);
            this.labelRatingSearchAnime.TabIndex = 41;
            this.labelRatingSearchAnime.Text = "Rating from:";
            // 
            // cbxSeasonSearchAnime
            // 
            this.cbxSeasonSearchAnime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeasonSearchAnime.ItemHeight = 25;
            this.cbxSeasonSearchAnime.Location = new System.Drawing.Point(201, 210);
            this.cbxSeasonSearchAnime.Name = "cbxSeasonSearchAnime";
            this.cbxSeasonSearchAnime.Size = new System.Drawing.Size(155, 33);
            this.cbxSeasonSearchAnime.TabIndex = 40;
            // 
            // labelReleaseSeasonSearchAnime
            // 
            this.labelReleaseSeasonSearchAnime.AutoSize = true;
            this.labelReleaseSeasonSearchAnime.Location = new System.Drawing.Point(21, 213);
            this.labelReleaseSeasonSearchAnime.Name = "labelReleaseSeasonSearchAnime";
            this.labelReleaseSeasonSearchAnime.Size = new System.Drawing.Size(174, 26);
            this.labelReleaseSeasonSearchAnime.TabIndex = 39;
            this.labelReleaseSeasonSearchAnime.Text = "Release season:";
            // 
            // btnSearchAnime
            // 
            this.btnSearchAnime.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAnime.ForeColor = System.Drawing.Color.Black;
            this.btnSearchAnime.Location = new System.Drawing.Point(21, 346);
            this.btnSearchAnime.Name = "btnSearchAnime";
            this.btnSearchAnime.Size = new System.Drawing.Size(225, 54);
            this.btnSearchAnime.TabIndex = 38;
            this.btnSearchAnime.Text = "Search";
            this.btnSearchAnime.UseVisualStyleBackColor = false;
            this.btnSearchAnime.Click += new System.EventHandler(this.btnSearchAnime_Click);
            // 
            // cbxGenreSearchAnime
            // 
            this.cbxGenreSearchAnime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenreSearchAnime.ItemHeight = 25;
            this.cbxGenreSearchAnime.Location = new System.Drawing.Point(116, 252);
            this.cbxGenreSearchAnime.Name = "cbxGenreSearchAnime";
            this.cbxGenreSearchAnime.Size = new System.Drawing.Size(240, 33);
            this.cbxGenreSearchAnime.TabIndex = 20;
            // 
            // labelGenreSearchAnime
            // 
            this.labelGenreSearchAnime.AutoSize = true;
            this.labelGenreSearchAnime.Location = new System.Drawing.Point(21, 255);
            this.labelGenreSearchAnime.Name = "labelGenreSearchAnime";
            this.labelGenreSearchAnime.Size = new System.Drawing.Size(78, 26);
            this.labelGenreSearchAnime.TabIndex = 19;
            this.labelGenreSearchAnime.Text = "Genre:";
            // 
            // labelYearSearchAnime
            // 
            this.labelYearSearchAnime.AutoSize = true;
            this.labelYearSearchAnime.Location = new System.Drawing.Point(21, 171);
            this.labelYearSearchAnime.Name = "labelYearSearchAnime";
            this.labelYearSearchAnime.Size = new System.Drawing.Size(146, 26);
            this.labelYearSearchAnime.TabIndex = 13;
            this.labelYearSearchAnime.Text = "Release year:";
            // 
            // numNrEpisodesToSearchAnime
            // 
            this.numNrEpisodesToSearchAnime.Location = new System.Drawing.Point(400, 126);
            this.numNrEpisodesToSearchAnime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNrEpisodesToSearchAnime.Name = "numNrEpisodesToSearchAnime";
            this.numNrEpisodesToSearchAnime.Size = new System.Drawing.Size(93, 32);
            this.numNrEpisodesToSearchAnime.TabIndex = 12;
            // 
            // labelNrEpisodesToSearchAnime
            // 
            this.labelNrEpisodesToSearchAnime.AutoSize = true;
            this.labelNrEpisodesToSearchAnime.Location = new System.Drawing.Point(352, 128);
            this.labelNrEpisodesToSearchAnime.Name = "labelNrEpisodesToSearchAnime";
            this.labelNrEpisodesToSearchAnime.Size = new System.Drawing.Size(42, 26);
            this.labelNrEpisodesToSearchAnime.TabIndex = 11;
            this.labelNrEpisodesToSearchAnime.Text = "To:";
            // 
            // numNrEpisodesFromSearchAnime
            // 
            this.numNrEpisodesFromSearchAnime.Location = new System.Drawing.Point(235, 126);
            this.numNrEpisodesFromSearchAnime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNrEpisodesFromSearchAnime.Name = "numNrEpisodesFromSearchAnime";
            this.numNrEpisodesFromSearchAnime.Size = new System.Drawing.Size(93, 32);
            this.numNrEpisodesFromSearchAnime.TabIndex = 10;
            // 
            // labelNrEpisodesFromSearchAnime
            // 
            this.labelNrEpisodesFromSearchAnime.AutoSize = true;
            this.labelNrEpisodesFromSearchAnime.Location = new System.Drawing.Point(21, 128);
            this.labelNrEpisodesFromSearchAnime.Name = "labelNrEpisodesFromSearchAnime";
            this.labelNrEpisodesFromSearchAnime.Size = new System.Drawing.Size(208, 26);
            this.labelNrEpisodesFromSearchAnime.TabIndex = 7;
            this.labelNrEpisodesFromSearchAnime.Text = "Nr of episodes from:";
            // 
            // tbxStudioSearchAnime
            // 
            this.tbxStudioSearchAnime.Location = new System.Drawing.Point(121, 81);
            this.tbxStudioSearchAnime.Name = "tbxStudioSearchAnime";
            this.tbxStudioSearchAnime.Size = new System.Drawing.Size(277, 32);
            this.tbxStudioSearchAnime.TabIndex = 6;
            // 
            // labelStudioSearchAnime
            // 
            this.labelStudioSearchAnime.AutoSize = true;
            this.labelStudioSearchAnime.Location = new System.Drawing.Point(21, 84);
            this.labelStudioSearchAnime.Name = "labelStudioSearchAnime";
            this.labelStudioSearchAnime.Size = new System.Drawing.Size(80, 26);
            this.labelStudioSearchAnime.TabIndex = 5;
            this.labelStudioSearchAnime.Text = "Studio:";
            // 
            // tbxNameSearchAnime
            // 
            this.tbxNameSearchAnime.Location = new System.Drawing.Point(121, 39);
            this.tbxNameSearchAnime.Name = "tbxNameSearchAnime";
            this.tbxNameSearchAnime.Size = new System.Drawing.Size(277, 32);
            this.tbxNameSearchAnime.TabIndex = 4;
            // 
            // labelNameSearchAnime
            // 
            this.labelNameSearchAnime.AutoSize = true;
            this.labelNameSearchAnime.Location = new System.Drawing.Point(21, 42);
            this.labelNameSearchAnime.Name = "labelNameSearchAnime";
            this.labelNameSearchAnime.Size = new System.Drawing.Size(77, 26);
            this.labelNameSearchAnime.TabIndex = 1;
            this.labelNameSearchAnime.Text = "Name:";
            // 
            // tabManga
            // 
            this.tabManga.BackColor = System.Drawing.Color.Thistle;
            this.tabManga.Controls.Add(this.btnRemoveManga);
            this.tabManga.Controls.Add(this.btnAddManga);
            this.tabManga.Controls.Add(this.btnEditManga);
            this.tabManga.Controls.Add(this.groupBoxSortManga);
            this.tabManga.Controls.Add(this.lvwManga);
            this.tabManga.Controls.Add(this.groupBoxSearchManga);
            this.tabManga.Location = new System.Drawing.Point(4, 46);
            this.tabManga.Name = "tabManga";
            this.tabManga.Padding = new System.Windows.Forms.Padding(3);
            this.tabManga.Size = new System.Drawing.Size(1797, 852);
            this.tabManga.TabIndex = 1;
            this.tabManga.Text = "Manga";
            // 
            // btnRemoveManga
            // 
            this.btnRemoveManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRemoveManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveManga.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveManga.Location = new System.Drawing.Point(1406, 751);
            this.btnRemoveManga.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveManga.Name = "btnRemoveManga";
            this.btnRemoveManga.Size = new System.Drawing.Size(353, 72);
            this.btnRemoveManga.TabIndex = 46;
            this.btnRemoveManga.Text = "Remove Manga";
            this.btnRemoveManga.UseVisualStyleBackColor = false;
            this.btnRemoveManga.Click += new System.EventHandler(this.btnRemoveManga_Click);
            // 
            // btnAddManga
            // 
            this.btnAddManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddManga.ForeColor = System.Drawing.Color.Black;
            this.btnAddManga.Location = new System.Drawing.Point(581, 751);
            this.btnAddManga.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddManga.Name = "btnAddManga";
            this.btnAddManga.Size = new System.Drawing.Size(353, 72);
            this.btnAddManga.TabIndex = 45;
            this.btnAddManga.Text = "Add Manga";
            this.btnAddManga.UseVisualStyleBackColor = false;
            this.btnAddManga.Click += new System.EventHandler(this.btnAddManga_Click);
            // 
            // btnEditManga
            // 
            this.btnEditManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEditManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditManga.ForeColor = System.Drawing.Color.Black;
            this.btnEditManga.Location = new System.Drawing.Point(994, 751);
            this.btnEditManga.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditManga.Name = "btnEditManga";
            this.btnEditManga.Size = new System.Drawing.Size(353, 72);
            this.btnEditManga.TabIndex = 44;
            this.btnEditManga.Text = "Edit Manga";
            this.btnEditManga.UseVisualStyleBackColor = false;
            this.btnEditManga.Click += new System.EventHandler(this.btnEditManga_Click);
            // 
            // groupBoxSortManga
            // 
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaRatingDesc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaRatingAsc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaReleaseYearDesc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaReleaseYearAsc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaCreatorDesc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaCreatorAsc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaNameDesc);
            this.groupBoxSortManga.Controls.Add(this.rbtnMangaNameAsc);
            this.groupBoxSortManga.Controls.Add(this.btnDisplayAllManga);
            this.groupBoxSortManga.Location = new System.Drawing.Point(15, 452);
            this.groupBoxSortManga.Name = "groupBoxSortManga";
            this.groupBoxSortManga.Size = new System.Drawing.Size(515, 273);
            this.groupBoxSortManga.TabIndex = 43;
            this.groupBoxSortManga.TabStop = false;
            this.groupBoxSortManga.Text = "Sort manga by:";
            // 
            // rbtnMangaRatingDesc
            // 
            this.rbtnMangaRatingDesc.AutoSize = true;
            this.rbtnMangaRatingDesc.Location = new System.Drawing.Point(268, 152);
            this.rbtnMangaRatingDesc.Name = "rbtnMangaRatingDesc";
            this.rbtnMangaRatingDesc.Size = new System.Drawing.Size(110, 30);
            this.rbtnMangaRatingDesc.TabIndex = 45;
            this.rbtnMangaRatingDesc.TabStop = true;
            this.rbtnMangaRatingDesc.Text = "Rating ↓";
            this.rbtnMangaRatingDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaRatingAsc
            // 
            this.rbtnMangaRatingAsc.AutoSize = true;
            this.rbtnMangaRatingAsc.Location = new System.Drawing.Point(32, 152);
            this.rbtnMangaRatingAsc.Name = "rbtnMangaRatingAsc";
            this.rbtnMangaRatingAsc.Size = new System.Drawing.Size(110, 30);
            this.rbtnMangaRatingAsc.TabIndex = 44;
            this.rbtnMangaRatingAsc.TabStop = true;
            this.rbtnMangaRatingAsc.Text = "Rating ↑";
            this.rbtnMangaRatingAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaReleaseYearDesc
            // 
            this.rbtnMangaReleaseYearDesc.AutoSize = true;
            this.rbtnMangaReleaseYearDesc.Location = new System.Drawing.Point(268, 116);
            this.rbtnMangaReleaseYearDesc.Name = "rbtnMangaReleaseYearDesc";
            this.rbtnMangaReleaseYearDesc.Size = new System.Drawing.Size(175, 30);
            this.rbtnMangaReleaseYearDesc.TabIndex = 43;
            this.rbtnMangaReleaseYearDesc.TabStop = true;
            this.rbtnMangaReleaseYearDesc.Text = "Release year ↓";
            this.rbtnMangaReleaseYearDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaReleaseYearAsc
            // 
            this.rbtnMangaReleaseYearAsc.AutoSize = true;
            this.rbtnMangaReleaseYearAsc.Location = new System.Drawing.Point(33, 116);
            this.rbtnMangaReleaseYearAsc.Name = "rbtnMangaReleaseYearAsc";
            this.rbtnMangaReleaseYearAsc.Size = new System.Drawing.Size(175, 30);
            this.rbtnMangaReleaseYearAsc.TabIndex = 42;
            this.rbtnMangaReleaseYearAsc.TabStop = true;
            this.rbtnMangaReleaseYearAsc.Text = "Release year ↑";
            this.rbtnMangaReleaseYearAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaCreatorDesc
            // 
            this.rbtnMangaCreatorDesc.AutoSize = true;
            this.rbtnMangaCreatorDesc.Location = new System.Drawing.Point(268, 80);
            this.rbtnMangaCreatorDesc.Name = "rbtnMangaCreatorDesc";
            this.rbtnMangaCreatorDesc.Size = new System.Drawing.Size(119, 30);
            this.rbtnMangaCreatorDesc.TabIndex = 41;
            this.rbtnMangaCreatorDesc.TabStop = true;
            this.rbtnMangaCreatorDesc.Text = "Creator ↓";
            this.rbtnMangaCreatorDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaCreatorAsc
            // 
            this.rbtnMangaCreatorAsc.AutoSize = true;
            this.rbtnMangaCreatorAsc.Location = new System.Drawing.Point(33, 80);
            this.rbtnMangaCreatorAsc.Name = "rbtnMangaCreatorAsc";
            this.rbtnMangaCreatorAsc.Size = new System.Drawing.Size(119, 30);
            this.rbtnMangaCreatorAsc.TabIndex = 40;
            this.rbtnMangaCreatorAsc.TabStop = true;
            this.rbtnMangaCreatorAsc.Text = "Creator ↑";
            this.rbtnMangaCreatorAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaNameDesc
            // 
            this.rbtnMangaNameDesc.AutoSize = true;
            this.rbtnMangaNameDesc.Location = new System.Drawing.Point(268, 44);
            this.rbtnMangaNameDesc.Name = "rbtnMangaNameDesc";
            this.rbtnMangaNameDesc.Size = new System.Drawing.Size(106, 30);
            this.rbtnMangaNameDesc.TabIndex = 39;
            this.rbtnMangaNameDesc.TabStop = true;
            this.rbtnMangaNameDesc.Text = "Name ↓";
            this.rbtnMangaNameDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaNameAsc
            // 
            this.rbtnMangaNameAsc.AutoSize = true;
            this.rbtnMangaNameAsc.Location = new System.Drawing.Point(33, 44);
            this.rbtnMangaNameAsc.Name = "rbtnMangaNameAsc";
            this.rbtnMangaNameAsc.Size = new System.Drawing.Size(106, 30);
            this.rbtnMangaNameAsc.TabIndex = 38;
            this.rbtnMangaNameAsc.TabStop = true;
            this.rbtnMangaNameAsc.Text = "Name ↑";
            this.rbtnMangaNameAsc.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllManga
            // 
            this.btnDisplayAllManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDisplayAllManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAllManga.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAllManga.Location = new System.Drawing.Point(21, 200);
            this.btnDisplayAllManga.Name = "btnDisplayAllManga";
            this.btnDisplayAllManga.Size = new System.Drawing.Size(472, 54);
            this.btnDisplayAllManga.TabIndex = 37;
            this.btnDisplayAllManga.Text = "Display all";
            this.btnDisplayAllManga.UseVisualStyleBackColor = false;
            this.btnDisplayAllManga.Click += new System.EventHandler(this.btnDisplayAllManga_Click);
            // 
            // lvwManga
            // 
            this.lvwManga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameManga,
            this.columnCreator,
            this.columnRatingManga,
            this.columnReleaseYearManga,
            this.columnStatus,
            this.columnNrChapters});
            this.lvwManga.FullRowSelect = true;
            this.lvwManga.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwManga.Location = new System.Drawing.Point(581, 29);
            this.lvwManga.MultiSelect = false;
            this.lvwManga.Name = "lvwManga";
            this.lvwManga.Size = new System.Drawing.Size(1178, 696);
            this.lvwManga.TabIndex = 40;
            this.lvwManga.UseCompatibleStateImageBehavior = false;
            this.lvwManga.View = System.Windows.Forms.View.Details;
            // 
            // columnNameManga
            // 
            this.columnNameManga.Text = "Name";
            this.columnNameManga.Width = 270;
            // 
            // columnCreator
            // 
            this.columnCreator.Text = "Creator";
            this.columnCreator.Width = 210;
            // 
            // columnRatingManga
            // 
            this.columnRatingManga.Text = "Rating";
            this.columnRatingManga.Width = 140;
            // 
            // columnReleaseYearManga
            // 
            this.columnReleaseYearManga.Text = "Release Year";
            this.columnReleaseYearManga.Width = 190;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 200;
            // 
            // columnNrChapters
            // 
            this.columnNrChapters.Text = "Nr chapters";
            this.columnNrChapters.Width = 160;
            // 
            // groupBoxSearchManga
            // 
            this.groupBoxSearchManga.Controls.Add(this.numRatingUpperManga);
            this.groupBoxSearchManga.Controls.Add(this.btnClearSearchManga);
            this.groupBoxSearchManga.Controls.Add(this.tbxReleaseYearManga);
            this.groupBoxSearchManga.Controls.Add(this.labelRatingToManga);
            this.groupBoxSearchManga.Controls.Add(this.cbxMangaStatus);
            this.groupBoxSearchManga.Controls.Add(this.labelMangaStatus);
            this.groupBoxSearchManga.Controls.Add(this.numRatingLowerManga);
            this.groupBoxSearchManga.Controls.Add(this.btnSearchManga);
            this.groupBoxSearchManga.Controls.Add(this.cbxGenreManga);
            this.groupBoxSearchManga.Controls.Add(this.labelRatingFromManga);
            this.groupBoxSearchManga.Controls.Add(this.labelGenreManga);
            this.groupBoxSearchManga.Controls.Add(this.labelReleaseYearManga);
            this.groupBoxSearchManga.Controls.Add(this.numChaptersToManga);
            this.groupBoxSearchManga.Controls.Add(this.labelChaptersToManga);
            this.groupBoxSearchManga.Controls.Add(this.numChaptersFromManga);
            this.groupBoxSearchManga.Controls.Add(this.labelNrChaptersFromManga);
            this.groupBoxSearchManga.Controls.Add(this.tbxCreatorManga);
            this.groupBoxSearchManga.Controls.Add(this.labelCreatorManga);
            this.groupBoxSearchManga.Controls.Add(this.tbxNameManga);
            this.groupBoxSearchManga.Controls.Add(this.labeNameManga);
            this.groupBoxSearchManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchManga.Location = new System.Drawing.Point(15, 17);
            this.groupBoxSearchManga.Name = "groupBoxSearchManga";
            this.groupBoxSearchManga.Size = new System.Drawing.Size(515, 419);
            this.groupBoxSearchManga.TabIndex = 3;
            this.groupBoxSearchManga.TabStop = false;
            this.groupBoxSearchManga.Text = "Manga search:";
            // 
            // numRatingUpperManga
            // 
            this.numRatingUpperManga.DecimalPlaces = 1;
            this.numRatingUpperManga.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingUpperManga.Location = new System.Drawing.Point(316, 296);
            this.numRatingUpperManga.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingUpperManga.Name = "numRatingUpperManga";
            this.numRatingUpperManga.Size = new System.Drawing.Size(90, 32);
            this.numRatingUpperManga.TabIndex = 50;
            // 
            // btnClearSearchManga
            // 
            this.btnClearSearchManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearSearchManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearSearchManga.ForeColor = System.Drawing.Color.Black;
            this.btnClearSearchManga.Location = new System.Drawing.Point(268, 346);
            this.btnClearSearchManga.Name = "btnClearSearchManga";
            this.btnClearSearchManga.Size = new System.Drawing.Size(225, 54);
            this.btnClearSearchManga.TabIndex = 44;
            this.btnClearSearchManga.Text = "Clear fields";
            this.btnClearSearchManga.UseVisualStyleBackColor = false;
            this.btnClearSearchManga.Click += new System.EventHandler(this.btnClearSearchManga_Click);
            // 
            // tbxReleaseYearManga
            // 
            this.tbxReleaseYearManga.Location = new System.Drawing.Point(173, 168);
            this.tbxReleaseYearManga.Name = "tbxReleaseYearManga";
            this.tbxReleaseYearManga.Size = new System.Drawing.Size(183, 32);
            this.tbxReleaseYearManga.TabIndex = 43;
            // 
            // labelRatingToManga
            // 
            this.labelRatingToManga.AutoSize = true;
            this.labelRatingToManga.Location = new System.Drawing.Point(268, 298);
            this.labelRatingToManga.Name = "labelRatingToManga";
            this.labelRatingToManga.Size = new System.Drawing.Size(42, 26);
            this.labelRatingToManga.TabIndex = 49;
            this.labelRatingToManga.Text = "To:";
            // 
            // cbxMangaStatus
            // 
            this.cbxMangaStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMangaStatus.FormattingEnabled = true;
            this.cbxMangaStatus.ItemHeight = 25;
            this.cbxMangaStatus.Location = new System.Drawing.Point(116, 210);
            this.cbxMangaStatus.Name = "cbxMangaStatus";
            this.cbxMangaStatus.Size = new System.Drawing.Size(240, 33);
            this.cbxMangaStatus.TabIndex = 40;
            // 
            // labelMangaStatus
            // 
            this.labelMangaStatus.AutoSize = true;
            this.labelMangaStatus.Location = new System.Drawing.Point(21, 213);
            this.labelMangaStatus.Name = "labelMangaStatus";
            this.labelMangaStatus.Size = new System.Drawing.Size(80, 26);
            this.labelMangaStatus.TabIndex = 39;
            this.labelMangaStatus.Text = "Status:";
            // 
            // numRatingLowerManga
            // 
            this.numRatingLowerManga.DecimalPlaces = 1;
            this.numRatingLowerManga.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingLowerManga.Location = new System.Drawing.Point(156, 296);
            this.numRatingLowerManga.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingLowerManga.Name = "numRatingLowerManga";
            this.numRatingLowerManga.Size = new System.Drawing.Size(90, 32);
            this.numRatingLowerManga.TabIndex = 48;
            // 
            // btnSearchManga
            // 
            this.btnSearchManga.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchManga.ForeColor = System.Drawing.Color.Black;
            this.btnSearchManga.Location = new System.Drawing.Point(21, 346);
            this.btnSearchManga.Name = "btnSearchManga";
            this.btnSearchManga.Size = new System.Drawing.Size(225, 54);
            this.btnSearchManga.TabIndex = 38;
            this.btnSearchManga.Text = "Search";
            this.btnSearchManga.UseVisualStyleBackColor = false;
            this.btnSearchManga.Click += new System.EventHandler(this.btnSearchManga_Click);
            // 
            // cbxGenreManga
            // 
            this.cbxGenreManga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenreManga.FormattingEnabled = true;
            this.cbxGenreManga.ItemHeight = 25;
            this.cbxGenreManga.Location = new System.Drawing.Point(116, 252);
            this.cbxGenreManga.Name = "cbxGenreManga";
            this.cbxGenreManga.Size = new System.Drawing.Size(240, 33);
            this.cbxGenreManga.TabIndex = 20;
            // 
            // labelRatingFromManga
            // 
            this.labelRatingFromManga.AutoSize = true;
            this.labelRatingFromManga.Location = new System.Drawing.Point(21, 298);
            this.labelRatingFromManga.Name = "labelRatingFromManga";
            this.labelRatingFromManga.Size = new System.Drawing.Size(131, 26);
            this.labelRatingFromManga.TabIndex = 47;
            this.labelRatingFromManga.Text = "Rating from:";
            // 
            // labelGenreManga
            // 
            this.labelGenreManga.AutoSize = true;
            this.labelGenreManga.Location = new System.Drawing.Point(21, 255);
            this.labelGenreManga.Name = "labelGenreManga";
            this.labelGenreManga.Size = new System.Drawing.Size(78, 26);
            this.labelGenreManga.TabIndex = 19;
            this.labelGenreManga.Text = "Genre:";
            // 
            // labelReleaseYearManga
            // 
            this.labelReleaseYearManga.AutoSize = true;
            this.labelReleaseYearManga.Location = new System.Drawing.Point(21, 171);
            this.labelReleaseYearManga.Name = "labelReleaseYearManga";
            this.labelReleaseYearManga.Size = new System.Drawing.Size(146, 26);
            this.labelReleaseYearManga.TabIndex = 13;
            this.labelReleaseYearManga.Text = "Release year:";
            // 
            // numChaptersToManga
            // 
            this.numChaptersToManga.Location = new System.Drawing.Point(396, 126);
            this.numChaptersToManga.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numChaptersToManga.Name = "numChaptersToManga";
            this.numChaptersToManga.Size = new System.Drawing.Size(93, 32);
            this.numChaptersToManga.TabIndex = 12;
            // 
            // labelChaptersToManga
            // 
            this.labelChaptersToManga.AutoSize = true;
            this.labelChaptersToManga.Location = new System.Drawing.Point(348, 128);
            this.labelChaptersToManga.Name = "labelChaptersToManga";
            this.labelChaptersToManga.Size = new System.Drawing.Size(42, 26);
            this.labelChaptersToManga.TabIndex = 11;
            this.labelChaptersToManga.Text = "To:";
            // 
            // numChaptersFromManga
            // 
            this.numChaptersFromManga.Location = new System.Drawing.Point(231, 126);
            this.numChaptersFromManga.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numChaptersFromManga.Name = "numChaptersFromManga";
            this.numChaptersFromManga.Size = new System.Drawing.Size(93, 32);
            this.numChaptersFromManga.TabIndex = 10;
            // 
            // labelNrChaptersFromManga
            // 
            this.labelNrChaptersFromManga.AutoSize = true;
            this.labelNrChaptersFromManga.Location = new System.Drawing.Point(21, 128);
            this.labelNrChaptersFromManga.Name = "labelNrChaptersFromManga";
            this.labelNrChaptersFromManga.Size = new System.Drawing.Size(204, 26);
            this.labelNrChaptersFromManga.TabIndex = 7;
            this.labelNrChaptersFromManga.Text = "Nr of chapters from:";
            // 
            // tbxCreatorManga
            // 
            this.tbxCreatorManga.Location = new System.Drawing.Point(121, 81);
            this.tbxCreatorManga.Name = "tbxCreatorManga";
            this.tbxCreatorManga.Size = new System.Drawing.Size(277, 32);
            this.tbxCreatorManga.TabIndex = 6;
            // 
            // labelCreatorManga
            // 
            this.labelCreatorManga.AutoSize = true;
            this.labelCreatorManga.Location = new System.Drawing.Point(21, 84);
            this.labelCreatorManga.Name = "labelCreatorManga";
            this.labelCreatorManga.Size = new System.Drawing.Size(90, 26);
            this.labelCreatorManga.TabIndex = 5;
            this.labelCreatorManga.Text = "Creator:";
            // 
            // tbxNameManga
            // 
            this.tbxNameManga.Location = new System.Drawing.Point(121, 39);
            this.tbxNameManga.Name = "tbxNameManga";
            this.tbxNameManga.Size = new System.Drawing.Size(277, 32);
            this.tbxNameManga.TabIndex = 4;
            // 
            // labeNameManga
            // 
            this.labeNameManga.AutoSize = true;
            this.labeNameManga.Location = new System.Drawing.Point(21, 42);
            this.labeNameManga.Name = "labeNameManga";
            this.labeNameManga.Size = new System.Drawing.Size(77, 26);
            this.labeNameManga.TabIndex = 1;
            this.labeNameManga.Text = "Name:";
            // 
            // tabCharacters
            // 
            this.tabCharacters.BackColor = System.Drawing.Color.Thistle;
            this.tabCharacters.Controls.Add(this.btnRemoveCharacter);
            this.tabCharacters.Controls.Add(this.btnAddCharacter);
            this.tabCharacters.Controls.Add(this.btnEditCharacter);
            this.tabCharacters.Controls.Add(this.groupBoxSortCharacters);
            this.tabCharacters.Controls.Add(this.lvwCharacters);
            this.tabCharacters.Controls.Add(this.groupBoxSearchCharacters);
            this.tabCharacters.Location = new System.Drawing.Point(4, 46);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacters.Size = new System.Drawing.Size(1797, 852);
            this.tabCharacters.TabIndex = 2;
            this.tabCharacters.Text = "Characters";
            // 
            // btnRemoveCharacter
            // 
            this.btnRemoveCharacter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRemoveCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCharacter.Location = new System.Drawing.Point(1407, 752);
            this.btnRemoveCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveCharacter.Name = "btnRemoveCharacter";
            this.btnRemoveCharacter.Size = new System.Drawing.Size(353, 72);
            this.btnRemoveCharacter.TabIndex = 49;
            this.btnRemoveCharacter.Text = "Remove Character";
            this.btnRemoveCharacter.UseVisualStyleBackColor = false;
            this.btnRemoveCharacter.Click += new System.EventHandler(this.btnRemoveCharacter_Click);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnAddCharacter.Location = new System.Drawing.Point(582, 752);
            this.btnAddCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(353, 72);
            this.btnAddCharacter.TabIndex = 48;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = false;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click);
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEditCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnEditCharacter.Location = new System.Drawing.Point(995, 752);
            this.btnEditCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(353, 72);
            this.btnEditCharacter.TabIndex = 47;
            this.btnEditCharacter.Text = "Edit Character";
            this.btnEditCharacter.UseVisualStyleBackColor = false;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // groupBoxSortCharacters
            // 
            this.groupBoxSortCharacters.Controls.Add(this.rbtnNrDislikesDesc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnNrDislikesAsc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnNrLikesDesc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnNrLikesAsc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnMangaCharacterDesc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnMangaCharacterAsc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnAnimeCharacterDesc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnAnimeCharacterAsc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnCharacterNameDesc);
            this.groupBoxSortCharacters.Controls.Add(this.rbtnCharacterNameAsc);
            this.groupBoxSortCharacters.Controls.Add(this.btnDisplayAllCharacters);
            this.groupBoxSortCharacters.Location = new System.Drawing.Point(16, 389);
            this.groupBoxSortCharacters.Name = "groupBoxSortCharacters";
            this.groupBoxSortCharacters.Size = new System.Drawing.Size(515, 316);
            this.groupBoxSortCharacters.TabIndex = 46;
            this.groupBoxSortCharacters.TabStop = false;
            this.groupBoxSortCharacters.Text = "Sort characters by:";
            // 
            // rbtnNrDislikesDesc
            // 
            this.rbtnNrDislikesDesc.AutoSize = true;
            this.rbtnNrDislikesDesc.Location = new System.Drawing.Point(268, 188);
            this.rbtnNrDislikesDesc.Name = "rbtnNrDislikesDesc";
            this.rbtnNrDislikesDesc.Size = new System.Drawing.Size(148, 30);
            this.rbtnNrDislikesDesc.TabIndex = 47;
            this.rbtnNrDislikesDesc.TabStop = true;
            this.rbtnNrDislikesDesc.Text = "Nr dislikes ↓";
            this.rbtnNrDislikesDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnNrDislikesAsc
            // 
            this.rbtnNrDislikesAsc.AutoSize = true;
            this.rbtnNrDislikesAsc.Location = new System.Drawing.Point(33, 188);
            this.rbtnNrDislikesAsc.Name = "rbtnNrDislikesAsc";
            this.rbtnNrDislikesAsc.Size = new System.Drawing.Size(148, 30);
            this.rbtnNrDislikesAsc.TabIndex = 46;
            this.rbtnNrDislikesAsc.TabStop = true;
            this.rbtnNrDislikesAsc.Text = "Nr dislikes ↑";
            this.rbtnNrDislikesAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnNrLikesDesc
            // 
            this.rbtnNrLikesDesc.AutoSize = true;
            this.rbtnNrLikesDesc.Location = new System.Drawing.Point(268, 152);
            this.rbtnNrLikesDesc.Name = "rbtnNrLikesDesc";
            this.rbtnNrLikesDesc.Size = new System.Drawing.Size(120, 30);
            this.rbtnNrLikesDesc.TabIndex = 45;
            this.rbtnNrLikesDesc.TabStop = true;
            this.rbtnNrLikesDesc.Text = "Nr likes ↓";
            this.rbtnNrLikesDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnNrLikesAsc
            // 
            this.rbtnNrLikesAsc.AutoSize = true;
            this.rbtnNrLikesAsc.Location = new System.Drawing.Point(33, 152);
            this.rbtnNrLikesAsc.Name = "rbtnNrLikesAsc";
            this.rbtnNrLikesAsc.Size = new System.Drawing.Size(120, 30);
            this.rbtnNrLikesAsc.TabIndex = 44;
            this.rbtnNrLikesAsc.TabStop = true;
            this.rbtnNrLikesAsc.Text = "Nr likes ↑";
            this.rbtnNrLikesAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaCharacterDesc
            // 
            this.rbtnMangaCharacterDesc.AutoSize = true;
            this.rbtnMangaCharacterDesc.Location = new System.Drawing.Point(268, 116);
            this.rbtnMangaCharacterDesc.Name = "rbtnMangaCharacterDesc";
            this.rbtnMangaCharacterDesc.Size = new System.Drawing.Size(113, 30);
            this.rbtnMangaCharacterDesc.TabIndex = 43;
            this.rbtnMangaCharacterDesc.TabStop = true;
            this.rbtnMangaCharacterDesc.Text = "Manga ↓";
            this.rbtnMangaCharacterDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnMangaCharacterAsc
            // 
            this.rbtnMangaCharacterAsc.AutoSize = true;
            this.rbtnMangaCharacterAsc.Location = new System.Drawing.Point(33, 116);
            this.rbtnMangaCharacterAsc.Name = "rbtnMangaCharacterAsc";
            this.rbtnMangaCharacterAsc.Size = new System.Drawing.Size(113, 30);
            this.rbtnMangaCharacterAsc.TabIndex = 42;
            this.rbtnMangaCharacterAsc.TabStop = true;
            this.rbtnMangaCharacterAsc.Text = "Manga ↑";
            this.rbtnMangaCharacterAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeCharacterDesc
            // 
            this.rbtnAnimeCharacterDesc.AutoSize = true;
            this.rbtnAnimeCharacterDesc.Location = new System.Drawing.Point(268, 80);
            this.rbtnAnimeCharacterDesc.Name = "rbtnAnimeCharacterDesc";
            this.rbtnAnimeCharacterDesc.Size = new System.Drawing.Size(110, 30);
            this.rbtnAnimeCharacterDesc.TabIndex = 41;
            this.rbtnAnimeCharacterDesc.TabStop = true;
            this.rbtnAnimeCharacterDesc.Text = "Anime ↓";
            this.rbtnAnimeCharacterDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnAnimeCharacterAsc
            // 
            this.rbtnAnimeCharacterAsc.AutoSize = true;
            this.rbtnAnimeCharacterAsc.Location = new System.Drawing.Point(33, 80);
            this.rbtnAnimeCharacterAsc.Name = "rbtnAnimeCharacterAsc";
            this.rbtnAnimeCharacterAsc.Size = new System.Drawing.Size(110, 30);
            this.rbtnAnimeCharacterAsc.TabIndex = 40;
            this.rbtnAnimeCharacterAsc.TabStop = true;
            this.rbtnAnimeCharacterAsc.Text = "Anime ↑";
            this.rbtnAnimeCharacterAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnCharacterNameDesc
            // 
            this.rbtnCharacterNameDesc.AutoSize = true;
            this.rbtnCharacterNameDesc.Location = new System.Drawing.Point(268, 44);
            this.rbtnCharacterNameDesc.Name = "rbtnCharacterNameDesc";
            this.rbtnCharacterNameDesc.Size = new System.Drawing.Size(106, 30);
            this.rbtnCharacterNameDesc.TabIndex = 39;
            this.rbtnCharacterNameDesc.TabStop = true;
            this.rbtnCharacterNameDesc.Text = "Name ↓";
            this.rbtnCharacterNameDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnCharacterNameAsc
            // 
            this.rbtnCharacterNameAsc.AutoSize = true;
            this.rbtnCharacterNameAsc.Location = new System.Drawing.Point(33, 44);
            this.rbtnCharacterNameAsc.Name = "rbtnCharacterNameAsc";
            this.rbtnCharacterNameAsc.Size = new System.Drawing.Size(106, 30);
            this.rbtnCharacterNameAsc.TabIndex = 38;
            this.rbtnCharacterNameAsc.TabStop = true;
            this.rbtnCharacterNameAsc.Text = "Name ↑";
            this.rbtnCharacterNameAsc.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllCharacters
            // 
            this.btnDisplayAllCharacters.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDisplayAllCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAllCharacters.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAllCharacters.Location = new System.Drawing.Point(21, 245);
            this.btnDisplayAllCharacters.Name = "btnDisplayAllCharacters";
            this.btnDisplayAllCharacters.Size = new System.Drawing.Size(472, 54);
            this.btnDisplayAllCharacters.TabIndex = 37;
            this.btnDisplayAllCharacters.Text = "Display all";
            this.btnDisplayAllCharacters.UseVisualStyleBackColor = false;
            this.btnDisplayAllCharacters.Click += new System.EventHandler(this.btnDisplayAllCharacters_Click);
            // 
            // lvwCharacters
            // 
            this.lvwCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameCharacter,
            this.columnGenderCharacter,
            this.columnAnimeCharacter,
            this.columnMangaCharacter,
            this.columnNrLikes,
            this.columnNrDislikes});
            this.lvwCharacters.FullRowSelect = true;
            this.lvwCharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwCharacters.Location = new System.Drawing.Point(582, 30);
            this.lvwCharacters.MultiSelect = false;
            this.lvwCharacters.Name = "lvwCharacters";
            this.lvwCharacters.Size = new System.Drawing.Size(1178, 696);
            this.lvwCharacters.TabIndex = 45;
            this.lvwCharacters.UseCompatibleStateImageBehavior = false;
            this.lvwCharacters.View = System.Windows.Forms.View.Details;
            // 
            // columnNameCharacter
            // 
            this.columnNameCharacter.Text = "Name";
            this.columnNameCharacter.Width = 270;
            // 
            // columnGenderCharacter
            // 
            this.columnGenderCharacter.Text = "Gender";
            this.columnGenderCharacter.Width = 180;
            // 
            // columnAnimeCharacter
            // 
            this.columnAnimeCharacter.Text = "Anime title";
            this.columnAnimeCharacter.Width = 240;
            // 
            // columnMangaCharacter
            // 
            this.columnMangaCharacter.Text = "MangaTitle";
            this.columnMangaCharacter.Width = 240;
            // 
            // columnNrLikes
            // 
            this.columnNrLikes.Text = "Nr likes";
            this.columnNrLikes.Width = 120;
            // 
            // columnNrDislikes
            // 
            this.columnNrDislikes.Text = "Nr dislikes";
            this.columnNrDislikes.Width = 120;
            // 
            // groupBoxSearchCharacters
            // 
            this.groupBoxSearchCharacters.Controls.Add(this.labelFromContentCharacter);
            this.groupBoxSearchCharacters.Controls.Add(this.tbxMangaCharacterSearch);
            this.groupBoxSearchCharacters.Controls.Add(this.labelMangaCharacter);
            this.groupBoxSearchCharacters.Controls.Add(this.rbtnUnknown);
            this.groupBoxSearchCharacters.Controls.Add(this.rbtnFemale);
            this.groupBoxSearchCharacters.Controls.Add(this.rbtnMale);
            this.groupBoxSearchCharacters.Controls.Add(this.labelCharacterGender);
            this.groupBoxSearchCharacters.Controls.Add(this.btnClearFieldsCharacter);
            this.groupBoxSearchCharacters.Controls.Add(this.tbxAnimeCharacterSearch);
            this.groupBoxSearchCharacters.Controls.Add(this.btnSearchCharacter);
            this.groupBoxSearchCharacters.Controls.Add(this.labelAnimeCharacter);
            this.groupBoxSearchCharacters.Controls.Add(this.tbxCharacterName);
            this.groupBoxSearchCharacters.Controls.Add(this.labelCharacterName);
            this.groupBoxSearchCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchCharacters.Location = new System.Drawing.Point(16, 18);
            this.groupBoxSearchCharacters.Name = "groupBoxSearchCharacters";
            this.groupBoxSearchCharacters.Size = new System.Drawing.Size(515, 352);
            this.groupBoxSearchCharacters.TabIndex = 44;
            this.groupBoxSearchCharacters.TabStop = false;
            this.groupBoxSearchCharacters.Text = "Character search:";
            // 
            // labelFromContentCharacter
            // 
            this.labelFromContentCharacter.AutoSize = true;
            this.labelFromContentCharacter.Location = new System.Drawing.Point(21, 139);
            this.labelFromContentCharacter.Name = "labelFromContentCharacter";
            this.labelFromContentCharacter.Size = new System.Drawing.Size(69, 26);
            this.labelFromContentCharacter.TabIndex = 57;
            this.labelFromContentCharacter.Text = "From:";
            // 
            // tbxMangaCharacterSearch
            // 
            this.tbxMangaCharacterSearch.Location = new System.Drawing.Point(121, 221);
            this.tbxMangaCharacterSearch.Name = "tbxMangaCharacterSearch";
            this.tbxMangaCharacterSearch.Size = new System.Drawing.Size(372, 32);
            this.tbxMangaCharacterSearch.TabIndex = 56;
            // 
            // labelMangaCharacter
            // 
            this.labelMangaCharacter.AutoSize = true;
            this.labelMangaCharacter.Location = new System.Drawing.Point(21, 224);
            this.labelMangaCharacter.Name = "labelMangaCharacter";
            this.labelMangaCharacter.Size = new System.Drawing.Size(84, 26);
            this.labelMangaCharacter.TabIndex = 55;
            this.labelMangaCharacter.Text = "Manga:";
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(313, 82);
            this.rbtnUnknown.Name = "rbtnUnknown";
            this.rbtnUnknown.Size = new System.Drawing.Size(121, 30);
            this.rbtnUnknown.TabIndex = 54;
            this.rbtnUnknown.TabStop = true;
            this.rbtnUnknown.Text = "Unknown";
            this.rbtnUnknown.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(204, 82);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(103, 30);
            this.rbtnFemale.TabIndex = 53;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(121, 82);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 30);
            this.rbtnMale.TabIndex = 52;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // labelCharacterGender
            // 
            this.labelCharacterGender.AutoSize = true;
            this.labelCharacterGender.Location = new System.Drawing.Point(21, 85);
            this.labelCharacterGender.Name = "labelCharacterGender";
            this.labelCharacterGender.Size = new System.Drawing.Size(90, 26);
            this.labelCharacterGender.TabIndex = 51;
            this.labelCharacterGender.Text = "Gender:";
            // 
            // btnClearFieldsCharacter
            // 
            this.btnClearFieldsCharacter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearFieldsCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFieldsCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnClearFieldsCharacter.Location = new System.Drawing.Point(268, 276);
            this.btnClearFieldsCharacter.Name = "btnClearFieldsCharacter";
            this.btnClearFieldsCharacter.Size = new System.Drawing.Size(225, 54);
            this.btnClearFieldsCharacter.TabIndex = 44;
            this.btnClearFieldsCharacter.Text = "Clear fields";
            this.btnClearFieldsCharacter.UseVisualStyleBackColor = false;
            this.btnClearFieldsCharacter.Click += new System.EventHandler(this.btnClearFieldsCharacter_Click);
            // 
            // tbxAnimeCharacterSearch
            // 
            this.tbxAnimeCharacterSearch.Location = new System.Drawing.Point(121, 177);
            this.tbxAnimeCharacterSearch.Name = "tbxAnimeCharacterSearch";
            this.tbxAnimeCharacterSearch.Size = new System.Drawing.Size(372, 32);
            this.tbxAnimeCharacterSearch.TabIndex = 43;
            // 
            // btnSearchCharacter
            // 
            this.btnSearchCharacter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCharacter.Location = new System.Drawing.Point(21, 276);
            this.btnSearchCharacter.Name = "btnSearchCharacter";
            this.btnSearchCharacter.Size = new System.Drawing.Size(225, 54);
            this.btnSearchCharacter.TabIndex = 38;
            this.btnSearchCharacter.Text = "Search";
            this.btnSearchCharacter.UseVisualStyleBackColor = false;
            this.btnSearchCharacter.Click += new System.EventHandler(this.btnSearchCharacter_Click);
            // 
            // labelAnimeCharacter
            // 
            this.labelAnimeCharacter.AutoSize = true;
            this.labelAnimeCharacter.Location = new System.Drawing.Point(21, 180);
            this.labelAnimeCharacter.Name = "labelAnimeCharacter";
            this.labelAnimeCharacter.Size = new System.Drawing.Size(81, 26);
            this.labelAnimeCharacter.TabIndex = 13;
            this.labelAnimeCharacter.Text = "Anime:";
            // 
            // tbxCharacterName
            // 
            this.tbxCharacterName.Location = new System.Drawing.Point(121, 39);
            this.tbxCharacterName.Name = "tbxCharacterName";
            this.tbxCharacterName.Size = new System.Drawing.Size(313, 32);
            this.tbxCharacterName.TabIndex = 4;
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Location = new System.Drawing.Point(21, 42);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(77, 26);
            this.labelCharacterName.TabIndex = 1;
            this.labelCharacterName.Text = "Name:";
            // 
            // tabCreateAccount
            // 
            this.tabCreateAccount.BackColor = System.Drawing.Color.Thistle;
            this.tabCreateAccount.Controls.Add(this.btnRemoveAccount);
            this.tabCreateAccount.Controls.Add(this.btnCreateMaintainer);
            this.tabCreateAccount.Controls.Add(this.lvwAccounts);
            this.tabCreateAccount.Controls.Add(this.groupBoxSearchAccount);
            this.tabCreateAccount.Location = new System.Drawing.Point(4, 46);
            this.tabCreateAccount.Name = "tabCreateAccount";
            this.tabCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateAccount.Size = new System.Drawing.Size(1797, 852);
            this.tabCreateAccount.TabIndex = 3;
            this.tabCreateAccount.Text = "Accounts";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAccount.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAccount.Location = new System.Drawing.Point(1273, 744);
            this.btnRemoveAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(406, 72);
            this.btnRemoveAccount.TabIndex = 49;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.UseVisualStyleBackColor = false;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnCreateMaintainer
            // 
            this.btnCreateMaintainer.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCreateMaintainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateMaintainer.ForeColor = System.Drawing.Color.Black;
            this.btnCreateMaintainer.Location = new System.Drawing.Point(642, 744);
            this.btnCreateMaintainer.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateMaintainer.Name = "btnCreateMaintainer";
            this.btnCreateMaintainer.Size = new System.Drawing.Size(406, 72);
            this.btnCreateMaintainer.TabIndex = 49;
            this.btnCreateMaintainer.Text = "Create Account";
            this.btnCreateMaintainer.UseVisualStyleBackColor = false;
            this.btnCreateMaintainer.Click += new System.EventHandler(this.btnCreateMaintainer_Click);
            // 
            // lvwAccounts
            // 
            this.lvwAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1Name,
            this.columnHeader2Username,
            this.columnHeader3JoinDate,
            this.columnHeader4Role});
            this.lvwAccounts.FullRowSelect = true;
            this.lvwAccounts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwAccounts.Location = new System.Drawing.Point(642, 18);
            this.lvwAccounts.MultiSelect = false;
            this.lvwAccounts.Name = "lvwAccounts";
            this.lvwAccounts.Size = new System.Drawing.Size(1037, 696);
            this.lvwAccounts.TabIndex = 46;
            this.lvwAccounts.UseCompatibleStateImageBehavior = false;
            this.lvwAccounts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1Name
            // 
            this.columnHeader1Name.Text = "Name";
            this.columnHeader1Name.Width = 270;
            // 
            // columnHeader2Username
            // 
            this.columnHeader2Username.Text = "Username";
            this.columnHeader2Username.Width = 270;
            // 
            // columnHeader3JoinDate
            // 
            this.columnHeader3JoinDate.Text = "Join Date";
            this.columnHeader3JoinDate.Width = 240;
            // 
            // columnHeader4Role
            // 
            this.columnHeader4Role.Text = "Role";
            this.columnHeader4Role.Width = 240;
            // 
            // groupBoxSearchAccount
            // 
            this.groupBoxSearchAccount.Controls.Add(this.labelUsername);
            this.groupBoxSearchAccount.Controls.Add(this.tbxUsername);
            this.groupBoxSearchAccount.Controls.Add(this.labelYears);
            this.groupBoxSearchAccount.Controls.Add(this.tbxYears);
            this.groupBoxSearchAccount.Controls.Add(this.btnClearFieldsAccount);
            this.groupBoxSearchAccount.Controls.Add(this.labelExperience);
            this.groupBoxSearchAccount.Controls.Add(this.btnSearchAccount);
            this.groupBoxSearchAccount.Controls.Add(this.cbxRoles);
            this.groupBoxSearchAccount.Controls.Add(this.labelRoles);
            this.groupBoxSearchAccount.Controls.Add(this.tbxNameAccount);
            this.groupBoxSearchAccount.Controls.Add(this.labelName);
            this.groupBoxSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAccount.Location = new System.Drawing.Point(16, 18);
            this.groupBoxSearchAccount.Name = "groupBoxSearchAccount";
            this.groupBoxSearchAccount.Size = new System.Drawing.Size(535, 319);
            this.groupBoxSearchAccount.TabIndex = 3;
            this.groupBoxSearchAccount.TabStop = false;
            this.groupBoxSearchAccount.Text = "Account search:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(21, 89);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(119, 26);
            this.labelUsername.TabIndex = 48;
            this.labelUsername.Text = "Username:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(146, 86);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(277, 32);
            this.tbxUsername.TabIndex = 47;
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(429, 184);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(79, 26);
            this.labelYears.TabIndex = 46;
            this.labelYears.Text = "(years)";
            // 
            // tbxYears
            // 
            this.tbxYears.Location = new System.Drawing.Point(188, 181);
            this.tbxYears.Name = "tbxYears";
            this.tbxYears.Size = new System.Drawing.Size(235, 32);
            this.tbxYears.TabIndex = 45;
            // 
            // btnClearFieldsAccount
            // 
            this.btnClearFieldsAccount.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearFieldsAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFieldsAccount.ForeColor = System.Drawing.Color.Black;
            this.btnClearFieldsAccount.Location = new System.Drawing.Point(283, 242);
            this.btnClearFieldsAccount.Name = "btnClearFieldsAccount";
            this.btnClearFieldsAccount.Size = new System.Drawing.Size(225, 54);
            this.btnClearFieldsAccount.TabIndex = 44;
            this.btnClearFieldsAccount.Text = "Clear fields";
            this.btnClearFieldsAccount.UseVisualStyleBackColor = false;
            this.btnClearFieldsAccount.Click += new System.EventHandler(this.btnClearFieldsAccount_Click);
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(21, 184);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(127, 26);
            this.labelExperience.TabIndex = 41;
            this.labelExperience.Text = "Experience:";
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAccount.ForeColor = System.Drawing.Color.Black;
            this.btnSearchAccount.Location = new System.Drawing.Point(21, 242);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(225, 54);
            this.btnSearchAccount.TabIndex = 38;
            this.btnSearchAccount.Text = "Search";
            this.btnSearchAccount.UseVisualStyleBackColor = false;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // cbxRoles
            // 
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.ItemHeight = 25;
            this.cbxRoles.Location = new System.Drawing.Point(146, 134);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(277, 33);
            this.cbxRoles.TabIndex = 20;
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(21, 134);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(74, 26);
            this.labelRoles.TabIndex = 19;
            this.labelRoles.Text = "Roles:";
            // 
            // tbxNameAccount
            // 
            this.tbxNameAccount.Location = new System.Drawing.Point(146, 39);
            this.tbxNameAccount.Name = "tbxNameAccount";
            this.tbxNameAccount.Size = new System.Drawing.Size(277, 32);
            this.tbxNameAccount.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 26);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WinFormsGraphic.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(1793, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabReviews
            // 
            this.tabReviews.BackColor = System.Drawing.Color.Thistle;
            this.tabReviews.Controls.Add(this.btnRemoveReview);
            this.tabReviews.Controls.Add(this.groupBoxSortReviews);
            this.tabReviews.Controls.Add(this.lvwReviews);
            this.tabReviews.Controls.Add(this.groupBoxSearchReview);
            this.tabReviews.Location = new System.Drawing.Point(4, 46);
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabReviews.Size = new System.Drawing.Size(1797, 852);
            this.tabReviews.TabIndex = 4;
            this.tabReviews.Text = "Reviews";
            // 
            // lvwReviews
            // 
            this.lvwReviews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsernameReview,
            this.columnHeaderRatingReview,
            this.columnHeaderDescriptionReview,
            this.columnHeaderPostDate});
            this.lvwReviews.FullRowSelect = true;
            this.lvwReviews.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwReviews.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvwReviews.Location = new System.Drawing.Point(458, 30);
            this.lvwReviews.MultiSelect = false;
            this.lvwReviews.Name = "lvwReviews";
            this.lvwReviews.Size = new System.Drawing.Size(1311, 696);
            this.lvwReviews.TabIndex = 48;
            this.lvwReviews.UseCompatibleStateImageBehavior = false;
            this.lvwReviews.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUsernameReview
            // 
            this.columnHeaderUsernameReview.Text = "Username";
            this.columnHeaderUsernameReview.Width = 270;
            // 
            // columnHeaderRatingReview
            // 
            this.columnHeaderRatingReview.Text = "Rating";
            this.columnHeaderRatingReview.Width = 140;
            // 
            // columnHeaderDescriptionReview
            // 
            this.columnHeaderDescriptionReview.Text = "Description";
            this.columnHeaderDescriptionReview.Width = 700;
            // 
            // columnHeaderPostDate
            // 
            this.columnHeaderPostDate.Text = "Post date";
            this.columnHeaderPostDate.Width = 195;
            // 
            // groupBoxSearchReview
            // 
            this.groupBoxSearchReview.Controls.Add(this.numRatingReview);
            this.groupBoxSearchReview.Controls.Add(this.cbxManga);
            this.groupBoxSearchReview.Controls.Add(this.cbxAnime);
            this.groupBoxSearchReview.Controls.Add(this.labelContent);
            this.groupBoxSearchReview.Controls.Add(this.btnClearFieldsReview);
            this.groupBoxSearchReview.Controls.Add(this.btnSearchReview);
            this.groupBoxSearchReview.Controls.Add(this.labelRating);
            this.groupBoxSearchReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchReview.Location = new System.Drawing.Point(18, 19);
            this.groupBoxSearchReview.Name = "groupBoxSearchReview";
            this.groupBoxSearchReview.Size = new System.Drawing.Size(414, 220);
            this.groupBoxSearchReview.TabIndex = 47;
            this.groupBoxSearchReview.TabStop = false;
            this.groupBoxSearchReview.Text = "Review search:";
            // 
            // btnClearFieldsReview
            // 
            this.btnClearFieldsReview.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClearFieldsReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFieldsReview.ForeColor = System.Drawing.Color.Black;
            this.btnClearFieldsReview.Location = new System.Drawing.Point(220, 147);
            this.btnClearFieldsReview.Name = "btnClearFieldsReview";
            this.btnClearFieldsReview.Size = new System.Drawing.Size(175, 54);
            this.btnClearFieldsReview.TabIndex = 44;
            this.btnClearFieldsReview.Text = "Clear fields";
            this.btnClearFieldsReview.UseVisualStyleBackColor = false;
            // 
            // btnSearchReview
            // 
            this.btnSearchReview.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearchReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchReview.ForeColor = System.Drawing.Color.Black;
            this.btnSearchReview.Location = new System.Drawing.Point(21, 147);
            this.btnSearchReview.Name = "btnSearchReview";
            this.btnSearchReview.Size = new System.Drawing.Size(175, 54);
            this.btnSearchReview.TabIndex = 38;
            this.btnSearchReview.Text = "Search";
            this.btnSearchReview.UseVisualStyleBackColor = false;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(21, 42);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(81, 26);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating:";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(21, 89);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(94, 26);
            this.labelContent.TabIndex = 48;
            this.labelContent.Text = "Content:";
            // 
            // cbxAnime
            // 
            this.cbxAnime.AutoSize = true;
            this.cbxAnime.Location = new System.Drawing.Point(146, 87);
            this.cbxAnime.Name = "cbxAnime";
            this.cbxAnime.Size = new System.Drawing.Size(94, 30);
            this.cbxAnime.TabIndex = 49;
            this.cbxAnime.Text = "Anime";
            this.cbxAnime.UseVisualStyleBackColor = true;
            // 
            // cbxManga
            // 
            this.cbxManga.AutoSize = true;
            this.cbxManga.Location = new System.Drawing.Point(246, 87);
            this.cbxManga.Name = "cbxManga";
            this.cbxManga.Size = new System.Drawing.Size(97, 30);
            this.cbxManga.TabIndex = 50;
            this.cbxManga.Text = "Manga";
            this.cbxManga.UseVisualStyleBackColor = true;
            // 
            // numRatingReview
            // 
            this.numRatingReview.Location = new System.Drawing.Point(146, 40);
            this.numRatingReview.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingReview.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatingReview.Name = "numRatingReview";
            this.numRatingReview.Size = new System.Drawing.Size(120, 32);
            this.numRatingReview.TabIndex = 51;
            this.numRatingReview.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxSortReviews
            // 
            this.groupBoxSortReviews.Controls.Add(this.rbtnUser);
            this.groupBoxSortReviews.Controls.Add(this.rbtnPostDateDesc);
            this.groupBoxSortReviews.Controls.Add(this.rbtnPostDateAsc);
            this.groupBoxSortReviews.Controls.Add(this.rbtnRatingDesc);
            this.groupBoxSortReviews.Controls.Add(this.rbtnRatingAsc);
            this.groupBoxSortReviews.Controls.Add(this.btnDisplayAllReviews);
            this.groupBoxSortReviews.Location = new System.Drawing.Point(18, 267);
            this.groupBoxSortReviews.Name = "groupBoxSortReviews";
            this.groupBoxSortReviews.Size = new System.Drawing.Size(414, 244);
            this.groupBoxSortReviews.TabIndex = 49;
            this.groupBoxSortReviews.TabStop = false;
            this.groupBoxSortReviews.Text = "Sort reviews by:";
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.Location = new System.Drawing.Point(33, 116);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(76, 30);
            this.rbtnUser.TabIndex = 42;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "User";
            this.rbtnUser.UseVisualStyleBackColor = true;
            // 
            // rbtnPostDateDesc
            // 
            this.rbtnPostDateDesc.AutoSize = true;
            this.rbtnPostDateDesc.Location = new System.Drawing.Point(232, 80);
            this.rbtnPostDateDesc.Name = "rbtnPostDateDesc";
            this.rbtnPostDateDesc.Size = new System.Drawing.Size(139, 30);
            this.rbtnPostDateDesc.TabIndex = 41;
            this.rbtnPostDateDesc.TabStop = true;
            this.rbtnPostDateDesc.Text = "Post date ↓";
            this.rbtnPostDateDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnPostDateAsc
            // 
            this.rbtnPostDateAsc.AutoSize = true;
            this.rbtnPostDateAsc.Location = new System.Drawing.Point(33, 80);
            this.rbtnPostDateAsc.Name = "rbtnPostDateAsc";
            this.rbtnPostDateAsc.Size = new System.Drawing.Size(139, 30);
            this.rbtnPostDateAsc.TabIndex = 40;
            this.rbtnPostDateAsc.TabStop = true;
            this.rbtnPostDateAsc.Text = "Post date ↑";
            this.rbtnPostDateAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnRatingDesc
            // 
            this.rbtnRatingDesc.AutoSize = true;
            this.rbtnRatingDesc.Location = new System.Drawing.Point(232, 44);
            this.rbtnRatingDesc.Name = "rbtnRatingDesc";
            this.rbtnRatingDesc.Size = new System.Drawing.Size(110, 30);
            this.rbtnRatingDesc.TabIndex = 39;
            this.rbtnRatingDesc.TabStop = true;
            this.rbtnRatingDesc.Text = "Rating ↓";
            this.rbtnRatingDesc.UseVisualStyleBackColor = true;
            // 
            // rbtnRatingAsc
            // 
            this.rbtnRatingAsc.AutoSize = true;
            this.rbtnRatingAsc.Location = new System.Drawing.Point(33, 44);
            this.rbtnRatingAsc.Name = "rbtnRatingAsc";
            this.rbtnRatingAsc.Size = new System.Drawing.Size(110, 30);
            this.rbtnRatingAsc.TabIndex = 38;
            this.rbtnRatingAsc.TabStop = true;
            this.rbtnRatingAsc.Text = "Rating ↑";
            this.rbtnRatingAsc.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllReviews
            // 
            this.btnDisplayAllReviews.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDisplayAllReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAllReviews.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayAllReviews.Location = new System.Drawing.Point(21, 171);
            this.btnDisplayAllReviews.Name = "btnDisplayAllReviews";
            this.btnDisplayAllReviews.Size = new System.Drawing.Size(374, 54);
            this.btnDisplayAllReviews.TabIndex = 37;
            this.btnDisplayAllReviews.Text = "Display all";
            this.btnDisplayAllReviews.UseVisualStyleBackColor = false;
            // 
            // btnRemoveReview
            // 
            this.btnRemoveReview.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRemoveReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveReview.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveReview.Location = new System.Drawing.Point(921, 744);
            this.btnRemoveReview.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveReview.Name = "btnRemoveReview";
            this.btnRemoveReview.Size = new System.Drawing.Size(406, 72);
            this.btnRemoveReview.TabIndex = 50;
            this.btnRemoveReview.Text = "Remove Review";
            this.btnRemoveReview.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Violet;
            this.BackgroundImage = global::WinFormsGraphic.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelTitleWorldOfAnime);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.tabAnime.ResumeLayout(false);
            this.BroupBoxSortAnime.ResumeLayout(false);
            this.BroupBoxSortAnime.PerformLayout();
            this.groupBoxSearchAnime.ResumeLayout(false);
            this.groupBoxSearchAnime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingUpperAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingLowerAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesToSearchAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesFromSearchAnime)).EndInit();
            this.tabManga.ResumeLayout(false);
            this.groupBoxSortManga.ResumeLayout(false);
            this.groupBoxSortManga.PerformLayout();
            this.groupBoxSearchManga.ResumeLayout(false);
            this.groupBoxSearchManga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingUpperManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingLowerManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersToManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersFromManga)).EndInit();
            this.tabCharacters.ResumeLayout(false);
            this.groupBoxSortCharacters.ResumeLayout(false);
            this.groupBoxSortCharacters.PerformLayout();
            this.groupBoxSearchCharacters.ResumeLayout(false);
            this.groupBoxSearchCharacters.PerformLayout();
            this.tabCreateAccount.ResumeLayout(false);
            this.groupBoxSearchAccount.ResumeLayout(false);
            this.groupBoxSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabReviews.ResumeLayout(false);
            this.groupBoxSearchReview.ResumeLayout(false);
            this.groupBoxSearchReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingReview)).EndInit();
            this.groupBoxSortReviews.ResumeLayout(false);
            this.groupBoxSortReviews.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTitleWorldOfAnime;
        private TabControl tabControl;
        private TabPage tabAnime;
        private Button btnAddAnime;
        private ListView lvwAnime;
        private ColumnHeader colAnimeName;
        private ColumnHeader colAnimeStudio;
        private ColumnHeader colAnimeRating;
        private ColumnHeader colAnimeReleaseYear;
        private ColumnHeader colAnimeReleaseSeason;
        private ColumnHeader colAnimeNrEpisodes;
        private Button btnEditAnime;
        private GroupBox groupBoxSearchAnime;
        private Button btnClearSearch;
        private TextBox tbxReleaseYearSearchAnime;
        private NumericUpDown numRatingLowerAnime;
        private Label labelRatingSearchAnime;
        private ComboBox cbxSeasonSearchAnime;
        private Label labelReleaseSeasonSearchAnime;
        private Button btnSearchAnime;
        private Button btnDisplayAllAnime;
        private ComboBox cbxGenreSearchAnime;
        private Label labelGenreSearchAnime;
        private Label labelYearSearchAnime;
        private NumericUpDown numNrEpisodesToSearchAnime;
        private Label labelNrEpisodesToSearchAnime;
        private NumericUpDown numNrEpisodesFromSearchAnime;
        private Label labelNrEpisodesFromSearchAnime;
        private TextBox tbxStudioSearchAnime;
        private Label labelStudioSearchAnime;
        private TextBox tbxNameSearchAnime;
        private Label labelNameSearchAnime;
        private TabPage tabManga;
        private TabPage tabCharacters;
        private TabPage tabCreateAccount;
        private Button btnRemoveAnime;
        private GroupBox BroupBoxSortAnime;
        private RadioButton rbtnAnimeNameAsc;
        private RadioButton rbtnAnimeRatingDesc;
        private RadioButton rbtnAnimeRatingAsc;
        private RadioButton rbtnAnimeReleaseYearDesc;
        private RadioButton rbtnAnimeReleaseYearAsc;
        private RadioButton rbtnAnimeStudioDesc;
        private RadioButton rbtnAnimeStudioAsc;
        private RadioButton rbtnAnimeNameDesc;
        private GroupBox groupBoxSearchManga;
        private Button btnClearSearchManga;
        private TextBox tbxReleaseYearManga;
        private ComboBox cbxMangaStatus;
        private Label labelMangaStatus;
        private Button btnSearchManga;
        private ComboBox cbxGenreManga;
        private Label labelGenreManga;
        private Label labelReleaseYearManga;
        private NumericUpDown numChaptersToManga;
        private Label labelChaptersToManga;
        private NumericUpDown numChaptersFromManga;
        private Label labelNrChaptersFromManga;
        private TextBox tbxCreatorManga;
        private Label labelCreatorManga;
        private TextBox tbxNameManga;
        private Label labeNameManga;
        private Button btnRemoveManga;
        private Button btnAddManga;
        private Button btnEditManga;
        private GroupBox groupBoxSortManga;
        private RadioButton rbtnMangaRatingDesc;
        private RadioButton rbtnMangaRatingAsc;
        private RadioButton rbtnMangaReleaseYearDesc;
        private RadioButton rbtnMangaReleaseYearAsc;
        private RadioButton rbtnMangaCreatorDesc;
        private RadioButton rbtnMangaCreatorAsc;
        private RadioButton rbtnMangaNameDesc;
        private RadioButton rbtnMangaNameAsc;
        private Button btnDisplayAllManga;
        private ListView lvwManga;
        private ColumnHeader columnNameManga;
        private ColumnHeader columnCreator;
        private ColumnHeader columnRatingManga;
        private ColumnHeader columnReleaseYearManga;
        private ColumnHeader columnStatus;
        private ColumnHeader columnNrChapters;
        private NumericUpDown numRatingUpperAnime;
        private Label labelRatingToAnime;
        private NumericUpDown numRatingUpperManga;
        private Label labelRatingToManga;
        private NumericUpDown numRatingLowerManga;
        private Label labelRatingFromManga;
        private GroupBox groupBoxSortCharacters;
        private RadioButton rbtnMangaCharacterDesc;
        private RadioButton rbtnMangaCharacterAsc;
        private RadioButton rbtnAnimeCharacterDesc;
        private RadioButton rbtnAnimeCharacterAsc;
        private RadioButton rbtnCharacterNameDesc;
        private RadioButton rbtnCharacterNameAsc;
        private Button btnDisplayAllCharacters;
        private ListView lvwCharacters;
        private ColumnHeader columnNameCharacter;
        private ColumnHeader columnGenderCharacter;
        private ColumnHeader columnAnimeCharacter;
        private ColumnHeader columnMangaCharacter;
        private ColumnHeader columnNrLikes;
        private ColumnHeader columnNrDislikes;
        private GroupBox groupBoxSearchCharacters;
        private RadioButton rbtnUnknown;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label labelCharacterGender;
        private Button btnClearFieldsCharacter;
        private TextBox tbxAnimeCharacterSearch;
        private Button btnSearchCharacter;
        private Label labelAnimeCharacter;
        private TextBox tbxCharacterName;
        private Label labelCharacterName;
        private Button btnRemoveCharacter;
        private Button btnAddCharacter;
        private Button btnEditCharacter;
        private Label labelFromContentCharacter;
        private TextBox tbxMangaCharacterSearch;
        private Label labelMangaCharacter;
        private RadioButton rbtnNrDislikesDesc;
        private RadioButton rbtnNrDislikesAsc;
        private RadioButton rbtnNrLikesDesc;
        private RadioButton rbtnNrLikesAsc;
        private ListView lvwAccounts;
        private ColumnHeader columnHeader1Name;
        private ColumnHeader columnHeader2Username;
        private ColumnHeader columnHeader3JoinDate;
        private ColumnHeader columnHeader4Role;
        private GroupBox groupBoxSearchAccount;
        private Label labelUsername;
        private TextBox tbxUsername;
        private Label labelYears;
        private TextBox tbxYears;
        private Button btnClearFieldsAccount;
        private Label labelExperience;
        private Button btnSearchAccount;
        private ComboBox cbxRoles;
        private Label labelRoles;
        private TextBox tbxNameAccount;
        private Label labelName;
        private Button btnRemoveAccount;
        private Button btnCreateMaintainer;
        private PictureBox pictureBox1;
        private TabPage tabReviews;
        private Button btnRemoveReview;
        private GroupBox groupBoxSortReviews;
        private RadioButton rbtnUser;
        private RadioButton rbtnPostDateDesc;
        private RadioButton rbtnPostDateAsc;
        private RadioButton rbtnRatingDesc;
        private RadioButton rbtnRatingAsc;
        private Button btnDisplayAllReviews;
        private ListView lvwReviews;
        private ColumnHeader columnHeaderUsernameReview;
        private ColumnHeader columnHeaderRatingReview;
        private ColumnHeader columnHeaderDescriptionReview;
        private ColumnHeader columnHeaderPostDate;
        private GroupBox groupBoxSearchReview;
        private NumericUpDown numRatingReview;
        private CheckBox cbxManga;
        private CheckBox cbxAnime;
        private Label labelContent;
        private Button btnClearFieldsReview;
        private Button btnSearchReview;
        private Label labelRating;
    }
}