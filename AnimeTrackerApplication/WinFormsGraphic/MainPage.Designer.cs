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
            this.tabCreateAccount = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
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
            this.tabCreateAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.tabCharacters.Controls.Add(this.groupBox2);
            this.tabCharacters.Controls.Add(this.listView1);
            this.tabCharacters.Controls.Add(this.groupBox3);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(16, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 273);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort manga by:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(268, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 30);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rating ↓";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 30);
            this.radioButton2.TabIndex = 44;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rating ↑";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(268, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(175, 30);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Release year ↓";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 116);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(175, 30);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Release year ↑";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(268, 80);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(119, 30);
            this.radioButton5.TabIndex = 41;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Creator ↓";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(33, 80);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(119, 30);
            this.radioButton6.TabIndex = 40;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Creator ↑";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(268, 44);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(106, 30);
            this.radioButton7.TabIndex = 39;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Name ↓";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(33, 44);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(106, 30);
            this.radioButton8.TabIndex = 38;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Name ↑";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(21, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 54);
            this.button1.TabIndex = 37;
            this.button1.Text = "Display all";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView1.Location = new System.Drawing.Point(582, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1178, 696);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Creator";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rating";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Release Year";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nr chapters";
            this.columnHeader6.Width = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(16, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 419);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manga search:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(316, 296);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 32);
            this.numericUpDown1.TabIndex = 50;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(268, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 54);
            this.button2.TabIndex = 44;
            this.button2.Text = "Clear fields";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 32);
            this.textBox2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 49;
            this.label2.Text = "To:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Location = new System.Drawing.Point(116, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(156, 296);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 32);
            this.numericUpDown2.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(21, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 54);
            this.button3.TabIndex = 38;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 25;
            this.comboBox2.Location = new System.Drawing.Point(116, 252);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 33);
            this.comboBox2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Rating from:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Genre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Release year:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(396, 126);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(93, 32);
            this.numericUpDown3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "To:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(231, 126);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(93, 32);
            this.numericUpDown4.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nr of chapters from:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(313, 32);
            this.textBox4.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 51;
            this.label9.Text = "Name:";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(121, 82);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(77, 30);
            this.radioButton9.TabIndex = 52;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Male";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(204, 82);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(103, 30);
            this.radioButton10.TabIndex = 53;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Female";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(313, 82);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(121, 30);
            this.radioButton11.TabIndex = 54;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Unknown";
            this.radioButton11.UseVisualStyleBackColor = true;
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
            this.tabCreateAccount.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox3;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Button button3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private NumericUpDown numericUpDown4;
        private Label label8;
        private TextBox textBox4;
        private Label label10;
    }
}