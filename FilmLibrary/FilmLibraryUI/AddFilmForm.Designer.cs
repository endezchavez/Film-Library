namespace FilmLibraryUI
{
    partial class AddFilmForm
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
            this.AddFilmLabel = new System.Windows.Forms.Label();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescripionTextBox = new System.Windows.Forms.TextBox();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.ReleaseDateMonthCalander = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // AddFilmLabel
            // 
            this.AddFilmLabel.AutoSize = true;
            this.AddFilmLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddFilmLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFilmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddFilmLabel.Location = new System.Drawing.Point(34, 32);
            this.AddFilmLabel.Name = "AddFilmLabel";
            this.AddFilmLabel.Size = new System.Drawing.Size(136, 41);
            this.AddFilmLabel.TabIndex = 1;
            this.AddFilmLabel.Text = "Add Film";
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(34, 86);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(84, 41);
            this.FilmTitleLabel.TabIndex = 5;
            this.FilmTitleLabel.Text = "Title: ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Location = new System.Drawing.Point(217, 80);
            this.TitleTextBox.MaxLength = 50;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(283, 47);
            this.TitleTextBox.TabIndex = 6;
            // 
            // DescripionTextBox
            // 
            this.DescripionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripionTextBox.Location = new System.Drawing.Point(217, 149);
            this.DescripionTextBox.MaxLength = 4000;
            this.DescripionTextBox.Multiline = true;
            this.DescripionTextBox.Name = "DescripionTextBox";
            this.DescripionTextBox.Size = new System.Drawing.Size(283, 87);
            this.DescripionTextBox.TabIndex = 8;
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(34, 151);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(166, 41);
            this.FilmDescriptionLabel.TabIndex = 7;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(34, 316);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(187, 41);
            this.ReleaseDateLabel.TabIndex = 9;
            this.ReleaseDateLabel.Text = "Release Date:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingTextBox.Location = new System.Drawing.Point(217, 491);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(283, 47);
            this.RatingTextBox.TabIndex = 12;
            this.RatingTextBox.Text = "0";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.RatingLabel.Location = new System.Drawing.Point(34, 493);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(105, 41);
            this.RatingLabel.TabIndex = 11;
            this.RatingLabel.Text = "Rating:";
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.AddFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.Location = new System.Drawing.Point(568, 491);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(122, 47);
            this.AddFilmButton.TabIndex = 13;
            this.AddFilmButton.Text = "Add Film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // ReleaseDateMonthCalander
            // 
            this.ReleaseDateMonthCalander.Location = new System.Drawing.Point(233, 248);
            this.ReleaseDateMonthCalander.MaxSelectionCount = 1;
            this.ReleaseDateMonthCalander.Name = "ReleaseDateMonthCalander";
            this.ReleaseDateMonthCalander.TabIndex = 14;
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 607);
            this.Controls.Add(this.ReleaseDateMonthCalander);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.DescripionTextBox);
            this.Controls.Add(this.FilmDescriptionLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.FilmTitleLabel);
            this.Controls.Add(this.AddFilmLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddFilmForm";
            this.Text = "Add Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddFilmLabel;
        private Label FilmTitleLabel;
        private TextBox TitleTextBox;
        private TextBox DescripionTextBox;
        private Label FilmDescriptionLabel;
        private Label ReleaseDateLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private Button AddFilmButton;
        private MonthCalendar ReleaseDateMonthCalander;
    }
}