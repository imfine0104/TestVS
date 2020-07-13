using System;
using System.Windows.Forms;

namespace ConfigAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("ページを閉じてもよろしいでしょうか。","確認", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtGroupId.Text.Equals("") || txtCategory.Text.Equals(""))
            {
                MessageBox.Show("情報を入力してください", "警報", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbAdd.Checked)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No Add", "警報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtPath.Text = fbd.SelectedPath;
            //test
        }
    }
}
