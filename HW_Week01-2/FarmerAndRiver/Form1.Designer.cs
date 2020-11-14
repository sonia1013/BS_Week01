namespace FarmerAndRiver
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftSide = new System.Windows.Forms.ListBox();
            this.RightSide = new System.Windows.Forms.ListBox();
            this.ToRight = new System.Windows.Forms.Button();
            this.ToLeft = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LeftSide
            // 
            this.LeftSide.FormattingEnabled = true;
            this.LeftSide.ItemHeight = 27;
            this.LeftSide.Location = new System.Drawing.Point(80, 122);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(193, 436);
            this.LeftSide.TabIndex = 0;
            // 
            // RightSide
            // 
            this.RightSide.FormattingEnabled = true;
            this.RightSide.ItemHeight = 27;
            this.RightSide.Location = new System.Drawing.Point(533, 122);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(200, 436);
            this.RightSide.TabIndex = 1;
            // 
            // ToRight
            // 
            this.ToRight.Location = new System.Drawing.Point(343, 132);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(119, 118);
            this.ToRight.TabIndex = 2;
            this.ToRight.Text = "--->";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // ToLeft
            // 
            this.ToLeft.Location = new System.Drawing.Point(343, 401);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(119, 123);
            this.ToLeft.TabIndex = 3;
            this.ToLeft.Text = "<---";
            this.ToLeft.UseVisualStyleBackColor = true;
            this.ToLeft.Click += new System.EventHandler(this.ToLeft_Click);
            // 
            // textResult
            // 
            this.textResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textResult.Font = new System.Drawing.Font("新細明體", 12F);
            this.textResult.Location = new System.Drawing.Point(784, 122);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(432, 436);
            this.textResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 839);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.ToLeft);
            this.Controls.Add(this.ToRight);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftSide;
        private System.Windows.Forms.ListBox RightSide;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.TextBox textResult;
    }
}

