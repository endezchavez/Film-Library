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
            this.DeleteFilmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleErrorLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.TextBox();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.TextBox();
            this.DescriptionErrorLabel = new System.Windows.Forms.Label();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.ReleaseDateErrorLabel = new System.Windows.Forms.Label();
            this.ReleaseDateGroupBox = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1.SuspendLayout();
            this.TitleGroupBox.SuspendLayout();
            this.DescriptionGroupBox.SuspendLayout();
            this.ReleaseDateGroupBox.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ReleaseDateGroupBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FilmReleaseDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FilmTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilmDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionGroupBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.74517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.7915F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.984556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 518);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // TitleGroupBox
            // 
            this.TitleGroupBox.Controls.Add(this.FilmTitleValue);
            this.TitleGroupBox.Controls.Add(this.TitleErrorLabel);
            this.TitleGroupBox.Location = new System.Drawing.Point(419, 3);
            this.TitleGroupBox.Name = "TitleGroupBox";
            this.TitleGroupBox.Size = new System.Drawing.Size(410, 109);
            this.TitleGroupBox.TabIndex = 0;
            this.TitleGroupBox.TabStop = false;
            // 
            // TitleErrorLabel
            // 
            this.TitleErrorLabel.AutoSize = true;
            this.TitleErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleErrorLabel.Location = new System.Drawing.Point(11, 29);
            this.TitleErrorLabel.Name = "TitleErrorLabel";
            this.TitleErrorLabel.Size = new System.Drawing.Size(55, 23);
            this.TitleErrorLabel.TabIndex = 0;
            this.TitleErrorLabel.Text = "label1";
            this.TitleErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilmTitleValue
            // 
            this.FilmTitleValue.Location = new System.Drawing.Point(11, 55);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(393, 47);
            this.FilmTitleValue.TabIndex = 1;
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.FilmTitleLabel.Name = "FilmTitleLabel";
            this.FilmTitleLabel.Size = new System.Drawing.Size(76, 41);
            this.FilmTitleLabel.TabIndex = 2;
            this.FilmTitleLabel.Text = "Title:";
            this.FilmTitleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FilmDescriptionLabel
            // 
            this.FilmDescriptionLabel.AutoSize = true;
            this.FilmDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(3, 123);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(166, 41);
            this.FilmDescriptionLabel.TabIndex = 3;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.Location = new System.Drawing.Point(11, 52);
            this.FilmDescriptionValue.Name = "FilmDescriptionValue";
            this.FilmDescriptionValue.Size = new System.Drawing.Size(393, 47);
            this.FilmDescriptionValue.TabIndex = 1;
            // 
            // DescriptionErrorLabel
            // 
            this.DescriptionErrorLabel.AutoSize = true;
            this.DescriptionErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionErrorLabel.Location = new System.Drawing.Point(11, 26);
            this.DescriptionErrorLabel.Name = "DescriptionErrorLabel";
            this.DescriptionErrorLabel.Size = new System.Drawing.Size(55, 23);
            this.DescriptionErrorLabel.TabIndex = 0;
            this.DescriptionErrorLabel.Text = "label1";
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.FilmDescriptionValue);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionErrorLabel);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(419, 126);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(410, 69);
            this.DescriptionGroupBox.TabIndex = 2;
            this.DescriptionGroupBox.TabStop = false;
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(3, 198);
            this.FilmReleaseDateLabel.Name = "FilmReleaseDateLabel";
            this.FilmReleaseDateLabel.Size = new System.Drawing.Size(166, 41);
            this.FilmReleaseDateLabel.TabIndex = 4;
            this.FilmReleaseDateLabel.Text = "Description:";
            // 
            // ReleaseDateErrorLabel
            // 
            this.ReleaseDateErrorLabel.AutoSize = true;
            this.ReleaseDateErrorLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDateErrorLabel.Location = new System.Drawing.Point(11, 43);
            this.ReleaseDateErrorLabel.Name = "ReleaseDateErrorLabel";
            this.ReleaseDateErrorLabel.Size = new System.Drawing.Size(55, 23);
            this.ReleaseDateErrorLabel.TabIndex = 0;
            this.ReleaseDateErrorLabel.Text = "label1";
            // 
            // ReleaseDateGroupBox
            // 
            this.ReleaseDateGroupBox.Controls.Add(this.monthCalendar1);
            this.ReleaseDateGroupBox.Controls.Add(this.ReleaseDateErrorLabel);
            this.ReleaseDateGroupBox.Location = new System.Drawing.Point(419, 201);
            this.ReleaseDateGroupBox.Name = "ReleaseDateGroupBox";
            this.ReleaseDateGroupBox.Size = new System.Drawing.Size(410, 283);
            this.ReleaseDateGroupBox.TabIndex = 3;
            this.ReleaseDateGroupBox.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 75);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // EditFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DeleteFilmButton);
            this.Controls.Add(this.UpdateFilmButton);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditFilmForm";
            this.Text = "Edit Film";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TitleGroupBox.ResumeLayout(false);
            this.TitleGroupBox.PerformLayout();
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ReleaseDateGroupBox.ResumeLayout(false);
            this.ReleaseDateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button UpdateFilmButton;
        private Button DeleteFilmButton;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox TitleGroupBox;
        private TextBox FilmTitleValue;
        private Label TitleErrorLabel;
        private Label FilmTitleLabel;
        private GroupBox ReleaseDateGroupBox;
        private MonthCalendar monthCalendar1;
        private Label ReleaseDateErrorLabel;
        private Label FilmReleaseDateLabel;
        private Label FilmDescriptionLabel;
        private GroupBox DescriptionGroupBox;
        private TextBox FilmDescriptionValue;
        private Label DescriptionErrorLabel;
    }
}