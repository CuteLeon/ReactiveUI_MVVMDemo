namespace Commands
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
            this.CommandWOParamButton = new System.Windows.Forms.Button();
            this.CommandWParamButton = new System.Windows.Forms.Button();
            this.CommandRParamButton = new System.Windows.Forms.Button();
            this.WithParamValueTextBox = new System.Windows.Forms.TextBox();
            this.RequiredParamValue1TextBox = new System.Windows.Forms.TextBox();
            this.RequiredParamValue2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CommandWOParamButton
            // 
            this.CommandWOParamButton.Location = new System.Drawing.Point(49, 25);
            this.CommandWOParamButton.Name = "CommandWOParamButton";
            this.CommandWOParamButton.Size = new System.Drawing.Size(277, 38);
            this.CommandWOParamButton.TabIndex = 0;
            this.CommandWOParamButton.Text = "无参命令";
            this.CommandWOParamButton.UseVisualStyleBackColor = true;
            // 
            // CommandWParamButton
            // 
            this.CommandWParamButton.Location = new System.Drawing.Point(49, 109);
            this.CommandWParamButton.Name = "CommandWParamButton";
            this.CommandWParamButton.Size = new System.Drawing.Size(277, 38);
            this.CommandWParamButton.TabIndex = 1;
            this.CommandWParamButton.Text = "有参命令";
            this.CommandWParamButton.UseVisualStyleBackColor = true;
            // 
            // CommandRParamButton
            // 
            this.CommandRParamButton.Location = new System.Drawing.Point(49, 225);
            this.CommandRParamButton.Name = "CommandRParamButton";
            this.CommandRParamButton.Size = new System.Drawing.Size(277, 38);
            this.CommandRParamButton.TabIndex = 2;
            this.CommandRParamButton.Text = "需参命令";
            this.CommandRParamButton.UseVisualStyleBackColor = true;
            // 
            // WithParamValueTextBox
            // 
            this.WithParamValueTextBox.Location = new System.Drawing.Point(49, 77);
            this.WithParamValueTextBox.Name = "WithParamValueTextBox";
            this.WithParamValueTextBox.Size = new System.Drawing.Size(277, 26);
            this.WithParamValueTextBox.TabIndex = 3;
            this.WithParamValueTextBox.Text = "啦啦啦";
            // 
            // RequiredParamValue1TextBox
            // 
            this.RequiredParamValue1TextBox.Location = new System.Drawing.Point(49, 161);
            this.RequiredParamValue1TextBox.Name = "RequiredParamValue1TextBox";
            this.RequiredParamValue1TextBox.Size = new System.Drawing.Size(277, 26);
            this.RequiredParamValue1TextBox.TabIndex = 4;
            this.RequiredParamValue1TextBox.Text = "叭叭叭";
            // 
            // RequiredParamValue2TextBox
            // 
            this.RequiredParamValue2TextBox.Location = new System.Drawing.Point(49, 193);
            this.RequiredParamValue2TextBox.Name = "RequiredParamValue2TextBox";
            this.RequiredParamValue2TextBox.Size = new System.Drawing.Size(277, 26);
            this.RequiredParamValue2TextBox.TabIndex = 5;
            this.RequiredParamValue2TextBox.Text = "咚咚咚";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 302);
            this.Controls.Add(this.RequiredParamValue2TextBox);
            this.Controls.Add(this.RequiredParamValue1TextBox);
            this.Controls.Add(this.WithParamValueTextBox);
            this.Controls.Add(this.CommandRParamButton);
            this.Controls.Add(this.CommandWParamButton);
            this.Controls.Add(this.CommandWOParamButton);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Commands Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommandWOParamButton;
        private System.Windows.Forms.Button CommandWParamButton;
        private System.Windows.Forms.Button CommandRParamButton;
        private System.Windows.Forms.TextBox WithParamValueTextBox;
        private System.Windows.Forms.TextBox RequiredParamValue1TextBox;
        private System.Windows.Forms.TextBox RequiredParamValue2TextBox;
    }
}

