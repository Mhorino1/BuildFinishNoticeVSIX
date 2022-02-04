namespace BuildFinishNoticeVSIX
{
    partial class MyUserControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectButton = new System.Windows.Forms.Button();
            this.hAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vAlignmentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transparencyUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(22, 24);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(418, 22);
            this.filePathTextBox.TabIndex = 0;
            this.filePathTextBox.Text = "No Select Image";
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(303, 56);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(137, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select Image";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // hAlignmentComboBox
            // 
            this.hAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hAlignmentComboBox.FormattingEnabled = true;
            this.hAlignmentComboBox.Location = new System.Drawing.Point(111, 32);
            this.hAlignmentComboBox.Name = "hAlignmentComboBox";
            this.hAlignmentComboBox.Size = new System.Drawing.Size(124, 23);
            this.hAlignmentComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Horizontal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vAlignmentComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hAlignmentComboBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alignment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vertical";
            // 
            // vAlignmentComboBox
            // 
            this.vAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vAlignmentComboBox.FormattingEnabled = true;
            this.vAlignmentComboBox.Location = new System.Drawing.Point(111, 68);
            this.vAlignmentComboBox.Name = "vAlignmentComboBox";
            this.vAlignmentComboBox.Size = new System.Drawing.Size(124, 23);
            this.vAlignmentComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transparency";
            // 
            // transparencyUpDown
            // 
            this.transparencyUpDown.Location = new System.Drawing.Point(137, 225);
            this.transparencyUpDown.Name = "transparencyUpDown";
            this.transparencyUpDown.Size = new System.Drawing.Size(120, 22);
            this.transparencyUpDown.TabIndex = 7;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transparencyUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.filePathTextBox);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(458, 356);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox hAlignmentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox vAlignmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown transparencyUpDown;
    }
}
