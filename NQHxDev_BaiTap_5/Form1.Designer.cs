namespace NQHxDev_BaiTap_5
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsFontDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsSaveAllDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsSystem,
            this.tlsFontDialog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsSystem
            // 
            this.tlsSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNewDoc,
            this.tlsOpenDoc,
            this.toolStripSeparator1,
            this.tlsSaveAllDoc,
            this.tlsExit});
            this.tlsSystem.Name = "tlsSystem";
            this.tlsSystem.Size = new System.Drawing.Size(71, 20);
            this.tlsSystem.Text = "Hệ Thống";
            // 
            // tlsFontDialog
            // 
            this.tlsFontDialog.Name = "tlsFontDialog";
            this.tlsFontDialog.Size = new System.Drawing.Size(75, 20);
            this.tlsFontDialog.Text = "Định Dạng";
            this.tlsFontDialog.Click += new System.EventHandler(this.tlsFontDialog_Click);
            // 
            // tlsNewDoc
            // 
            this.tlsNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("tlsNewDoc.Image")));
            this.tlsNewDoc.Name = "tlsNewDoc";
            this.tlsNewDoc.Size = new System.Drawing.Size(180, 22);
            this.tlsNewDoc.Text = "Tạo văn bản mới";
            this.tlsNewDoc.Click += new System.EventHandler(this.tlsNewDoc_Click);
            // 
            // tlsOpenDoc
            // 
            this.tlsOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("tlsOpenDoc.Image")));
            this.tlsOpenDoc.Name = "tlsOpenDoc";
            this.tlsOpenDoc.Size = new System.Drawing.Size(180, 22);
            this.tlsOpenDoc.Text = "Mở tệp tin";
            this.tlsOpenDoc.Click += new System.EventHandler(this.tlsOpenDoc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tlsSaveAllDoc
            // 
            this.tlsSaveAllDoc.Image = ((System.Drawing.Image)(resources.GetObject("tlsSaveAllDoc.Image")));
            this.tlsSaveAllDoc.Name = "tlsSaveAllDoc";
            this.tlsSaveAllDoc.Size = new System.Drawing.Size(180, 22);
            this.tlsSaveAllDoc.Text = "Lưu tất cả tệp tin";
            this.tlsSaveAllDoc.Click += new System.EventHandler(this.tlsSaveAllDoc_Click);
            // 
            // tlsExit
            // 
            this.tlsExit.Name = "tlsExit";
            this.tlsExit.Size = new System.Drawing.Size(180, 22);
            this.tlsExit.Text = "Thoát";
            this.tlsExit.Click += new System.EventHandler(this.tlsExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NQH Dev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsSystem;
        private System.Windows.Forms.ToolStripMenuItem tlsNewDoc;
        private System.Windows.Forms.ToolStripMenuItem tlsOpenDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tlsSaveAllDoc;
        private System.Windows.Forms.ToolStripMenuItem tlsExit;
        private System.Windows.Forms.ToolStripMenuItem tlsFontDialog;
    }
}

