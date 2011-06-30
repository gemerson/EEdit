namespace EEdit
{
    partial class ValueEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValueEditor));
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.RemoveEntryButton = new System.Windows.Forms.Button();
            this.BottomButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.TopButton = new System.Windows.Forms.Button();
            this.CopyValueButton = new System.Windows.Forms.Button();
            this.ValueDisplay = new System.Windows.Forms.TextBox();
            this.EntryList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEntryButton.Enabled = false;
            this.AddEntryButton.ImageIndex = 7;
            this.AddEntryButton.ImageList = this.imageList16;
            this.AddEntryButton.Location = new System.Drawing.Point(426, 231);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(24, 24);
            this.AddEntryButton.TabIndex = 18;
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
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
            // RemoveEntryButton
            // 
            this.RemoveEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEntryButton.Enabled = false;
            this.RemoveEntryButton.ImageIndex = 3;
            this.RemoveEntryButton.ImageList = this.imageList16;
            this.RemoveEntryButton.Location = new System.Drawing.Point(426, 261);
            this.RemoveEntryButton.Name = "RemoveEntryButton";
            this.RemoveEntryButton.Size = new System.Drawing.Size(24, 24);
            this.RemoveEntryButton.TabIndex = 17;
            this.RemoveEntryButton.UseVisualStyleBackColor = true;
            this.RemoveEntryButton.Click += new System.EventHandler(this.RemoveEntryButton_Click);
            // 
            // BottomButton
            // 
            this.BottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomButton.Enabled = false;
            this.BottomButton.ImageIndex = 0;
            this.BottomButton.ImageList = this.imageList16;
            this.BottomButton.Location = new System.Drawing.Point(426, 151);
            this.BottomButton.Name = "BottomButton";
            this.BottomButton.Size = new System.Drawing.Size(24, 24);
            this.BottomButton.TabIndex = 16;
            this.BottomButton.UseVisualStyleBackColor = true;
            this.BottomButton.Click += new System.EventHandler(this.BottomButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.Enabled = false;
            this.DownButton.ImageIndex = 2;
            this.DownButton.ImageList = this.imageList16;
            this.DownButton.Location = new System.Drawing.Point(426, 121);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(24, 24);
            this.DownButton.TabIndex = 15;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpButton.Enabled = false;
            this.UpButton.ImageIndex = 5;
            this.UpButton.ImageList = this.imageList16;
            this.UpButton.Location = new System.Drawing.Point(426, 60);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(24, 24);
            this.UpButton.TabIndex = 14;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // TopButton
            // 
            this.TopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopButton.Enabled = false;
            this.TopButton.ImageIndex = 4;
            this.TopButton.ImageList = this.imageList16;
            this.TopButton.Location = new System.Drawing.Point(426, 30);
            this.TopButton.Name = "TopButton";
            this.TopButton.Size = new System.Drawing.Size(24, 24);
            this.TopButton.TabIndex = 13;
            this.TopButton.UseVisualStyleBackColor = true;
            this.TopButton.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // CopyValueButton
            // 
            this.CopyValueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyValueButton.ImageIndex = 1;
            this.CopyValueButton.ImageList = this.imageList16;
            this.CopyValueButton.Location = new System.Drawing.Point(426, 3);
            this.CopyValueButton.Name = "CopyValueButton";
            this.CopyValueButton.Size = new System.Drawing.Size(24, 24);
            this.CopyValueButton.TabIndex = 12;
            this.CopyValueButton.UseVisualStyleBackColor = true;
            this.CopyValueButton.Click += new System.EventHandler(this.CopyValueButton_Click);
            // 
            // ValueDisplay
            // 
            this.ValueDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueDisplay.Location = new System.Drawing.Point(2, 0);
            this.ValueDisplay.Name = "ValueDisplay";
            this.ValueDisplay.ReadOnly = true;
            this.ValueDisplay.Size = new System.Drawing.Size(418, 20);
            this.ValueDisplay.TabIndex = 11;
            this.ValueDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValueDisplay_KeyDown);
            this.ValueDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ValueDisplay_MouseDown);
            this.ValueDisplay.MouseLeave += new System.EventHandler(this.ValueDisplay_MouseLeave);
            this.ValueDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ValueDisplay_MouseMove);
            this.ValueDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ValueDisplay_MouseUp);
            // 
            // EntryList
            // 
            this.EntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.EntryList.FullRowSelect = true;
            this.EntryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.EntryList.HideSelection = false;
            this.EntryList.LabelEdit = true;
            this.EntryList.LabelWrap = false;
            this.EntryList.Location = new System.Drawing.Point(3, 30);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(417, 281);
            this.EntryList.TabIndex = 10;
            this.EntryList.UseCompatibleStateImageBehavior = false;
            this.EntryList.View = System.Windows.Forms.View.Details;
            this.EntryList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.EntryList_AfterLabelEdit);
            this.EntryList.SelectedIndexChanged += new System.EventHandler(this.EntryList_SelectedIndexChanged);
            this.EntryList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryList_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 303;
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
            // ValueEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddEntryButton);
            this.Controls.Add(this.RemoveEntryButton);
            this.Controls.Add(this.BottomButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.TopButton);
            this.Controls.Add(this.CopyValueButton);
            this.Controls.Add(this.ValueDisplay);
            this.Controls.Add(this.EntryList);
            this.Name = "ValueEditor";
            this.Size = new System.Drawing.Size(453, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEntryButton;
        private System.Windows.Forms.Button RemoveEntryButton;
        private System.Windows.Forms.Button BottomButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button TopButton;
        private System.Windows.Forms.Button CopyValueButton;
        private System.Windows.Forms.TextBox ValueDisplay;
        private System.Windows.Forms.ListView EntryList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
