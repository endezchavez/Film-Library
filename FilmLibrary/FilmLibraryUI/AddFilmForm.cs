﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibraryUI
{
    public partial class AddFilmForm : Form
    {
        public AddFilmForm()
        {
            InitializeComponent();
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;

            if(TitleTextBox)

            DateTime dt = ReleaseDateMonthCalander.SelectionStart;

            if(dt > DateTime.Today)
            {
                output = false;
            }

            return output;
        }
    }
}
