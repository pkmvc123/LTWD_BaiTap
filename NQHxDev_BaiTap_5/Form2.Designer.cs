namespace NQHxDev_BaiTap_5
{
    partial class frmDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocument));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsNew = new System.Windows.Forms.ToolStripButton();
            this.tlsSave = new System.Windows.Forms.ToolStripButton();
            this.tlsCmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tlsCmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tlsTextBold = new System.Windows.Forms.ToolStripButton();
            this.tlsTextItalic = new System.Windows.Forms.ToolStripButton();
            this.tlsTextUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rtbDocument = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNew,
            this.tlsSave,
            this.tlsCmbFont,
            this.tlsCmbFontSize,
            this.tlsTextBold,
            this.tlsTextItalic,
            this.tlsTextUnderline,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsNew
            // 
            this.tlsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsNew.Image = ((System.Drawing.Image)(resources.GetObject("tlsNew.Image")));
            this.tlsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsNew.Name = "tlsNew";
            this.tlsNew.Size = new System.Drawing.Size(23, 22);
            this.tlsNew.Text = "New Document";
            this.tlsNew.Click += new System.EventHandler(this.tlsNew_Click);
            // 
            // tlsSave
            // 
            this.tlsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsSave.Image = ((System.Drawing.Image)(resources.GetObject("tlsSave.Image")));
            this.tlsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsSave.Name = "tlsSave";
            this.tlsSave.Size = new System.Drawing.Size(23, 22);
            this.tlsSave.Text = "Save Document";
            this.tlsSave.Click += new System.EventHandler(this.tlsSave_Click);
            // 
            // tlsCmbFont
            // 
            this.tlsCmbFont.Name = "tlsCmbFont";
            this.tlsCmbFont.Size = new System.Drawing.Size(121, 25);
            // 
            // tlsCmbFontSize
            // 
            this.tlsCmbFontSize.Name = "tlsCmbFontSize";
            this.tlsCmbFontSize.Size = new System.Drawing.Size(121, 25);
            // 
            // tlsTextBold
            // 
            this.tlsTextBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTextBold.Image = ((System.Drawing.Image)(resources.GetObject("tlsTextBold.Image")));
            this.tlsTextBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTextBold.Name = "tlsTextBold";
            this.tlsTextBold.Size = new System.Drawing.Size(23, 22);
            this.tlsTextBold.Text = "Text Bold";
            this.tlsTextBold.Click += new System.EventHandler(this.tlsTextBold_Click);
            // 
            // tlsTextItalic
            // 
            this.tlsTextItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTextItalic.Image = ((System.Drawing.Image)(resources.GetObject("tlsTextItalic.Image")));
            this.tlsTextItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTextItalic.Name = "tlsTextItalic";
            this.tlsTextItalic.Size = new System.Drawing.Size(23, 22);
            this.tlsTextItalic.Text = "Text Italic";
            this.tlsTextItalic.Click += new System.EventHandler(this.tlsTextItalic_Click);
            // 
            // tlsTextUnderline
            // 
            this.tlsTextUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsTextUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tlsTextUnderline.Image")));
            this.tlsTextUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsTextUnderline.Name = "tlsTextUnderline";
            this.tlsTextUnderline.Size = new System.Drawing.Size(23, 22);
            this.tlsTextUnderline.Text = "Text Underline";
            this.tlsTextUnderline.Click += new System.EventHandler(this.tlsTextUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // rtbDocument
            // 
            this.rtbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocument.Location = new System.Drawing.Point(0, 25);
            this.rtbDocument.Name = "rtbDocument";
            this.rtbDocument.Size = new System.Drawing.Size(800, 425);
            this.rtbDocument.TabIndex = 1;
            this.rtbDocument.Text = "";
            // 
            // frmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDocument);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDocument";
            this.Text = "Soạn thảo vă bản";
            this.Load += new System.EventHandler(this.frmDocument_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsNew;
        private System.Windows.Forms.ToolStripButton tlsSave;
        private System.Windows.Forms.ToolStripComboBox tlsCmbFont;
        private System.Windows.Forms.ToolStripComboBox tlsCmbFontSize;
        private System.Windows.Forms.ToolStripButton tlsTextBold;
        private System.Windows.Forms.ToolStripButton tlsTextItalic;
        private System.Windows.Forms.ToolStripButton tlsTextUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtbDocument;
    }
}