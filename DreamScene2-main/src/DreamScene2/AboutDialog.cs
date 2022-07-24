﻿using System;
using System.Windows.Forms;

namespace DreamScene2
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            lblVersion.Text = "Version " + Constant.Version;
            this.Icon = DreamScene2.Properties.Resources.AppIcon;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Helper.OpenLink("https://github.com/he55/DreamScene2");
        }
    }
}
