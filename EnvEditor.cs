/*
EEdit - A Windows Environment Editor
Copyright (C) 2011  Mirozell

Website: https://github.com/Mirozell/EEdit

EEdit is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

EEdit is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with EEdit.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using EEdit.Environment;
using System.Collections.Generic;

namespace EEdit
{
    public partial class EnvEditor : UserControl
    {
        private const string DefaultVariable = "path";

        private EnvModel environment;

        public EnvEditor()
        {
            InitializeComponent();
        }

        #region Form Events

        private void VariableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.VarList.SelectedItems.Count > 0)
            {
                EnvVariable value;
                if (environment.Variables.TryGetValue(VarList.SelectedItems[0].Text, out value))
                {
                    this.valueEditor1.EnvironmentVariable = value;
                }
            }
        }

        private void List_SizeChanged(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            list.Columns[0].Width = list.Width - 22; // 22 = slightly wider than the vertical scroll bar that appears
        }

        private void VarList_KeyDown(object sender, KeyEventArgs e)
        {
            if (VarList.SelectedIndices.Count == 0) return;

            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RemoveSelectedVariable();
                    break;
            }
        }

        private void VarList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // handle the assignment manually, so LoadValues gets the new variable name
            e.CancelEdit = true;
            VarList.LabelEdit = false;

            if (e.Label == null || string.IsNullOrWhiteSpace(e.Label)) return;

            // if the variable already exists, select that one instead.
            ListViewItem existingItem = GetVariableItem(e.Label);
            if (existingItem != null)
            {
                existingItem.Selected = true;
                return;
            }

            EnvVariable value = environment.AddVariable(e.Label);

            ListViewItem item = VarList.Items[e.Item];
            item.Text = value.Variable;

            VarList.Sort();
            item.EnsureVisible();
        }

        private void RemoveVarButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedVariable();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportEnvironment();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LoadEnvironment(environment.EnvTarget);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                environment.Save();
                RemoveDeletedVariables();
                UpdateVarStateIndicators();
            }
            catch (SecurityException)
            {
                MessageBox.Show("Permission denied. Unable to save.", "Security Error");
            }
        }

        private void RestoreVariable_Click(object sender, EventArgs e)
        {
            RestoreSelectedVariable();
        }

        private void NewVarButton_Click(object sender, EventArgs e)
        {
            AddVariable();
        }

        private void AddVariable()
        {
            ListViewItem item = new ListViewItem();
            VarList.Items.Add(item);
            item.Selected = true;
            item.EnsureVisible();

            VarList.LabelEdit = true;
            item.BeginEdit();
        }
        #endregion

        private void RemoveDeletedVariables()
        {
            foreach (ListViewItem item in VarList.Items)
            {
                if (!environment.Variables.ContainsKey(item.Text))
                    item.Remove();
            }
        }

        private void ExportEnvironment()
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filepath = dlg.FileName;
                environment.Export(filepath);
            }
        }

        private void RemoveSelectedVariable()
        {
            ListViewItem item = VarList.SelectedItems[0];

            environment.RemoveVariable(item.Text);

            UpdateVarStateIndicators();
            UpdateButtonState();
        }

        private void RestoreSelectedVariable()
        {
            ListViewItem item = VarList.SelectedItems[0];
            environment.RestoreVariable(item.Text);

            UpdateButtonState();
        }

        public void LoadEnvironment(EnvironmentVariableTarget target)
        {
            VarList.Items.Clear();

            environment = new EnvModel(target);

            foreach (string variable in environment.Variables.Keys)
            {
                VarList.Items.Add(variable);
            }

            SelectVariable(DefaultVariable);
        }

        private void SelectVariable(string variable)
        {
            ListViewItem item = GetVariableItem(variable);
            if (item != null) item.Selected = true;
        }

        private ListViewItem GetVariableItem(string variable)
        {
            for (int i = 0; i < environment.Variables.Count; i++)
            {
                ListViewItem item = VarList.Items[i];
                if (item.Text.ToLower() == variable)
                {
                    return item;
                }
            }

            return null;
        }

        private void UpdateButtonState() 
        {
            ListViewItem item = VarList.SelectedItems[0];
            EnvVariable value = environment.Variables[item.Text];

            RestoreVarButton.Enabled = value.Deleted;
            RemoveVarButton.Enabled = !value.Deleted;

            this.valueEditor1.UpdateButtonState();
        }

        private void UpdateVarStateIndicators()
        {
            foreach (ListViewItem item in VarList.Items)
            {
                EnvVariable value = environment.Variables[item.Text];
                item.BackColor = GetIndicatorColor(value);
            }
        }

        private Color GetIndicatorColor(EnvVariable value)
        {
            return (value.Deleted) ? Color.Pink :
                   (value.Added) ? Color.LightGreen :
                   (value.Edited) ? Color.LightBlue :
                   Color.White;
        }
    }
}
