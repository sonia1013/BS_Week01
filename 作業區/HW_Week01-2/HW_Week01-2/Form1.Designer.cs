namespace HW_Week01_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ToLeft = new System.Windows.Forms.Button();
            this.ToRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(123, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 382);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 27;
            this.listBox2.Location = new System.Drawing.Point(773, 177);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(329, 382);
            this.listBox2.TabIndex = 1;
            // 
            // ToLeft
            // 
            this.ToLeft.Location = new System.Drawing.Point(540, 465);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(107, 106);
            this.ToLeft.TabIndex = 2;
            this.ToLeft.Text = "<--";
            this.ToLeft.UseVisualStyleBackColor = true;
            this.ToLeft.Click += new System.EventHandler(this.ToLeft_Click);
            // 
            // ToRight
            // 
            this.ToRight.Location = new System.Drawing.Point(540, 142);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(107, 106);
            this.ToRight.TabIndex = 3;
            this.ToRight.Text = "-->";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 815);
            this.Controls.Add(this.ToRight);
            this.Controls.Add(this.ToLeft);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.Button ToRight;
    }
}

