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
            this.FilmTitleValue = new System.Windows.Forms.TextBox();
            this.FilmDescriptionValue = new System.Windows.Forms.TextBox();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.ReleaseDateLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilmRatingValue = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.FilmReleaseDateMonthCalander = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFilmLabel
            // 
            this.AddFilmLabel.AutoSize = true;
            this.AddFilmLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddFilmLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddFilmLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddFilmLabel.Location = new System.Drawing.Point(34, 9);
            this.AddFilmLabel.Name = "AddFilmLabel";
            this.AddFilmLabel.Size = new System.Drawing.Size(109, 32);
            this.AddFilmLabel.TabIndex = 1;
            this.AddFilmLabel.Text = "Add Film";
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(67, 32);
            this.FilmTitleLabel.TabIndex = 5;
            this.FilmTitleLabel.Text = "Title: ";
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmTitleValue.Location = new System.Drawing.Point(205, 3);
            this.FilmTitleValue.MaxLength = 50;
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(532, 39);
            this.FilmTitleValue.TabIndex = 6;
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmDescriptionValue.Location = new System.Drawing.Point(205, 45);
            this.FilmDescriptionValue.MaxLength = 4000;
            this.FilmDescriptionValue.Multiline = true;
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(532, 215);
            this.FilmDescriptionValue.TabIndex = 8;
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(3, 42);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.FilmDescriptionLabel.TabIndex = 7;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // ReleaseDateLabel
            // 
            this.ReleaseDateLabel.AutoSize = true;
            this.ReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ReleaseDateLabel.Location = new System.Drawing.Point(3, 263);
            this.ReleaseDateLabel.Name = "ReleaseDateLabel";
            this.ReleaseDateLabel.Size = new System.Drawing.Size(148, 32);
            this.ReleaseDateLabel.TabIndex = 9;
            this.ReleaseDateLabel.Text = "Release Date:";
            // 
            // FilmRatingValue
            // 
            this.FilmRatingValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmRatingValue.Location = new System.Drawing.Point(205, 445);
            this.FilmRatingValue.Name = "FilmRatingValue";
            this.FilmRatingValue.Size = new System.Drawing.Size(233, 39);
            this.FilmRatingValue.TabIndex = 12;
            this.FilmRatingValue.Text = "0";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.RatingLabel.Location = new System.Drawing.Point(3, 442);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(82, 32);
            this.RatingLabel.TabIndex = 11;
            this.RatingLabel.Text = "Rating:";
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
            this.AddFilmButton.Location = new System.Drawing.Point(332, 549);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(122, 47);
            this.AddFilmButton.TabIndex = 13;
            this.AddFilmButton.Text = "Add Film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // FilmReleaseDateMonthCalander
            // 
            this.FilmReleaseDateMonthCalander.Location = new System.Drawing.Point(211, 272);
            this.FilmReleaseDateMonthCalander.MaxSelectionCount = 1;
            this.FilmReleaseDateMonthCalander.Name = "FilmReleaseDateMonthCalander";
            this.FilmReleaseDateMonthCalander.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.40214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.59786F));
            this.tableLayoutPanel1.Controls.Add(this.FilmTitleValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilmDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FilmRatingValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RatingLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FilmDescriptionValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReleaseDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FilmTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilmReleaseDateMonthCalander, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.703704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.47325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.83128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.703704F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 486);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 607);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.AddFilmLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddFilmForm";
            this.Text = "Add Film";
            this.Load += new System.EventHandler(this.AddFilmForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddFilmLabel;
        private Label FilmTitleLabel;
        private TextBox FilmTitleValue;
        private TextBox FilmDescriptionValue;
        private Label FilmDescriptionLabel;
        private Label ReleaseDateLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox FilmRatingValue;
        private Label RatingLabel;
        private Button AddFilmButton;
        private MonthCalendar FilmReleaseDateMonthCalander;
        private TableLayoutPanel tableLayoutPanel1;
    }
}