namespace CountDays_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SatsCount = new System.Windows.Forms.Label();
            this.SunsCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(159, 379);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 71);
            this.textBox1.TabIndex = 0;
            // 
            // SatsCount
            // 
            this.SatsCount.AutoSize = true;
            this.SatsCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SatsCount.Location = new System.Drawing.Point(270, 614);
            this.SatsCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SatsCount.Name = "SatsCount";
            this.SatsCount.Size = new System.Drawing.Size(354, 69);
            this.SatsCount.TabIndex = 1;
            this.SatsCount.Text = "有幾個星期六";
            this.SatsCount.Click += new System.EventHandler(this.SatsCount_Click);
            // 
            // SunsCount
            // 
            this.SunsCount.AutoSize = true;
            this.SunsCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SunsCount.Location = new System.Drawing.Point(224, 774);
            this.SunsCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SunsCount.Name = "SunsCount";
            this.SunsCount.Size = new System.Drawing.Size(354, 69);
            this.SunsCount.TabIndex = 2;
            this.SunsCount.Text = "有幾個星期日";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 76);
            this.button1.TabIndex = 3;
            this.button1.Text = "Count!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 1148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SunsCount);
            this.Controls.Add(this.SatsCount);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SatsCount;
        private System.Windows.Forms.Label SunsCount;
        private System.Windows.Forms.Button button1;
    }
}

