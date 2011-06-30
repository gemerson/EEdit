using System;
using System.Windows.Forms;
using EEdit.Environment;
using System.Collections.Generic;

namespace EEdit
{
    public partial class ValueEditor : UserControl
    {
        private EnvVariable environmentVariable;
        private bool isMouseDown;

        public ValueEditor()
        {
            InitializeComponent();
        }

        public EnvVariable EnvironmentVariable 
        {
            get
            {
                return this.environmentVariable;
            }

            set
            {
                if (this.environmentVariable != null)
                {
                    this.DisableCollectionChangedEvent();
                }

                this.environmentVariable = value;

                if (this.environmentVariable != null)
                {
                    this.LoadValues();
                    this.EnableCollectionChangedEvent();
                }
            }
        }

        public void UpdateButtonState()
        {
            bool selection = (EntryList.SelectedIndices.Count > 0);

            TopButton.Enabled = selection && EntryList.SelectedIndices[0] > 0;
            UpButton.Enabled = selection && EntryList.SelectedIndices[0] > 0;
            DownButton.Enabled = selection && EntryList.SelectedIndices[0] < EntryList.Items.Count - 1;
            BottomButton.Enabled = selection && EntryList.SelectedIndices[0] < EntryList.Items.Count - 1;
            RemoveEntryButton.Enabled = selection;
        }

        public void AddEntry()
        {
            ListViewItem item = new ListViewItem();
            EntryList.Items.Add(item);
            item.EnsureVisible();

            EntryList.LabelEdit = true;
            item.BeginEdit();
        }

        public void RemoveSelectedEntry()
        {
            this.DisableCollectionChangedEvent();

            for (int i = this.EntryList.SelectedItems.Count - 1; i > -1; i--)
            {
                ListViewItem item = this.EntryList.SelectedItems[i];
                this.EnvironmentVariable.RemoveEntry(item.Index);
                this.EntryList.Items.Remove(item);
            }

            this.EnableCollectionChangedEvent();
        }

        private void CopyValueButton_Click(object sender, EventArgs e)
        {
            this.ValueDisplay.Focus();
            this.ValueDisplay.SelectAll();
            Clipboard.SetText(ValueDisplay.Text);
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            this.DisableCollectionChangedEvent();

            for (int i = 0; i < this.EntryList.SelectedItems.Count; i++)
            { 
                ListViewItem item = this.EntryList.SelectedItems[i];
                this.EnvironmentVariable.MoveEntry(item.Index, i);
                this.EntryList.Items.Remove(item);
                this.EntryList.Items.Insert(i, item);
            }

            if (this.EntryList.SelectedItems.Count > 0)
            {
                this.EntryList.SelectedItems[0].EnsureVisible();
            }

            this.EnableCollectionChangedEvent();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            this.DisableCollectionChangedEvent();

            int nextTopIndex = -1;

            for (int i = 0; i < this.EntryList.SelectedItems.Count; i++)
            {
                ListViewItem item = this.EntryList.SelectedItems[i];

                if (item.Index > 0
                    && item.Index > nextTopIndex)
                {
                    nextTopIndex = item.Index - 1;

                    this.EnvironmentVariable.MoveEntry(item.Index, nextTopIndex);
                    this.EntryList.Items.Remove(item);
                    this.EntryList.Items.Insert(nextTopIndex, item);
                }
            }

            this.EnableCollectionChangedEvent();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            this.DisableCollectionChangedEvent();

            for (int i = this.EntryList.SelectedItems.Count - 1; i > -1; i--)
            {
                ListViewItem item = this.EntryList.SelectedItems[i];

                if (item.Index < this.EntryList.Items.Count - 1)
                {
                    int newIndex = item.Index + 1;
                    this.EnvironmentVariable.MoveEntry(item.Index, newIndex);
                    this.EntryList.Items.Remove(item);
                    this.EntryList.Items.Insert(newIndex, item);
                }
            }

            this.EnableCollectionChangedEvent();
        }

