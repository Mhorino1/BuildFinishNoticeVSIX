using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildFinishNoticeVSIX;

namespace BuildFinishNoticeVSIX
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        internal BackImageVSIXPackage.BgSettingPage optionsPage;

        public void Initialize()
        {
        }

        private void filePathTextBox_Leave(object sender, EventArgs e)
        {
            optionsPage.filePathString = filePathTextBox.Text;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if( DialogResult.OK != this.openImageDialog.ShowDialog() )
            {
                return;
            }

            this.filePathTextBox.Text = this.openImageDialog.FileName;
        }
    }
}
