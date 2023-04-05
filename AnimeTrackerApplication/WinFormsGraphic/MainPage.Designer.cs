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
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.tbxReleaseYearSearchAnime = new System.Windows.Forms.TextBox();
            this.numRatingSearchAnime = new System.Windows.Forms.NumericUpDown();
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
            this.btnClearSearchManga = new System.Windows.Forms.Button();
            this.tbxReleaseYearManga = new System.Windows.Forms.TextBox();
            this.numRatingManga = new System.Windows.Forms.NumericUpDown();
            this.labelRatingManga = new System.Windows.Forms.Label();
            this.cbxMangaStatus = new System.Windows.Forms.ComboBox();
            this.labelMangaStatus = new System.Windows.Forms.Label();
            this.btnSearchManga = new System.Windows.Forms.Button();
            this.cbxGenreManga = new System.Windows.Forms.ComboBox();
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
            this.tabCreateAccount = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabAnime.SuspendLayout();
            this.BroupBoxSortAnime.SuspendLayout();
            this.groupBoxSearchAnime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSearchAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesToSearchAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesFromSearchAnime)).BeginInit();
            this.tabManga.SuspendLayout();
            this.groupBoxSortManga.SuspendLayout();
            this.groupBoxSearchManga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersToManga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersFromManga)).BeginInit();
            this.tabCreateAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabAnime);
            this.tabControl.Controls.Add(this.tabManga);
            this.tabControl.Controls.Add(this.tabCharacters);
            this.tabControl.Controls.Add(this.tabCreateAccount);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(56, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(80, 9);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1805, 902);
            this.tabControl.TabIndex = 2;
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
            this.lvwAnime.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAnime.TabIndex = 39;
            this.lvwAnime.UseCompatibleStateImageBehavior = false;
            this.lvwAnime.View = System.Windows.Forms.View.Details;
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
            this.groupBoxSearchAnime.Controls.Add(this.btnClearSearch);
            this.groupBoxSearchAnime.Controls.Add(this.tbxReleaseYearSearchAnime);
            this.groupBoxSearchAnime.Controls.Add(this.numRatingSearchAnime);
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
            // numRatingSearchAnime
            // 
            this.numRatingSearchAnime.DecimalPlaces = 1;
            this.numRatingSearchAnime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingSearchAnime.Location = new System.Drawing.Point(116, 293);
            this.numRatingSearchAnime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingSearchAnime.Name = "numRatingSearchAnime";
            this.numRatingSearchAnime.Size = new System.Drawing.Size(111, 32);
            this.numRatingSearchAnime.TabIndex = 42;
            this.numRatingSearchAnime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRatingSearchAnime
            // 
            this.labelRatingSearchAnime.AutoSize = true;
            this.labelRatingSearchAnime.Location = new System.Drawing.Point(21, 295);
            this.labelRatingSearchAnime.Name = "labelRatingSearchAnime";
            this.labelRatingSearchAnime.Size = new System.Drawing.Size(81, 26);
            this.labelRatingSearchAnime.TabIndex = 41;
            this.labelRatingSearchAnime.Text = "Rating:";
            // 
            // cbxSeasonSearchAnime
            // 
            this.cbxSeasonSearchAnime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeasonSearchAnime.FormattingEnabled = true;
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
            // 
            // cbxGenreSearchAnime
            // 
            this.cbxGenreSearchAnime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenreSearchAnime.FormattingEnabled = true;
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
            this.numNrEpisodesToSearchAnime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNrEpisodesToSearchAnime.Name = "numNrEpisodesToSearchAnime";
            this.numNrEpisodesToSearchAnime.Size = new System.Drawing.Size(93, 32);
            this.numNrEpisodesToSearchAnime.TabIndex = 12;
            this.numNrEpisodesToSearchAnime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numNrEpisodesFromSearchAnime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNrEpisodesFromSearchAnime.Name = "numNrEpisodesFromSearchAnime";
            this.numNrEpisodesFromSearchAnime.Size = new System.Drawing.Size(93, 32);
            this.numNrEpisodesFromSearchAnime.TabIndex = 10;
            this.numNrEpisodesFromSearchAnime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.groupBoxSortManga.Text = "Sort anime by:";
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
            this.lvwManga.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            this.groupBoxSearchManga.Controls.Add(this.btnClearSearchManga);
            this.groupBoxSearchManga.Controls.Add(this.tbxReleaseYearManga);
            this.groupBoxSearchManga.Controls.Add(this.numRatingManga);
            this.groupBoxSearchManga.Controls.Add(this.labelRatingManga);
            this.groupBoxSearchManga.Controls.Add(this.cbxMangaStatus);
            this.groupBoxSearchManga.Controls.Add(this.labelMangaStatus);
            this.groupBoxSearchManga.Controls.Add(this.btnSearchManga);
            this.groupBoxSearchManga.Controls.Add(this.cbxGenreManga);
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
            // 
            // tbxReleaseYearManga
            // 
            this.tbxReleaseYearManga.Location = new System.Drawing.Point(173, 168);
            this.tbxReleaseYearManga.Name = "tbxReleaseYearManga";
            this.tbxReleaseYearManga.Size = new System.Drawing.Size(183, 32);
            this.tbxReleaseYearManga.TabIndex = 43;
            // 
            // numRatingManga
            // 
            this.numRatingManga.DecimalPlaces = 1;
            this.numRatingManga.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRatingManga.Location = new System.Drawing.Point(116, 293);
            this.numRatingManga.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatingManga.Name = "numRatingManga";
            this.numRatingManga.Size = new System.Drawing.Size(111, 32);
            this.numRatingManga.TabIndex = 42;
            this.numRatingManga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRatingManga
            // 
            this.labelRatingManga.AutoSize = true;
            this.labelRatingManga.Location = new System.Drawing.Point(21, 295);
            this.labelRatingManga.Name = "labelRatingManga";
            this.labelRatingManga.Size = new System.Drawing.Size(81, 26);
            this.labelRatingManga.TabIndex = 41;
            this.labelRatingManga.Text = "Rating:";
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
            this.numChaptersToManga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChaptersToManga.Name = "numChaptersToManga";
            this.numChaptersToManga.Size = new System.Drawing.Size(93, 32);
            this.numChaptersToManga.TabIndex = 12;
            this.numChaptersToManga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.numChaptersFromManga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChaptersFromManga.Name = "numChaptersFromManga";
            this.numChaptersFromManga.Size = new System.Drawing.Size(93, 32);
            this.numChaptersFromManga.TabIndex = 10;
            this.numChaptersFromManga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tabCharacters.Location = new System.Drawing.Point(4, 46);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacters.Size = new System.Drawing.Size(1797, 852);
            this.tabCharacters.TabIndex = 2;
            this.tabCharacters.Text = "Characters";
            // 
            // tabCreateAccount
            // 
            this.tabCreateAccount.BackColor = System.Drawing.Color.Thistle;
            this.tabCreateAccount.Controls.Add(this.groupBox1);
            this.tabCreateAccount.Location = new System.Drawing.Point(4, 46);
            this.tabCreateAccount.Name = "tabCreateAccount";
            this.tabCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateAccount.Size = new System.Drawing.Size(1797, 852);
            this.tabCreateAccount.TabIndex = 3;
            this.tabCreateAccount.Text = "Create account";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create account for maintainer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 32);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WinFormsGraphic.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1884, 1041);
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
            ((System.ComponentModel.ISupportInitialize)(this.numRatingSearchAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesToSearchAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNrEpisodesFromSearchAnime)).EndInit();
            this.tabManga.ResumeLayout(false);
            this.groupBoxSortManga.ResumeLayout(false);
            this.groupBoxSortManga.PerformLayout();
            this.groupBoxSearchManga.ResumeLayout(false);
            this.groupBoxSearchManga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersToManga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChaptersFromManga)).EndInit();
            this.tabCreateAccount.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private NumericUpDown numRatingSearchAnime;
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
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
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
        private NumericUpDown numRatingManga;
        private Label labelRatingManga;
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
    }
}