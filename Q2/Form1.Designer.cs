namespace Q2
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
			this.newGameButton = new System.Windows.Forms.Button();
			this.answerTxtBox = new System.Windows.Forms.TextBox();
			this.resultLable = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(42, 38);
			this.newGameButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(150, 48);
			this.newGameButton.TabIndex = 0;
			this.newGameButton.Text = "再擲一次";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// answerTxtBox
			// 
			this.answerTxtBox.Location = new System.Drawing.Point(42, 120);
			this.answerTxtBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.answerTxtBox.Name = "answerTxtBox";
			this.answerTxtBox.Size = new System.Drawing.Size(196, 34);
			this.answerTxtBox.TabIndex = 1;
			// 
			// resultLable
			// 
			this.resultLable.AutoSize = true;
			this.resultLable.Location = new System.Drawing.Point(38, 200);
			this.resultLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.resultLable.Name = "resultLable";
			this.resultLable.Size = new System.Drawing.Size(113, 25);
			this.resultLable.TabIndex = 2;
			this.resultLable.Text = "resultLable";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 325);
			this.Controls.Add(this.resultLable);
			this.Controls.Add(this.answerTxtBox);
			this.Controls.Add(this.newGameButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Label resultLable;
    }
}

