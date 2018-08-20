namespace Bindings
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GUIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GUIDValueLabel = new System.Windows.Forms.Label();
            this.NameValueTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AgeValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GUIDLabel
            // 
            this.GUIDLabel.Location = new System.Drawing.Point(29, 30);
            this.GUIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GUIDLabel.Name = "GUIDLabel";
            this.GUIDLabel.Size = new System.Drawing.Size(89, 20);
            this.GUIDLabel.TabIndex = 0;
            this.GUIDLabel.Text = "GUID：";
            this.GUIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(29, 66);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(89, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "姓名：";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(29, 102);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(89, 20);
            this.BirthdayLabel.TabIndex = 2;
            this.BirthdayLabel.Text = "生日：";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AgeLabel
            // 
            this.AgeLabel.Location = new System.Drawing.Point(29, 138);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(89, 20);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "年龄：";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GUIDValueLabel
            // 
            this.GUIDValueLabel.Location = new System.Drawing.Point(126, 30);
            this.GUIDValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GUIDValueLabel.Name = "GUIDValueLabel";
            this.GUIDValueLabel.Size = new System.Drawing.Size(223, 20);
            this.GUIDValueLabel.TabIndex = 4;
            this.GUIDValueLabel.Text = "XXXX-XXXX-XXXX-XXXX";
            this.GUIDValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameValueTextBox
            // 
            this.NameValueTextBox.Location = new System.Drawing.Point(130, 63);
            this.NameValueTextBox.Name = "NameValueTextBox";
            this.NameValueTextBox.Size = new System.Drawing.Size(219, 26);
            this.NameValueTextBox.TabIndex = 5;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(130, 97);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(219, 26);
            this.BirthdayDateTimePicker.TabIndex = 7;
            // 
            // AgeValueLabel
            // 
            this.AgeValueLabel.Location = new System.Drawing.Point(126, 138);
            this.AgeValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeValueLabel.Name = "AgeValueLabel";
            this.AgeValueLabel.Size = new System.Drawing.Size(223, 20);
            this.AgeValueLabel.TabIndex = 8;
            this.AgeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 212);
            this.Controls.Add(this.AgeValueLabel);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.NameValueTextBox);
            this.Controls.Add(this.GUIDValueLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GUIDLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Bindings Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GUIDLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GUIDValueLabel;
        private System.Windows.Forms.TextBox NameValueTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Label AgeValueLabel;
    }
}

