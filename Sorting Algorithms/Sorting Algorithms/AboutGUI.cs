﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class AboutGUI : Form
    {
        public AboutGUI()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblEmail.Text);
        }
    }
}
