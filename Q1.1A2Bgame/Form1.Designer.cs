namespace Q1._1A2Bgame
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
            this.guessTxtBox = new System.Windows.Forms.TextBox();
            this.resultLable = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessTxtBox
            // 
            this.guessTxtBox.Location = new System.Drawing.Point(40, 101);
            this.guessTxtBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guessTxtBox.Name = "guessTxtBox";
            this.guessTxtBox.Size = new System.Drawing.Size(164, 29);
            this.guessTxtBox.TabIndex = 0;
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(36, 150);
            this.resultLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(91, 20);
            this.resultLable.TabIndex = 1;
            this.resultLable.Text = "resultLable";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(232, 95);
            this.guessButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(143, 38);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "猜猜看";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(40, 38);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(335, 38);
            this.newGameButton.TabIndex = 3;
            this.newGameButton.Text = "新遊戲";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 242);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.guessTxtBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "1A2B遊戲猜猜看";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessTxtBox;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button newGameButton;
    }
}

