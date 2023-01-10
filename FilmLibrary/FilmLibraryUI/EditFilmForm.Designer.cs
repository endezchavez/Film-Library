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
            this.UpdateFilmButton = new System.Windows.Forms.Button();
            this.FilmRatingValue = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EditFilmLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateMonthCalander = new System.Windows.Forms.MonthCalendar();
            this.DeleteFilmButton = new System.Windows.Forms.Button();
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
            this.UpdateFilmButton.Location = new System.Drawing.Point(607, 468);
            this.UpdateFilmButton.Name = "UpdateFilmButton";
            this.UpdateFilmButton.Size = new System.Drawing.Size(122, 45);
            this.UpdateFilmButton.TabIndex = 23;
            this.UpdateFilmButton.Text = "Update Film";
            this.UpdateFilmButton.UseVisualStyleBackColor = true;
            this.UpdateFilmButton.Click += new System.EventHandler(this.UpdateFilmButton_Click);
            // 
            // FilmRatingValue
            // 
            this.FilmRatingValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmRatingValue.Location = new System.Drawing.Point(241, 466);
            this.FilmRatingValue.Name = "FilmRatingValue";
            this.FilmRatingValue.Size = new System.Drawing.Size(283, 39);
            this.FilmRatingValue.TabIndex = 22;
            this.FilmRatingValue.Text = "0";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.RatingLabel.Location = new System.Drawing.Point(58, 469);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(82, 32);
            this.RatingLabel.TabIndex = 21;
            this.RatingLabel.Text = "Rating:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(58, 321);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(148, 32);
            this.ReleaseDateLabel.TabIndex = 19;
            this.ReleaseDateLabel.Text = "Release Date:";
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmDescriptionValue.Location = new System.Drawing.Point(241, 154);
            this.FilmDescriptionValue.Multiline = true;
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(283, 87);
            this.FilmDescriptionValue.TabIndex = 18;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.DescriptionLabel.Location = new System.Drawing.Point(58, 156);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.DescriptionLabel.TabIndex = 17;
            this.DescriptionLabel.Text = "Description:";
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmTitleValue.Location = new System.Drawing.Point(241, 85);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(283, 39);
            this.FilmTitleValue.TabIndex = 16;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.TitleLabel.Location = new System.Drawing.Point(58, 91);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(67, 32);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Title: ";
            // 
            // EditFilmLabel
            // 
            this.EditFilmLabel.AutoSize = true;
            this.EditFilmLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditFilmLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditFilmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EditFilmLabel.Location = new System.Drawing.Point(58, 37);
            this.EditFilmLabel.Name = "EditFilmLabel";
            this.EditFilmLabel.Size = new System.Drawing.Size(106, 32);
            this.EditFilmLabel.TabIndex = 14;
            this.EditFilmLabel.Text = "Edit Film";
            // 
            // FilmReleaseDateMonthCalander
            // 
            this.FilmReleaseDateMonthCalander.Location = new System.Drawing.Point(272, 253);
            this.FilmReleaseDateMonthCalander.MaxSelectionCount = 1;
            this.FilmReleaseDateMonthCalander.Name = "FilmReleaseDateMonthCalander";
            this.FilmReleaseDateMonthCalander.TabIndex = 24;
            // 
            // DeleteFilmButton
            // 
            this.DeleteFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.DeleteFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.DeleteFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteFilmButton.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteFilmButton.Location = new System.Drawing.Point(607, 519);
            this.DeleteFilmButton.Name = "DeleteFilmButton";
            this.DeleteFilmButton.Size = new System.Drawing.Size(122, 45);
            this.DeleteFilmButton.TabIndex = 25;
            this.DeleteFilmButton.Text = "Delete Film";
            this.DeleteFilmButton.UseVisualStyleBackColor = true;
            this.DeleteFilmButton.Click += new System.EventHandler(this.DeleteFilmButton_Click);
            // 
            // EditFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 593);
            this.Controls.Add(this.DeleteFilmButton);
            this.Controls.Add(this.FilmReleaseDateMonthCalander);
            this.Controls.Add(this.UpdateFilmButton);
            this.Controls.Add(this.FilmRatingValue);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.ReleaseDateLabel);
            this.Controls.Add(this.FilmDescriptionValue);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.FilmTitleValue);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EditFilmLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditFilmForm";
            this.Text = "Edit Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateFilmButton;
        private TextBox FilmRatingValue;
        private Label RatingLabel;
        private Label ReleaseDateLabel;
        private TextBox FilmDescriptionValue;
        private Label DescriptionLabel;
        private TextBox FilmTitleValue;
        private Label TitleLabel;
        private Label EditFilmLabel;
        private MonthCalendar FilmReleaseDateMonthCalander;
        private Button DeleteFilmButton;
    }
}