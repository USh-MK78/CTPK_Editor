namespace CTPK_Editor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CTPKEditorMain_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.CTPKData_ListBox = new System.Windows.Forms.ListBox();
            this.CTPKEditor_DataMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CTPKData_TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TGAImage_PictureBox = new System.Windows.Forms.PictureBox();
            this.CTPKData_PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTPKEditorMain_SplitContainer)).BeginInit();
            this.CTPKEditorMain_SplitContainer.Panel1.SuspendLayout();
            this.CTPKEditorMain_SplitContainer.Panel2.SuspendLayout();
            this.CTPKEditorMain_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTPKEditor_DataMainSplitContainer)).BeginInit();
            this.CTPKEditor_DataMainSplitContainer.Panel1.SuspendLayout();
            this.CTPKEditor_DataMainSplitContainer.SuspendLayout();
            this.CTPKData_TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TGAImage_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CTPKEditorMain_SplitContainer
            // 
            this.CTPKEditorMain_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTPKEditorMain_SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.CTPKEditorMain_SplitContainer.Name = "CTPKEditorMain_SplitContainer";
            // 
            // CTPKEditorMain_SplitContainer.Panel1
            // 
            this.CTPKEditorMain_SplitContainer.Panel1.Controls.Add(this.CTPKEditor_DataMainSplitContainer);
            // 
            // CTPKEditorMain_SplitContainer.Panel2
            // 
            this.CTPKEditorMain_SplitContainer.Panel2.Controls.Add(this.CTPKData_TabControl);
            this.CTPKEditorMain_SplitContainer.Size = new System.Drawing.Size(618, 434);
            this.CTPKEditorMain_SplitContainer.SplitterDistance = 206;
            this.CTPKEditorMain_SplitContainer.TabIndex = 1;
            // 
            // CTPKData_ListBox
            // 
            this.CTPKData_ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTPKData_ListBox.FormattingEnabled = true;
            this.CTPKData_ListBox.ItemHeight = 12;
            this.CTPKData_ListBox.Location = new System.Drawing.Point(0, 0);
            this.CTPKData_ListBox.Name = "CTPKData_ListBox";
            this.CTPKData_ListBox.Size = new System.Drawing.Size(206, 362);
            this.CTPKData_ListBox.TabIndex = 0;
            // 
            // CTPKEditor_DataMainSplitContainer
            // 
            this.CTPKEditor_DataMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTPKEditor_DataMainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CTPKEditor_DataMainSplitContainer.Name = "CTPKEditor_DataMainSplitContainer";
            this.CTPKEditor_DataMainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // CTPKEditor_DataMainSplitContainer.Panel1
            // 
            this.CTPKEditor_DataMainSplitContainer.Panel1.Controls.Add(this.CTPKData_ListBox);
            this.CTPKEditor_DataMainSplitContainer.Size = new System.Drawing.Size(206, 434);
            this.CTPKEditor_DataMainSplitContainer.SplitterDistance = 362;
            this.CTPKEditor_DataMainSplitContainer.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // CTPKData_TabControl
            // 
            this.CTPKData_TabControl.Controls.Add(this.tabPage1);
            this.CTPKData_TabControl.Controls.Add(this.tabPage2);
            this.CTPKData_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTPKData_TabControl.Location = new System.Drawing.Point(0, 0);
            this.CTPKData_TabControl.Name = "CTPKData_TabControl";
            this.CTPKData_TabControl.SelectedIndex = 0;
            this.CTPKData_TabControl.Size = new System.Drawing.Size(408, 434);
            this.CTPKData_TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CTPKData_PropertyGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Property";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TGAImage_PictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TGAImage_PictureBox
            // 
            this.TGAImage_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TGAImage_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.TGAImage_PictureBox.Name = "TGAImage_PictureBox";
            this.TGAImage_PictureBox.Size = new System.Drawing.Size(394, 402);
            this.TGAImage_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TGAImage_PictureBox.TabIndex = 0;
            this.TGAImage_PictureBox.TabStop = false;
            // 
            // CTPKData_PropertyGrid
            // 
            this.CTPKData_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTPKData_PropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.CTPKData_PropertyGrid.Name = "CTPKData_PropertyGrid";
            this.CTPKData_PropertyGrid.Size = new System.Drawing.Size(394, 402);
            this.CTPKData_PropertyGrid.TabIndex = 0;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 458);
            this.Controls.Add(this.CTPKEditorMain_SplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CTPK_Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CTPKEditorMain_SplitContainer.Panel1.ResumeLayout(false);
            this.CTPKEditorMain_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTPKEditorMain_SplitContainer)).EndInit();
            this.CTPKEditorMain_SplitContainer.ResumeLayout(false);
            this.CTPKEditor_DataMainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTPKEditor_DataMainSplitContainer)).EndInit();
            this.CTPKEditor_DataMainSplitContainer.ResumeLayout(false);
            this.CTPKData_TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TGAImage_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer CTPKEditorMain_SplitContainer;
        private System.Windows.Forms.SplitContainer CTPKEditor_DataMainSplitContainer;
        private System.Windows.Forms.ListBox CTPKData_ListBox;
        private System.Windows.Forms.TabControl CTPKData_TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid CTPKData_PropertyGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox TGAImage_PictureBox;
    }
}

