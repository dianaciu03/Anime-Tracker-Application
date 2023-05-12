namespace WinFormsGraphic
{
    partial class PopupEditCharacter
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
            this.groupBoxCharacterDetails = new System.Windows.Forms.GroupBox();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.tbxCharacterImage = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.btnCancelCharacterAddition = new System.Windows.Forms.Button();
            this.lvwMangaCharacter = new System.Windows.Forms.ListView();
            this.columnNameManga = new System.Windows.Forms.ColumnHeader();
            this.columnCreator = new System.Windows.Forms.ColumnHeader();
            this.tbxMangaTitle = new System.Windows.Forms.TextBox();
            this.labelMangaTitle = new System.Windows.Forms.Label();
            this.lvwAnimeCharacter = new System.Windows.Forms.ListView();
            this.columnNameAnime = new System.Windows.Forms.ColumnHeader();
            this.columnStudio = new System.Windows.Forms.ColumnHeader();
            this.tbxAnimeTitle = new System.Windows.Forms.TextBox();
            this.labelAnimeTitle = new System.Windows.Forms.Label();
            this.labelAppearsIn = new System.Windows.Forms.Label();
            this.rbtnUnknown = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.tbxCharacterName = new System.Windows.Forms.TextBox();
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.groupBoxCharacterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCharacterDetails
            // 
            this.groupBoxCharacterDetails.Controls.Add(this.btnEditCharacter);
            this.groupBoxCharacterDetails.Controls.Add(this.tbxCharacterImage);
            this.groupBoxCharacterDetails.Controls.Add(this.labelImage);
            this.groupBoxCharacterDetails.Controls.Add(this.btnCancelCharacterAddition);
            this.groupBoxCharacterDetails.Controls.Add(this.lvwMangaCharacter);
            this.groupBoxCharacterDetails.Controls.Add(this.tbxMangaTitle);
            this.groupBoxCharacterDetails.Controls.Add(this.labelMangaTitle);
            this.groupBoxCharacterDetails.Controls.Add(this.lvwAnimeCharacter);
            this.groupBoxCharacterDetails.Controls.Add(this.tbxAnimeTitle);
            this.groupBoxCharacterDetails.Controls.Add(this.labelAnimeTitle);
            this.groupBoxCharacterDetails.Controls.Add(this.labelAppearsIn);
            this.groupBoxCharacterDetails.Controls.Add(this.rbtnUnknown);
            this.groupBoxCharacterDetails.Controls.Add(this.rbtnFemale);
            this.groupBoxCharacterDetails.Controls.Add(this.rbtnMale);
            this.groupBoxCharacterDetails.Controls.Add(this.labelGender);
            this.groupBoxCharacterDetails.Controls.Add(this.tbxCharacterName);
            this.groupBoxCharacterDetails.Controls.Add(this.labelCharacterName);
            this.groupBoxCharacterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCharacterDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCharacterDetails.Name = "groupBoxCharacterDetails";
            this.groupBoxCharacterDetails.Size = new System.Drawing.Size(562, 685);
            this.groupBoxCharacterDetails.TabIndex = 46;
            this.groupBoxCharacterDetails.TabStop = false;
            this.groupBoxCharacterDetails.Text = "Character details:";
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.BackColor = System.Drawing.Color.Plum;
            this.btnEditCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditCharacter.ForeColor = System.Drawing.Color.Black;
            this.btnEditCharacter.Location = new System.Drawing.Point(20, 607);
            this.btnEditCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(221, 57);
            this.btnEditCharacter.TabIndex = 67;
            this.btnEditCharacter.Text = "Edit Character";
            this.btnEditCharacter.UseVisualStyleBackColor = false;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // tbxCharacterImage
            // 
            this.tbxCharacterImage.Location = new System.Drawing.Point(147, 82);
            this.tbxCharacterImage.Name = "tbxCharacterImage";
            this.tbxCharacterImage.Size = new System.Drawing.Size(297, 32);
            this.tbxCharacterImage.TabIndex = 66;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(20, 85);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(79, 26);
            this.labelImage.TabIndex = 65;
            this.labelImage.Text = "Image:";
            // 
            // btnCancelCharacterAddition
            // 
            this.btnCancelCharacterAddition.BackColor = System.Drawing.Color.Plum;
            this.btnCancelCharacterAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelCharacterAddition.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCharacterAddition.Location = new System.Drawing.Point(318, 607);
            this.btnCancelCharacterAddition.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelCharacterAddition.Name = "btnCancelCharacterAddition";
            this.btnCancelCharacterAddition.Size = new System.Drawing.Size(221, 57);
            this.btnCancelCharacterAddition.TabIndex = 64;
            this.btnCancelCharacterAddition.Text = "Cancel";
            this.btnCancelCharacterAddition.UseVisualStyleBackColor = false;
            this.btnCancelCharacterAddition.Click += new System.EventHandler(this.btnCancelCharacterAddition_Click);
            // 
            // lvwMangaCharacter
            // 
            this.lvwMangaCharacter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameManga,
            this.columnCreator});
            this.lvwMangaCharacter.FullRowSelect = true;
            this.lvwMangaCharacter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwMangaCharacter.Location = new System.Drawing.Point(20, 463);
            this.lvwMangaCharacter.MultiSelect = false;
            this.lvwMangaCharacter.Name = "lvwMangaCharacter";
            this.lvwMangaCharacter.Size = new System.Drawing.Size(519, 121);
            this.lvwMangaCharacter.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwMangaCharacter.TabIndex = 59;
            this.lvwMangaCharacter.UseCompatibleStateImageBehavior = false;
            this.lvwMangaCharacter.View = System.Windows.Forms.View.Details;
            this.lvwMangaCharacter.SelectedIndexChanged += new System.EventHandler(this.lvwMangaCharacter_SelectedIndexChanged);
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
            // tbxMangaTitle
            // 
            this.tbxMangaTitle.Location = new System.Drawing.Point(147, 413);
            this.tbxMangaTitle.Name = "tbxMangaTitle";
            this.tbxMangaTitle.Size = new System.Drawing.Size(297, 32);
            this.tbxMangaTitle.TabIndex = 61;
            this.tbxMangaTitle.TextChanged += new System.EventHandler(this.tbxMangaTitle_TextChanged);
            // 
            // labelMangaTitle
            // 
            this.labelMangaTitle.AutoSize = true;
            this.labelMangaTitle.Location = new System.Drawing.Point(20, 416);
            this.labelMangaTitle.Name = "labelMangaTitle";
            this.labelMangaTitle.Size = new System.Drawing.Size(124, 26);
            this.labelMangaTitle.TabIndex = 60;
            this.labelMangaTitle.Text = "Manga title:";
            // 
            // lvwAnimeCharacter
            // 
            this.lvwAnimeCharacter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameAnime,
            this.columnStudio});
            this.lvwAnimeCharacter.FullRowSelect = true;
            this.lvwAnimeCharacter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwAnimeCharacter.Location = new System.Drawing.Point(20, 258);
            this.lvwAnimeCharacter.MultiSelect = false;
            this.lvwAnimeCharacter.Name = "lvwAnimeCharacter";
            this.lvwAnimeCharacter.Size = new System.Drawing.Size(519, 121);
            this.lvwAnimeCharacter.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwAnimeCharacter.TabIndex = 46;
            this.lvwAnimeCharacter.UseCompatibleStateImageBehavior = false;
            this.lvwAnimeCharacter.View = System.Windows.Forms.View.Details;
            this.lvwAnimeCharacter.SelectedIndexChanged += new System.EventHandler(this.lvwAnimeCharacter_SelectedIndexChanged);
            // 
            // columnNameAnime
            // 
            this.columnNameAnime.Text = "Name";
            this.columnNameAnime.Width = 270;
            // 
            // columnStudio
            // 
            this.columnStudio.Text = "Studio";
            this.columnStudio.Width = 210;
            // 
            // tbxAnimeTitle
            // 
            this.tbxAnimeTitle.Location = new System.Drawing.Point(147, 209);
            this.tbxAnimeTitle.Name = "tbxAnimeTitle";
            this.tbxAnimeTitle.Size = new System.Drawing.Size(297, 32);
            this.tbxAnimeTitle.TabIndex = 57;
            this.tbxAnimeTitle.TextChanged += new System.EventHandler(this.tbxAnimeTitle_TextChanged);
            // 
            // labelAnimeTitle
            // 
            this.labelAnimeTitle.AutoSize = true;
            this.labelAnimeTitle.Location = new System.Drawing.Point(20, 212);
            this.labelAnimeTitle.Name = "labelAnimeTitle";
            this.labelAnimeTitle.Size = new System.Drawing.Size(121, 26);
            this.labelAnimeTitle.TabIndex = 56;
            this.labelAnimeTitle.Text = "Anime title:";
            // 
            // labelAppearsIn
            // 
            this.labelAppearsIn.AutoSize = true;
            this.labelAppearsIn.Location = new System.Drawing.Point(20, 176);
            this.labelAppearsIn.Name = "labelAppearsIn";
            this.labelAppearsIn.Size = new System.Drawing.Size(122, 26);
            this.labelAppearsIn.TabIndex = 55;
            this.labelAppearsIn.Text = "Appears in:";
            // 
            // rbtnUnknown
            // 
            this.rbtnUnknown.AutoSize = true;
            this.rbtnUnknown.Location = new System.Drawing.Point(339, 123);
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
            this.rbtnFemale.Location = new System.Drawing.Point(230, 123);
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
            this.rbtnMale.Location = new System.Drawing.Point(147, 123);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 30);
            this.rbtnMale.TabIndex = 52;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(20, 126);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(90, 26);
            this.labelGender.TabIndex = 51;
            this.labelGender.Text = "Gender:";
            // 
            // tbxCharacterName
            // 
            this.tbxCharacterName.Location = new System.Drawing.Point(147, 41);
            this.tbxCharacterName.Name = "tbxCharacterName";
            this.tbxCharacterName.Size = new System.Drawing.Size(297, 32);
            this.tbxCharacterName.TabIndex = 4;
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Location = new System.Drawing.Point(20, 41);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(77, 26);
            this.labelCharacterName.TabIndex = 1;
            this.labelCharacterName.Text = "Name:";
            // 
            // PopupEditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(590, 713);
            this.Controls.Add(this.groupBoxCharacterDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PopupEditCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupEditCharacter";
            this.groupBoxCharacterDetails.ResumeLayout(false);
            this.groupBoxCharacterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxCharacterDetails;
        private TextBox tbxCharacterImage;
        private Label labelImage;
        private Button btnCancelCharacterAddition;
        private ListView lvwMangaCharacter;
        private ColumnHeader columnNameManga;
        private ColumnHeader columnCreator;
        private TextBox tbxMangaTitle;
        private Label labelMangaTitle;
        private ListView lvwAnimeCharacter;
        private ColumnHeader columnNameAnime;
        private ColumnHeader columnStudio;
        private TextBox tbxAnimeTitle;
        private Label labelAnimeTitle;
        private Label labelAppearsIn;
        private RadioButton rbtnUnknown;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label labelGender;
        private TextBox tbxCharacterName;
        private Label labelCharacterName;
        private Button btnEditCharacter;
    }
}