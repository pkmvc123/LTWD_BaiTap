using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQHxDev_BaiTap_5
{
    public partial class frmDocument : Form
    {
        private string currentFilePath = null;

        public frmDocument()
        {
            InitializeComponent();
            this.tlsCmbFont.SelectedIndexChanged += (s, e) => tlsCmbFont_SelectedIndexChanged(s, e);
            this.tlsCmbFontSize.SelectedIndexChanged += (s, e) => tlsCmbFontSize_SelectedIndexChanged(s, e);
        }

        public void GetFontDialog(FontDialog fontDlg)
        {
            rtbDocument.SelectionFont = fontDlg.Font;
            rtbDocument.SelectionColor = fontDlg.Color;
            tlsCmbFont.SelectedItem = fontDlg.Font.Name;
            tlsCmbFontSize.SelectedItem = (int)fontDlg.Font.Size;
        }

        public void OpenFile(string filePath)
        {
            if (System.IO.Path.GetExtension(filePath).ToLower() == ".rtf")
            {
                rtbDocument.LoadFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                rtbDocument.Text = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            }

            currentFilePath = filePath;
            Font font = rtbDocument.SelectionFont ?? rtbDocument.Font ?? new Font("Tahoma", 14);
            tlsCmbFont.SelectedItem = font.Name;
            tlsCmbFontSize.SelectedItem = (int)font.Size;
        }

        public void SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveDlg = new SaveFileDialog())
                {
                    saveDlg.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
                    saveDlg.Title = "Save Document";
                    saveDlg.DefaultExt = "txt";
                    saveDlg.AddExtension = true;

                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        string ext = System.IO.Path.GetExtension(saveDlg.FileName).ToLower();

                        if (ext == ".rtf")
                        {
                            rtbDocument.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            System.IO.File.WriteAllText(saveDlg.FileName, rtbDocument.Text, Encoding.UTF8);
                        }

                        currentFilePath = saveDlg.FileName;
                    }
                }
            }
            else
            {
                string ext = System.IO.Path.GetExtension(currentFilePath).ToLower();

                if (ext == ".rtf")
                {
                    rtbDocument.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    System.IO.File.WriteAllText(currentFilePath, rtbDocument.Text, Encoding.UTF8);
                }
            }
        }

        private void tlsCmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tlsCmbFont.SelectedItem == null) return;

            string fontName = tlsCmbFont.SelectedItem.ToString();
            float fontSize = rtbDocument.SelectionFont?.Size ?? rtbDocument.Font?.Size ?? 14f;
            FontStyle style = rtbDocument.SelectionFont?.Style ?? rtbDocument.Font?.Style ?? FontStyle.Regular;

            Font newFont = new Font(fontName, fontSize, style);

            if (rtbDocument.SelectionLength > 0)
                rtbDocument.SelectionFont = newFont;
            else
            {
                rtbDocument.Font = newFont;
                rtbDocument.SelectionFont = newFont;
            }
        }

        private void tlsCmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tlsCmbFontSize.SelectedItem == null) return;

            float fontSize = float.Parse(tlsCmbFontSize.SelectedItem.ToString());
            string fontName = rtbDocument.SelectionFont?.Name ?? rtbDocument.Font?.Name ?? "Tahoma";
            FontStyle style = rtbDocument.SelectionFont?.Style ?? rtbDocument.Font?.Style ?? FontStyle.Regular;

            Font newFont = new Font(fontName, fontSize, style);

            if (rtbDocument.SelectionLength > 0)
                rtbDocument.SelectionFont = newFont;
            else
            {
                rtbDocument.Font = newFont;
                rtbDocument.SelectionFont = newFont;
            }
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                tlsCmbFont.Items.Add(font.Name);
            }

            tlsCmbFont.SelectedItem = "Tahoma";

            int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in fontSizes)
            {
                tlsCmbFontSize.Items.Add(size);
            }
            tlsCmbFontSize.SelectedItem = 14;

            rtbDocument.Font = new Font("Tahoma", 14);
            rtbDocument.SelectionFont = rtbDocument.Font;
        }

        private void tlsNew_Click(object sender, EventArgs e)
        {
            rtbDocument.Clear();
            rtbDocument.Font = new Font("Tahoma", 14);
            rtbDocument.SelectionFont = rtbDocument.Font;
            currentFilePath = null;

            tlsCmbFont.SelectedItem = "Tahoma";
            tlsCmbFontSize.SelectedItem = 14;
        }

        private void tlsSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
            MessageBox.Show("File đã được lưu thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToggleStyle(FontStyle flag)
        {
            Font current = rtbDocument.SelectionFont ?? rtbDocument.Font ?? new Font("Tahoma", 14);
            FontStyle newStyle = current.Style.HasFlag(flag) ? current.Style & ~flag : current.Style | flag;
            Font newFont = new Font(current.FontFamily, current.Size, newStyle);

            if (rtbDocument.SelectionLength > 0)
                rtbDocument.SelectionFont = newFont;
            else
            {
                rtbDocument.Font = newFont;
                rtbDocument.SelectionFont = newFont;
            }
        }

        private void tlsTextBold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void tlsTextItalic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void tlsTextUnderline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }
    }
}
