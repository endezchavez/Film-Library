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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilmForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.FilmRatingErrorLabel = new System.Windows.Forms.Label();
            this.FilmRatingValue = new System.Windows.Forms.TextBox();
            this.FilmRatingLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateErrorLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateMonthCalander = new System.Windows.Forms.MonthCalendar();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionErrorLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.TextBox();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmTitleErrorLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.TextBox();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.AddFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.AddFilmButton.Location = new System.Drawing.Point(358, 549);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(122, 47);
            this.AddFilmButton.TabIndex = 13;
            this.AddFilmButton.Text = "Add Film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // FilmRatingErrorLabel
            // 
            this.FilmRatingErrorLabel.AutoSize = true;
            this.FilmRatingErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmRatingErrorLabel.Location = new System.Drawing.Point(172, 466);
            this.FilmRatingErrorLabel.Name = "FilmRatingErrorLabel";
            this.FilmRatingErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmRatingErrorLabel.TabIndex = 49;
            // 
            // FilmRatingValue
            // 
            this.FilmRatingValue.Location = new System.Drawing.Point(172, 486);
            this.FilmRatingValue.Name = "FilmRatingValue";
            this.FilmRatingValue.Size = new System.Drawing.Size(227, 39);
            this.FilmRatingValue.TabIndex = 48;
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmRatingLabel.Location = new System.Drawing.Point(12, 486);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(82, 32);
            this.FilmRatingLabel.TabIndex = 47;
            this.FilmRatingLabel.Text = "Rating:";
            // 
            // FilmReleaseDateErrorLabel
            // 
            this.FilmReleaseDateErrorLabel.AutoSize = true;
            this.FilmReleaseDateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmReleaseDateErrorLabel.Location = new System.Drawing.Point(172, 275);
            this.FilmReleaseDateErrorLabel.Name = "FilmReleaseDateErrorLabel";
            this.FilmReleaseDateErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmReleaseDateErrorLabel.TabIndex = 46;
            // 
            // FilmReleaseDateMonthCalander
            // 
            this.FilmReleaseDateMonthCalander.Location = new System.Drawing.Point(172, 295);
            this.FilmReleaseDateMonthCalander.MaxSelectionCount = 1;
            this.FilmReleaseDateMonthCalander.Name = "FilmReleaseDateMonthCalander";
            this.FilmReleaseDateMonthCalander.TabIndex = 45;
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(12, 295);
            this.FilmReleaseDateLabel.Name = "FilmReleaseDateLabel";
            this.FilmReleaseDateLabel.Size = new System.Drawing.Size(148, 32);
            this.FilmReleaseDateLabel.TabIndex = 44;
            this.FilmReleaseDateLabel.Text = "Release Date:";
            // 
            // FilmDescriptionErrorLabel
            // 
            this.FilmDescriptionErrorLabel.AutoSize = true;
            this.FilmDescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmDescriptionErrorLabel.Location = new System.Drawing.Point(172, 80);
            this.FilmDescriptionErrorLabel.Name = "FilmDescriptionErrorLabel";
            this.FilmDescriptionErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmDescriptionErrorLabel.TabIndex = 43;
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionValue.Location = new System.Drawing.Point(172, 100);
            this.FilmDescriptionValue.Multiline = true;
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(672, 167);
            this.FilmDescriptionValue.TabIndex = 42;
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(12, 100);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.FilmDescriptionLabel.TabIndex = 41;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmTitleErrorLabel
            // 
            this.FilmTitleErrorLabel.AutoSize = true;
            this.FilmTitleErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmTitleErrorLabel.Location = new System.Drawing.Point(172, 8);
            this.FilmTitleErrorLabel.Name = "FilmTitleErrorLabel";
            this.FilmTitleErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmTitleErrorLabel.TabIndex = 40;
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.Location = new System.Drawing.Point(172, 28);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(672, 39);
            this.FilmTitleValue.TabIndex = 39;
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(12, 28);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(60, 32);
            this.FilmTitleLabel.TabIndex = 38;
            this.FilmTitleLabel.Text = "Title:";
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 607);
            this.Controls.Add(this.FilmRatingErrorLabel);
            this.Controls.Add(this.FilmRatingValue);
            this.Controls.Add(this.FilmRatingLabel);
            this.Controls.Add(this.FilmReleaseDateErrorLabel);
            this.Controls.Add(this.FilmReleaseDateMonthCalander);
            this.Controls.Add(this.FilmReleaseDateLabel);
            this.Controls.Add(this.FilmDescriptionErrorLabel);
            this.Controls.Add(this.FilmDescriptionValue);
            this.Controls.Add(this.FilmDescriptionLabel);
            this.Controls.Add(this.FilmTitleErrorLabel);
            this.Controls.Add(this.FilmTitleValue);
            this.Controls.Add(this.FilmTitleLabel);
            this.Controls.Add(this.AddFilmButton);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddFilmForm";
            this.Text = "Add Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddFilmButton;
        private Label FilmRatingErrorLabel;
        private TextBox FilmRatingValue;
        private Label FilmRatingLabel;
        private Label FilmReleaseDateErrorLabel;
        private MonthCalendar FilmReleaseDateMonthCalander;
        private Label FilmReleaseDateLabel;
        private Label FilmDescriptionErrorLabel;
        private TextBox FilmDescriptionValue;
        private Label FilmDescriptionLabel;
        private Label FilmTitleErrorLabel;
        private TextBox FilmTitleValue;
        private Label FilmTitleLabel;
    }
}