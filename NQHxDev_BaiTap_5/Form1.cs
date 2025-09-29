using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NQHxDev_BaiTap_5
{
    public partial class frmMain : Form
    {
        private frmDocument frmDocument;

        public frmMain()
        {
            InitializeComponent();
        }

        private void tlsNewDoc_Click(object sender, EventArgs e)
        {
            var formDoc = new frmDocument();
            formDoc.MdiParent = this;
            formDoc.Show();
        }

        private void tlsFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;

            fontDlg.Font = new Font("Tahoma", 14);

            if (fontDlg.ShowDialog() != DialogResult.Cancel && frmDocument != null)
            {
                frmDocument.GetFontDialog(fontDlg);
            }
        }

        private void tlsOpenDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;

                if (frmDocument == null || frmDocument.IsDisposed)
                {
                    var document = new frmDocument();
                    document.MdiParent = this;
                    document.Show();
                    document.OpenFile(filePath);
                }
            }
        }

        private void tlsSaveAllDoc_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmDocument doc)
                {
                    doc.SaveDocument();
                }
            }

            MessageBox.Show("Đã lưu tất cả tài liệu đang mở!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlsExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
