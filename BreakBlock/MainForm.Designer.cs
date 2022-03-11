namespace BreakBlock
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fieldPictureBox = new System.Windows.Forms.PictureBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.LevelEasyRadioButton = new System.Windows.Forms.RadioButton();
            this.LevelNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.LevelHardRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldPictureBox
            // 
            this.fieldPictureBox.BackColor = System.Drawing.Color.Black;
            this.fieldPictureBox.Location = new System.Drawing.Point(12, 12);
            this.fieldPictureBox.Name = "fieldPictureBox";
            this.fieldPictureBox.Size = new System.Drawing.Size(400, 400);
            this.fieldPictureBox.TabIndex = 0;
            this.fieldPictureBox.TabStop = false;
            this.fieldPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.reloadTimer_Tick);
            // 
            // LevelEasyRadioButton
            // 
            this.LevelEasyRadioButton.AutoSize = true;
            this.LevelEasyRadioButton.Location = new System.Drawing.Point(10, 509);
            this.LevelEasyRadioButton.Name = "LevelEasyRadioButton";
            this.LevelEasyRadioButton.Size = new System.Drawing.Size(47, 16);
            this.LevelEasyRadioButton.TabIndex = 1;
            this.LevelEasyRadioButton.TabStop = true;
            this.LevelEasyRadioButton.Text = "簡単";
            this.LevelEasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // LevelNormalRadioButton
            // 
            this.LevelNormalRadioButton.AutoSize = true;
            this.LevelNormalRadioButton.Location = new System.Drawing.Point(63, 509);
            this.LevelNormalRadioButton.Name = "LevelNormalRadioButton";
            this.LevelNormalRadioButton.Size = new System.Drawing.Size(47, 16);
            this.LevelNormalRadioButton.TabIndex = 2;
            this.LevelNormalRadioButton.TabStop = true;
            this.LevelNormalRadioButton.Text = "普通";
            this.LevelNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // LevelHardRadioButton
            // 
            this.LevelHardRadioButton.AutoSize = true;
            this.LevelHardRadioButton.Location = new System.Drawing.Point(116, 509);
            this.LevelHardRadioButton.Name = "LevelHardRadioButton";
            this.LevelHardRadioButton.Size = new System.Drawing.Size(54, 16);
            this.LevelHardRadioButton.TabIndex = 3;
            this.LevelHardRadioButton.TabStop = true;
            this.LevelHardRadioButton.Text = "難しい";
            this.LevelHardRadioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(180, 531);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(261, 531);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 5;
            this.endButton.Text = "終了";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(342, 531);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "一時停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(250, 485);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(11, 12);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "スコア";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "難易度";
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(216, 446);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(195, 23);
            this.rightButton.TabIndex = 10;
            this.rightButton.Text = "→";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightButton_MouseDown);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(15, 446);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(195, 23);
            this.leftButton.TabIndex = 11;
            this.leftButton.Text = "←";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftButton_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "操作";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.LevelHardRadioButton);
            this.Controls.Add(this.LevelEasyRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LevelNormalRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.fieldPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "ブロック崩し";
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fieldPictureBox;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.RadioButton LevelEasyRadioButton;
        private System.Windows.Forms.RadioButton LevelNormalRadioButton;
        private System.Windows.Forms.RadioButton LevelHardRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label label4;
    }
}

