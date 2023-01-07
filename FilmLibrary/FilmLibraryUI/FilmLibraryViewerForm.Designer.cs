namespace FilmLibraryUI
{
    partial class FilmLibraryViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilmLibraryLabel = new System.Windows.Forms.Label();
            this.FilmLibraryListBox = new System.Windows.Forms.ListBox();
            this.CurrentFilmLabel = new System.Windows.Forms.Label();
            this.CurrentFilmName = new System.Windows.Forms.Label();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.FilmTitle = new System.Windows.Forms.Label();
            this.FilmDescription = new System.Windows.Forms.Label();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDate = new System.Windows.Forms.Label();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmRating = new System.Windows.Forms.Label();
            this.FilmRatingLabel = new System.Windows.Forms.Label();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.EditFilmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmLibraryLabel
            // 
            this.FilmLibraryLabel.AutoSize = true;
            this.FilmLibraryLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilmLibraryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmLibraryLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmLibraryLabel.Location = new System.Drawing.Point(31, 23);
            this.FilmLibraryLabel.Name = "FilmLibraryLabel";
            this.FilmLibraryLabel.Size = new System.Drawing.Size(170, 41);
            this.FilmLibraryLabel.TabIndex = 0;
            this.FilmLibraryLabel.Text = "Film Library";
            // 
            // FilmLibraryListBox
            // 
            this.FilmLibraryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmLibraryListBox.FormattingEnabled = true;
            this.FilmLibraryListBox.ItemHeight = 20;
            this.FilmLibraryListBox.Location = new System.Drawing.Point(31, 77);
            this.FilmLibraryListBox.Name = "FilmLibraryListBox";
            this.FilmLibraryListBox.Size = new System.Drawing.Size(282, 322);
            this.FilmLibraryListBox.TabIndex = 1;
            // 
            // CurrentFilmLabel
            // 
            this.CurrentFilmLabel.AutoSize = true;
            this.CurrentFilmLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentFilmLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentFilmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CurrentFilmLabel.Location = new System.Drawing.Point(370, 23);
            this.CurrentFilmLabel.Name = "CurrentFilmLabel";
            this.CurrentFilmLabel.Size = new System.Drawing.Size(187, 41);
            this.CurrentFilmLabel.TabIndex = 2;
            this.CurrentFilmLabel.Text = "Current Film:";
            // 
            // CurrentFilmName
            // 
            this.CurrentFilmName.AutoSize = true;
            this.CurrentFilmName.BackColor = System.Drawing.Color.Transparent;
            this.CurrentFilmName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentFilmName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CurrentFilmName.Location = new System.Drawing.Point(547, 23);
            this.CurrentFilmName.Name = "CurrentFilmName";
            this.CurrentFilmName.Size = new System.Drawing.Size(133, 41);
            this.CurrentFilmName.TabIndex = 3;
            this.CurrentFilmName.Text = "<None>";
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(370, 77);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(84, 41);
            this.FilmTitleLabel.TabIndex = 4;
            this.FilmTitleLabel.Text = "Title: ";
            // 
            // FilmTitle
            // 
            this.FilmTitle.AutoSize = true;
            this.FilmTitle.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitle.Location = new System.Drawing.Point(448, 77);
            this.FilmTitle.Name = "FilmTitle";
            this.FilmTitle.Size = new System.Drawing.Size(125, 41);
            this.FilmTitle.TabIndex = 5;
            this.FilmTitle.Text = "<None>";
            // 
            // FilmDescription
            // 
            this.FilmDescription.AutoSize = true;
            this.FilmDescription.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescription.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescription.Location = new System.Drawing.Point(547, 128);
            this.FilmDescription.Name = "FilmDescription";
            this.FilmDescription.Size = new System.Drawing.Size(125, 41);
            this.FilmDescription.TabIndex = 7;
            this.FilmDescription.Text = "<None>";
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(370, 128);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(166, 41);
            this.FilmDescriptionLabel.TabIndex = 6;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmReleaseDate
            // 
            this.FilmReleaseDate.AutoSize = true;
            this.FilmReleaseDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDate.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDate.Location = new System.Drawing.Point(547, 183);
            this.FilmReleaseDate.Name = "FilmReleaseDate";
            this.FilmReleaseDate.Size = new System.Drawing.Size(125, 41);
            this.FilmReleaseDate.TabIndex = 9;
            this.FilmReleaseDate.Text = "<None>";
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(370, 183);
            this.FilmReleaseDateLabel.Name = "FilmReleaseDateLabel";
            this.FilmReleaseDateLabel.Size = new System.Drawing.Size(179, 41);
            this.FilmReleaseDateLabel.TabIndex = 8;
            this.FilmReleaseDateLabel.Text = "ReleaseDate:";
            // 
            // FilmRating
            // 
            this.FilmRating.AutoSize = true;
            this.FilmRating.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRating.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmRating.Location = new System.Drawing.Point(486, 239);
            this.FilmRating.Name = "FilmRating";
            this.FilmRating.Size = new System.Drawing.Size(33, 41);
            this.FilmRating.TabIndex = 11;
            this.FilmRating.Text = "0";
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmRatingLabel.Location = new System.Drawing.Point(370, 239);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(105, 41);
            this.FilmRatingLabel.TabIndex = 10;
            this.FilmRatingLabel.Text = "Rating:";
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.AddFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.Location = new System.Drawing.Point(474, 304);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(122, 45);
            this.AddFilmButton.TabIndex = 12;
            this.AddFilmButton.Text = "Add Film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            // 
            // EditFilmButton
            // 
            this.EditFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.EditFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.EditFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.EditFilmButton.Location = new System.Drawing.Point(474, 355);
            this.EditFilmButton.Name = "EditFilmButton";
            this.EditFilmButton.Size = new System.Drawing.Size(122, 45);
            this.EditFilmButton.TabIndex = 13;
            this.EditFilmButton.Text = "Edit Film";
            this.EditFilmButton.UseVisualStyleBackColor = true;
            // 
            // FilmLibraryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditFilmButton);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.FilmRating);
            this.Controls.Add(this.FilmRatingLabel);
            this.Controls.Add(this.FilmReleaseDate);
            this.Controls.Add(this.FilmReleaseDateLabel);
            this.Controls.Add(this.FilmDescription);
            this.Controls.Add(this.FilmDescriptionLabel);
            this.Controls.Add(this.FilmTitle);
            this.Controls.Add(this.FilmTitleLabel);
            this.Controls.Add(this.CurrentFilmName);
            this.Controls.Add(this.CurrentFilmLabel);
            this.Controls.Add(this.FilmLibraryListBox);
            this.Controls.Add(this.FilmLibraryLabel);
            this.Name = "FilmLibraryViewerForm";
            this.Text = "Film Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FilmLibraryLabel;
        private ListBox FilmLibraryListBox;
        private Label CurrentFilmLabel;
        private Label CurrentFilmName;
        private Label FilmTitleLabel;
        private Label FilmTitle;
        private Label FilmDescription;
        private Label FilmDescriptionLabel;
        private Label FilmReleaseDate;
        private Label FilmReleaseDateLabel;
        private Label FilmRating;
        private Label FilmRatingLabel;
        private Button AddFilmButton;
        private Button EditFilmButton;
    }
}