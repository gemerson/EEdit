namespace EEdit
{
    partial class EnvEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvEditor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NewVarButton = new System.Windows.Forms.Button();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.RestoreVarButton = new System.Windows.Forms.Button();
            this.RemoveVarButton = new System.Windows.Forms.Button();
            this.VarList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueEditor1 = new EEdit.ValueEditor();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NewVarButton);
            this.splitContainer1.Panel1.Controls.Add(this.RestoreVarButton);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveVarButton);
            this.splitContainer1.Panel1.Controls.Add(this.VarList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.valueEditor1);
            this.splitContainer1.Size = new System.Drawing.Size(722, 413);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // NewVarButton
            // 
            this.NewVarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewVarButton.ImageKey = "Add.ico";
            this.NewVarButton.ImageList = this.imageList16;
            this.NewVarButton.Location = new System.Drawing.Point(3, 386);
            this.NewVarButton.Name = "NewVarButton";
            this.NewVarButton.Size = new System.Drawing.Size(24, 24);
            this.NewVarButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.NewVarButton, "Add");
            this.NewVarButton.UseVisualStyleBackColor = true;
            this.NewVarButton.Click += new System.EventHandler(this.NewVarButton_Click);
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32.Images.SetKeyName(0, "Bottom.ico");
            this.imageList32.Images.SetKeyName(1, "CopyToClipboard.ico");
            this.imageList32.Images.SetKeyName(2, "Down.ico");
            this.imageList32.Images.SetKeyName(3, "RedX.ico");
            this.imageList32.Images.SetKeyName(4, "Top.ico");
            this.imageList32.Images.SetKeyName(5, "Up.ico");
            this.imageList32.Images.SetKeyName(6, "Save.ico");
            this.imageList32.Images.SetKeyName(7, "Add.ico");
            this.imageList32.Images.SetKeyName(8, "Restore.ico");
            this.imageList32.Images.SetKeyName(9, "SaveToFile.ico");
            // 
            // RestoreVarButton
            // 
            this.RestoreVarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreVarButton.Enabled = false;
            this.RestoreVarButton.ImageKey = "Restore.ico";
            this.RestoreVarButton.ImageList = this.imageList16;
            this.RestoreVarButton.Location = new System.Drawing.Point(63, 386);
            this.RestoreVarButton.Name = "RestoreVarButton";
            this.RestoreVarButton.Size = new System.Drawing.Size(24, 24);
            this.RestoreVarButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.RestoreVarButton, "Restore");
            this.RestoreVarButton.UseVisualStyleBackColor = true;
            this.RestoreVarButton.Click += new System.EventHandler(this.RestoreVariable_Click);
            // 
            // RemoveVarButton
            // 
            this.RemoveVarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveVarButton.Enabled = false;
            this.RemoveVarButton.ImageKey = "RedX.ico";
            this.RemoveVarButton.ImageList = this.imageList16;
            this.RemoveVarButton.Location = new System.Drawing.Point(33, 386);
            this.RemoveVarButton.Name = "RemoveVarButton";
            this.RemoveVarButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveVarButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.RemoveVarButton, "Delete");
            this.RemoveVarButton.UseVisualStyleBackColor = true;
            this.RemoveVarButton.Click += new System.EventHandler(this.RemoveVarButton_Click);
            // 
            // VarList
            // 
            this.VarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.VarList.FullRowSelect = true;
            this.VarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.VarList.HideSelection = false;
            this.VarList.LabelWrap = false;
            this.VarList.Location = new System.Drawing.Point(0, 3);
            this.VarList.MultiSelect = false;
            this.VarList.Name = "VarList";
            this.VarList.Size = new System.Drawing.Size(238, 377);
            this.VarList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.VarList.TabIndex = 0;
            this.VarList.UseCompatibleStateImageBehavior = false;
            this.VarList.View = System.Windows.Forms.View.Details;
            this.VarList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.VarList_AfterLabelEdit);
            this.VarList.SelectedIndexChanged += new System.EventHandler(this.VariableList_SelectedIndexChanged);
            this.VarList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VarList_KeyDown);
            this.VarList.Resize += new System.EventHandler(this.List_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 147;
            // 
            // valueEditor1
            // 
            this.valueEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueEditor1.EnvironmentVariable = null;
            this.valueEditor1.Location = new System.Drawing.Point(0, 0);
            this.valueEditor1.Name = "valueEditor1";
            this.valueEditor1.Size = new System.Drawing.Size(480, 413);
            this.valueEditor1.TabIndex = 0;
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16.Images.SetKeyName(0, "Bottom.ico");
            this.imageList16.Images.SetKeyName(1, "CopyToClipboard.ico");
            this.imageList16.Images.SetKeyName(2, "Down.ico");
            this.imageList16.Images.SetKeyName(3, "RedX.ico");
            this.imageList16.Images.SetKeyName(4, "Top.ico");
            this.imageList16.Images.SetKeyName(5, "Up.ico");
            this.imageList16.Images.SetKeyName(6, "Save.ico");
            this.imageList16.Images.SetKeyName(7, "Add.ico");
            this.imageList16.Images.SetKeyName(8, "Restore.ico");
            this.imageList16.Images.SetKeyName(9, "SaveToFile.ico");
            // 
            // ResetButton
            // 
            this.ResetButton.ImageKey = "Restore.ico";
            this.ResetButton.ImageList = this.imageList32;
            this.ResetButton.Location = new System.Drawing.Point(99, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(42, 39);
            this.ResetButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.ResetButton, "Reset to Initial State");
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.ImageKey = "SaveToFile.ico";
            this.ExportButton.ImageList = this.imageList32;
            this.ExportButton.Location = new System.Drawing.Point(51, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(42, 39);
            this.ExportButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ExportButton, "Export to File");
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ImageIndex = 6;
            this.SaveButton.ImageList = this.imageList32;
            this.SaveButton.Location = new System.Drawing.Point(3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(42, 39);
            this.SaveButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.SaveButton, "Save Environment Variables");
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EnvEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(484, 307);
            this.Name = "EnvEditor";
            this.Size = new System.Drawing.Size(722, 461);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView VarList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button RemoveVarButton;
        private System.Windows.Forms.Button RestoreVarButton;
        private System.Windows.Forms.Button NewVarButton;
        private ValueEditor valueEditor1;

    }
}
