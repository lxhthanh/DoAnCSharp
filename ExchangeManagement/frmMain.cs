﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeManagement
{
    public partial class frmMain : Form
    {
        public int UserID;

        public frmMain()
        {
            InitializeComponent();
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList fUserList = frmUserList.GetInstance();
            if (!fUserList.Visible)
            {
                fUserList.MdiParent = this;
                fUserList.Show();
                fUserList.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fUserList.BringToFront();
            }
            
        }
    }
}
