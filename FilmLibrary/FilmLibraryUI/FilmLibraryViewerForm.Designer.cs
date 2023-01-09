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
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.Label();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateValue = new System.Windows.Forms.Label();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmRatingValue = new System.Windows.Forms.Label();
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
            this.FilmLibraryLabel.Location = new System.Drawing.Point(27, 17);
            this.FilmLibraryLabel.Name = "FilmLibraryLabel";
            this.FilmLibraryLabel.Size = new System.Drawing.Size(137, 32);
            this.FilmLibraryLabel.TabIndex = 0;
            this.FilmLibraryLabel.Text = "Film Library";
            // 
            // FilmLibraryListBox
            // 
            this.FilmLibraryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmLibraryListBox.FormattingEnabled = true;
            this.FilmLibraryListBox.ItemHeight = 15;
            this.FilmLibraryListBox.Location = new System.Drawing.Point(27, 58);
            this.FilmLibraryListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmLibraryListBox.Name = "FilmLibraryListBox";
            this.FilmLibraryListBox.Size = new System.Drawing.Size(247, 242);
            this.FilmLibraryListBox.TabIndex = 1;
            this.FilmLibraryListBox.SelectedIndexChanged += new System.EventHandler(this.FilmLibraryListBox_SelectedIndexChanged);
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(324, 58);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(67, 32);
            this.FilmTitleLabel.TabIndex = 4;
            this.FilmTitleLabel.Text = "Title: ";
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.AutoSize = true;
            this.FilmTitleValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleValue.Location = new System.Drawing.Point(392, 58);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(101, 32);
            this.FilmTitleValue.TabIndex = 5;
            this.FilmTitleValue.Text = "<None>";
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.AutoSize = true;
            this.FilmDescriptionValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionValue.Location = new System.Drawing.Point(479, 96);
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(101, 32);
            this.FilmDescriptionValue.TabIndex = 7;
            this.FilmDescriptionValue.Text = "<None>";
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(324, 96);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.FilmDescriptionLabel.TabIndex = 6;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmReleaseDateValue
            // 
            this.FilmReleaseDateValue.AutoSize = true;
            this.FilmReleaseDateValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateValue.Location = new System.Drawing.Point(479, 137);
            this.FilmReleaseDateValue.Name = "FilmReleaseDateValue";
            this.FilmReleaseDateValue.Size = new System.Drawing.Size(101, 32);
            this.FilmReleaseDateValue.TabIndex = 9;
            this.FilmReleaseDateValue.Text = "<None>";
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(324, 137);
            this.FilmReleaseDateLabel.Name = "FilmReleaseDateLabel";
            this.FilmReleaseDateLabel.Size = new System.Drawing.Size(141, 32);
            this.FilmReleaseDateLabel.TabIndex = 8;
            this.FilmReleaseDateLabel.Text = "ReleaseDate:";
            // 
            // FilmRatingValue
            // 
            this.FilmRatingValue.AutoSize = true;
            this.FilmRatingValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmRatingValue.Location = new System.Drawing.Point(425, 179);
            this.FilmRatingValue.Name = "FilmRatingValue";
            this.FilmRatingValue.Size = new System.Drawing.Size(26, 32);
            this.FilmRatingValue.TabIndex = 11;
            this.FilmRatingValue.Text = "0";
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmRatingLabel.Location = new System.Drawing.Point(324, 179);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(82, 32);
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
            this.AddFilmButton.Location = new System.Drawing.Point(415, 228);
            this.AddFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(107, 34);
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
            this.EditFilmButton.Location = new System.Drawing.Point(415, 266);
            this.EditFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditFilmButton.Name = "EditFilmButton";
            this.EditFilmButton.Size = new System.Drawing.Size(107, 34);
            this.EditFilmButton.TabIndex = 13;
            this.EditFilmButton.Text = "Edit Film";
            this.EditFilmButton.UseVisualStyleBackColor = true;
            // 
            // FilmLibraryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.EditFilmButton);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.FilmRatingValue);
            this.Controls.Add(this.FilmRatingLabel);
            this.Controls.Add(this.FilmReleaseDateValue);
            this.Controls.Add(this.FilmReleaseDateLabel);
            this.Controls.Add(this.FilmDescriptionValue);
            this.Controls.Add(this.FilmDescriptionLabel);
            this.Controls.Add(this.FilmTitleValue);
            this.Controls.Add(this.FilmTitleLabel);
            this.Controls.Add(this.FilmLibraryListBox);
            this.Controls.Add(this.FilmLibraryLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilmLibraryViewerForm";
            this.Text = "Film Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FilmLibraryLabel;
        private ListBox FilmLibraryListBox;
        private Label FilmTitleLabel;
        private Label FilmTitleValue;
        private Label FilmDescriptionValue;
        private Label FilmDescriptionLabel;
        private Label FilmReleaseDateValue;
        private Label FilmReleaseDateLabel;
        private Label FilmRatingValue;
        private Label FilmRatingLabel;
        private Button AddFilmButton;
        private Button EditFilmButton;
    }
}