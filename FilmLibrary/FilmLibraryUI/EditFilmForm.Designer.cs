namespace FilmLibraryUI
{
    partial class EditFilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFilmForm));
            this.UpdateFilmButton = new System.Windows.Forms.Button();
            this.DeleteFilmButton = new System.Windows.Forms.Button();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.TextBox();
            this.FilmTitleErrorLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionErrorLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.TextBox();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateMonthCalander = new System.Windows.Forms.MonthCalendar();
            this.FilmReleaseDateErrorLabel = new System.Windows.Forms.Label();
            this.FilmRatingErrorLabel = new System.Windows.Forms.Label();
            this.FilmRatingValue = new System.Windows.Forms.TextBox();
            this.FilmRatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateFilmButton
            // 
            this.UpdateFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.UpdateFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateFilmButton.Location = new System.Drawing.Point(292, 536);
            this.UpdateFilmButton.Name = "UpdateFilmButton";
            this.UpdateFilmButton.Size = new System.Drawing.Size(122, 45);
            this.UpdateFilmButton.TabIndex = 23;
            this.UpdateFilmButton.Text = "Update Film";
            this.UpdateFilmButton.UseVisualStyleBackColor = true;
            this.UpdateFilmButton.Click += new System.EventHandler(this.UpdateFilmButton_Click);
            // 
            // DeleteFilmButton
            // 
            this.DeleteFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.DeleteFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.DeleteFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteFilmButton.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteFilmButton.Location = new System.Drawing.Point(442, 536);
            this.DeleteFilmButton.Name = "DeleteFilmButton";
            this.DeleteFilmButton.Size = new System.Drawing.Size(122, 45);
            this.DeleteFilmButton.TabIndex = 25;
            this.DeleteFilmButton.Text = "Delete Film";
            this.DeleteFilmButton.UseVisualStyleBackColor = true;
            this.DeleteFilmButton.Click += new System.EventHandler(this.DeleteFilmButton_Click);
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(12, 30);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(60, 32);
            this.FilmTitleLabel.TabIndex = 26;
            this.FilmTitleLabel.Text = "Title:";
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.Location = new System.Drawing.Point(172, 30);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(672, 39);
            this.FilmTitleValue.TabIndex = 27;
            // 
            // FilmTitleErrorLabel
            // 
            this.FilmTitleErrorLabel.AutoSize = true;
            this.FilmTitleErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmTitleErrorLabel.Location = new System.Drawing.Point(172, 10);
            this.FilmTitleErrorLabel.Name = "FilmTitleErrorLabel";
            this.FilmTitleErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmTitleErrorLabel.TabIndex = 28;
            // 
            // FilmDescriptionErrorLabel
            // 
            this.FilmDescriptionErrorLabel.AutoSize = true;
            this.FilmDescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmDescriptionErrorLabel.Location = new System.Drawing.Point(172, 82);
            this.FilmDescriptionErrorLabel.Name = "FilmDescriptionErrorLabel";
            this.FilmDescriptionErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmDescriptionErrorLabel.TabIndex = 31;
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionValue.Location = new System.Drawing.Point(172, 102);
            this.FilmDescriptionValue.Multiline = true;
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(672, 167);
            this.FilmDescriptionValue.TabIndex = 30;
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(12, 102);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.FilmDescriptionLabel.TabIndex = 29;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(12, 297);
            this.FilmReleaseDateLabel.Name = "FilmReleaseDateLabel";
            this.FilmReleaseDateLabel.Size = new System.Drawing.Size(148, 32);
            this.FilmReleaseDateLabel.TabIndex = 32;
            this.FilmReleaseDateLabel.Text = "Release Date:";
            // 
            // FilmReleaseDateMonthCalander
            // 
            this.FilmReleaseDateMonthCalander.Location = new System.Drawing.Point(172, 297);
            this.FilmReleaseDateMonthCalander.MaxSelectionCount = 1;
            this.FilmReleaseDateMonthCalander.Name = "FilmReleaseDateMonthCalander";
            this.FilmReleaseDateMonthCalander.TabIndex = 33;
            // 
            // FilmReleaseDateErrorLabel
            // 
            this.FilmReleaseDateErrorLabel.AutoSize = true;
            this.FilmReleaseDateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmReleaseDateErrorLabel.Location = new System.Drawing.Point(172, 277);
            this.FilmReleaseDateErrorLabel.Name = "FilmReleaseDateErrorLabel";
            this.FilmReleaseDateErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmReleaseDateErrorLabel.TabIndex = 34;
            // 
            // FilmRatingErrorLabel
            // 
            this.FilmRatingErrorLabel.AutoSize = true;
            this.FilmRatingErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.FilmRatingErrorLabel.Location = new System.Drawing.Point(172, 468);
            this.FilmRatingErrorLabel.Name = "FilmRatingErrorLabel";
            this.FilmRatingErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.FilmRatingErrorLabel.TabIndex = 37;
            // 
            // FilmRatingValue
            // 
            this.FilmRatingValue.Location = new System.Drawing.Point(172, 488);
            this.FilmRatingValue.Name = "FilmRatingValue";
            this.FilmRatingValue.Size = new System.Drawing.Size(227, 39);
            this.FilmRatingValue.TabIndex = 36;
            // 
            // FilmRatingLabel
            // 
            this.FilmRatingLabel.AutoSize = true;
            this.FilmRatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmRatingLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FilmRatingLabel.Location = new System.Drawing.Point(12, 488);
            this.FilmRatingLabel.Name = "FilmRatingLabel";
            this.FilmRatingLabel.Size = new System.Drawing.Size(82, 32);
            this.FilmRatingLabel.TabIndex = 35;
            this.FilmRatingLabel.Text = "Rating:";
            // 
            // EditFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 593);
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
            this.Controls.Add(this.DeleteFilmButton);
            this.Controls.Add(this.UpdateFilmButton);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditFilmForm";
            this.Text = "Edit Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateFilmButton;
        private Button DeleteFilmButton;
        private Label FilmTitleLabel;
        private TextBox FilmTitleValue;
        private Label FilmTitleErrorLabel;
        private Label FilmDescriptionErrorLabel;
        private TextBox FilmDescriptionValue;
        private Label FilmDescriptionLabel;
        private Label FilmReleaseDateLabel;
        private MonthCalendar FilmReleaseDateMonthCalander;
        private Label FilmReleaseDateErrorLabel;
        private Label FilmRatingErrorLabel;
        private TextBox FilmRatingValue;
        private Label FilmRatingLabel;
    }
}