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
            this.FilmLibraryListBox = new System.Windows.Forms.ListBox();
            this.FilmTitleLabel = new System.Windows.Forms.Label();
            this.FilmTitleValue = new System.Windows.Forms.Label();
            this.FilmDescriptionValue = new System.Windows.Forms.Label();
            this.FilmDescriptionLabel = new System.Windows.Forms.Label();
            this.FilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.FilmRatingValue = new System.Windows.Forms.Label();
            this.FilmRatingLabel = new System.Windows.Forms.Label();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.EditFilmButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilmReleaseDateValue = new System.Windows.Forms.Label();
            this.FilmDataLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.FilmDataLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmLibraryListBox
            // 
            this.FilmLibraryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilmLibraryListBox.FormattingEnabled = true;
            this.FilmLibraryListBox.ItemHeight = 15;
            this.FilmLibraryListBox.Location = new System.Drawing.Point(27, 88);
            this.FilmLibraryListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilmLibraryListBox.Name = "FilmLibraryListBox";
            this.FilmLibraryListBox.Size = new System.Drawing.Size(247, 392);
            this.FilmLibraryListBox.TabIndex = 1;
            this.FilmLibraryListBox.SelectedIndexChanged += new System.EventHandler(this.FilmLibraryListBox_SelectedIndexChanged);
            // 
            // FilmTitleLabel
            // 
            this.FilmTitleLabel.AutoSize = true;
            this.FilmTitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmTitleLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmTitleLabel.Location = new System.Drawing.Point(3, 0);
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
            this.FilmTitleValue.Location = new System.Drawing.Point(152, 0);
            this.FilmTitleValue.Name = "FilmTitleValue";
            this.FilmTitleValue.Size = new System.Drawing.Size(101, 32);
            this.FilmTitleValue.TabIndex = 5;
            this.FilmTitleValue.Text = "<None>";
            // 
            // FilmDescriptionValue
            // 
            this.FilmDescriptionValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilmDescriptionValue.AutoSize = true;
            this.FilmDescriptionValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmDescriptionValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmDescriptionValue.Location = new System.Drawing.Point(152, 32);
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
            this.FilmDescriptionLabel.Location = new System.Drawing.Point(3, 32);
            this.FilmDescriptionLabel.Name = "FilmDescriptionLabel";
            this.FilmDescriptionLabel.Size = new System.Drawing.Size(131, 32);
            this.FilmDescriptionLabel.TabIndex = 6;
            this.FilmDescriptionLabel.Text = "Description:";
            // 
            // FilmReleaseDateLabel
            // 
            this.FilmReleaseDateLabel.AutoSize = true;
            this.FilmReleaseDateLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateLabel.Location = new System.Drawing.Point(3, 64);
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
            this.FilmRatingValue.Location = new System.Drawing.Point(152, 96);
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
            this.FilmRatingLabel.Location = new System.Drawing.Point(3, 96);
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
            this.AddFilmButton.Location = new System.Drawing.Point(320, 446);
            this.AddFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(107, 34);
            this.AddFilmButton.TabIndex = 12;
            this.AddFilmButton.Text = "Add Film";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // EditFilmButton
            // 
            this.EditFilmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.EditFilmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.EditFilmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditFilmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFilmButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditFilmButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.EditFilmButton.Location = new System.Drawing.Point(450, 446);
            this.EditFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditFilmButton.Name = "EditFilmButton";
            this.EditFilmButton.Size = new System.Drawing.Size(107, 34);
            this.EditFilmButton.TabIndex = 13;
            this.EditFilmButton.Text = "Edit Film";
            this.EditFilmButton.UseVisualStyleBackColor = true;
            this.EditFilmButton.Click += new System.EventHandler(this.EditFilmButton_Click);
            // 
            // FilmReleaseDateValue
            // 
            this.FilmReleaseDateValue.AutoSize = true;
            this.FilmReleaseDateValue.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilmReleaseDateValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FilmReleaseDateValue.Location = new System.Drawing.Point(152, 64);
            this.FilmReleaseDateValue.Name = "FilmReleaseDateValue";
            this.FilmReleaseDateValue.Size = new System.Drawing.Size(101, 32);
            this.FilmReleaseDateValue.TabIndex = 14;
            this.FilmReleaseDateValue.Text = "<None>";
            // 
            // FilmDataLayoutPanel
            // 
            this.FilmDataLayoutPanel.ColumnCount = 2;
            this.FilmDataLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24291F));
            this.FilmDataLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.75709F));
            this.FilmDataLayoutPanel.Controls.Add(this.FilmDescriptionValue, 1, 1);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmRatingValue, 1, 3);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmRatingLabel, 0, 3);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmReleaseDateLabel, 0, 2);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmTitleLabel, 0, 0);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmDescriptionLabel, 0, 1);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmTitleValue, 1, 0);
            this.FilmDataLayoutPanel.Controls.Add(this.FilmReleaseDateValue, 1, 2);
            this.FilmDataLayoutPanel.Location = new System.Drawing.Point(320, 88);
            this.FilmDataLayoutPanel.Name = "FilmDataLayoutPanel";
            this.FilmDataLayoutPanel.RowCount = 4;
            this.FilmDataLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilmDataLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilmDataLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilmDataLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilmDataLayoutPanel.Size = new System.Drawing.Size(741, 337);
            this.FilmDataLayoutPanel.TabIndex = 15;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(320, 36);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(741, 23);
            this.SearchBox.TabIndex = 16;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortByComboBox.FormattingEnabled = true;
            this.SortByComboBox.Location = new System.Drawing.Point(27, 36);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(247, 23);
            this.SortByComboBox.TabIndex = 17;
            this.SortByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortByLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SortByLabel.Location = new System.Drawing.Point(27, 18);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(48, 15);
            this.SortByLabel.TabIndex = 18;
            this.SortByLabel.Text = "Sort By:";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SearchLabel.Location = new System.Drawing.Point(320, 18);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(43, 15);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Search";
            // 
            // FilmLibraryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.FilmDataLayoutPanel);
            this.Controls.Add(this.EditFilmButton);
            this.Controls.Add(this.AddFilmButton);
            this.Controls.Add(this.FilmLibraryListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilmLibraryViewerForm";
            this.Text = "Film Library";
            this.FilmDataLayoutPanel.ResumeLayout(false);
            this.FilmDataLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox FilmLibraryListBox;
        private Label FilmTitleLabel;
        private Label FilmTitleValue;
        private Label FilmDescriptionValue;
        private Label FilmDescriptionLabel;
        private Label FilmReleaseDateLabel;
        private Label FilmRatingValue;
        private Label FilmRatingLabel;
        private Button AddFilmButton;
        private Button EditFilmButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label FilmReleaseDateValue;
        private TableLayoutPanel FilmDataLayoutPanel;
        private TextBox SearchBox;
        private ComboBox SortByComboBox;
        private Label SortByLabel;
        private Label SearchLabel;
    }
}