        private void BottomButton_Click(object sender, EventArgs e)
        {
            this.DisableCollectionChangedEvent();

            int fromBottom = 0;
            for (int i = this.EntryList.SelectedItems.Count - 1; i > -1; i--)
            {
                ListViewItem item = this.EntryList.SelectedItems[i];

                this.EnvironmentVariable.MoveEntry(i, this.EntryList.Items.Count - fromBottom - 1);
                this.EntryList.Items.Remove(item);
                this.EntryList.Items.Insert(this.EntryList.Items.Count - fromBottom, item);

                fromBottom += 1;
            }

            if (this.EntryList.SelectedItems.Count > 0)
            {
                this.EntryList.SelectedItems[this.EntryList.SelectedItems.Count - 1].EnsureVisible();
            }

            this.EnableCollectionChangedEvent();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            this.AddEntry();
        }

        private void RemoveEntryButton_Click(object sender, EventArgs e)
        {
            this.RemoveSelectedEntry();
        }

        private void EntryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.EntryList.SelectedIndices.Count > 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        RemoveSelectedEntry();
                        break;

                    case Keys.Enter:
                        ListViewItem item = EntryList.SelectedItems[0];
                        item.BeginEdit();
                        break;
                }
            }
        }

        private void EntryList_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // handle the update manually.  The list will refresh when value changes.
            e.CancelEdit = true;
            EntryList.LabelEdit = false;

            if (e.Label != null || !string.IsNullOrWhiteSpace(e.Label))
            {
                if (e.Item == this.EnvironmentVariable.EntryCount)
                {
                    this.EnvironmentVariable.AddEntry(e.Label);
                }
                else
                {
                    this.EnvironmentVariable.UpdateEntry(e.Item, e.Label);
                }
            }
        }

        private void EntryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateButtonState();
        }

        private void ValueDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            this.EntryList.SelectedItems.Clear();
            this.isMouseDown = true;
            this.SelectEnvironmentVariableInValueDisplay();
        }

        private void ValueDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            this.SelectEnvironmentVariableInValueDisplay();
        }

        private void EnvironmentVariable_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            LoadValues();

            if (e.NewStartingIndex >= 0)
            {
                EntryList.Items[e.NewStartingIndex].Selected = true;
            }
        }

        private void DisableCollectionChangedEvent()
        {
            this.EnvironmentVariable.CollectionChanged -= new System.Collections.Specialized.NotifyCollectionChangedEventHandler(EnvironmentVariable_CollectionChanged);
        }

        private void EnableCollectionChangedEvent()
        {
            this.EnvironmentVariable.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(EnvironmentVariable_CollectionChanged);
        }

        private void LoadValues()
        {
            EntryList.Items.Clear();

            ValueDisplay.Text = this.EnvironmentVariable.FullValue;
            foreach (string entry in this.EnvironmentVariable.GetEntries())
            {
                ListViewItem item = new ListViewItem(entry);
                EntryList.Items.Add(item);
            }

            UpdateButtonState();
            this.EntryList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void SelectEnvironmentVariableInValueDisplay()
        {
            this.EntryList.SelectedItems.Clear();
            string[] environmentVariables = this.GetEnvironmentVariablesFromString(this.ValueDisplay.Text, this.ValueDisplay.SelectionStart, this.ValueDisplay.SelectionLength);

            foreach (string variable in environmentVariables)
            {
                int index = 0;

                while (index < this.EntryList.Items.Count)
                {
                    ListViewItem item = this.EntryList.FindItemWithText(variable, false, index);
                    if (item != null
                        && item.Text == variable)
                    {
                        item.Selected = true;
                        this.EntryList.EnsureVisible(item.Index);
                        break;
                    }

                    index = item.Index + 1;
                }
            }
        }

        private string[] GetEnvironmentVariablesFromString(string variables, int beginIndex, int length)
        {
            List<string> individualVariables = new List<string>();
            string variable = string.Empty;

            int beginningOfVariable = variables.Substring(0, beginIndex).LastIndexOf(';') + 1;
            int endOfVariable = variables.Substring(beginIndex + length).IndexOf(';');
            endOfVariable += beginIndex + length;

            individualVariables.AddRange(variables.Substring(beginningOfVariable, endOfVariable - beginningOfVariable).Split(';'));
            return individualVariables.ToArray();
        }

        private void ValueDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            this.isMouseDown = false;
        }

        private void ValueDisplay_MouseLeave(object sender, EventArgs e)
        {
            this.isMouseDown = false;
        }

        private void ValueDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.SelectEnvironmentVariableInValueDisplay();
            }
        }
    }
}
