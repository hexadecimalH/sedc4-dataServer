﻿using DataBrowser.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBrowser
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        internal ConnectionData GetConnectionData()
        {
            var result = new ConnectionData
            {
                ServerName = txtServer.Text,
                AuthType = (cbxAuthType.SelectedIndex == 0) ? AuthenticationType.Windows : AuthenticationType.SqlServer,
                Username = txtUserName.Text,
                Password = txtPassword.Text
            };
            return result;
        }
    }
}
