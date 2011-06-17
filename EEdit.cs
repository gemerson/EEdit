﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace EEdit
{
    public partial class EEditForm : Form
    {
        public EEditForm()
        {
            InitializeComponent();
        }

        private void EEdit_Load(object sender, EventArgs e)
        {
            MachineEditor.LoadEnvironment(EnvironmentVariableTarget.Machine);
            UserEditor.LoadEnvironment(EnvironmentVariableTarget.User);
        }
    }
}
