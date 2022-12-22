namespace Pong
{
    partial class losescreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endScorLabel = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.StartBTN = new System.Windows.Forms.Button();
            this.restartBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endPlayerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(179, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "You lose this Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Score is: ";
            // 
            // endScorLabel
            // 
            this.endScorLabel.AutoSize = true;
            this.endScorLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endScorLabel.Location = new System.Drawing.Point(507, 182);
            this.endScorLabel.Name = "endScorLabel";
            this.endScorLabel.Size = new System.Drawing.Size(0, 40);
            this.endScorLabel.TabIndex = 2;
            // 
            // submitBTN
            // 
            this.submitBTN.ForeColor = System.Drawing.Color.Red;
            this.submitBTN.Location = new System.Drawing.Point(539, 420);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 3;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // StartBTN
            // 
            this.StartBTN.ForeColor = System.Drawing.Color.Red;
            this.StartBTN.Location = new System.Drawing.Point(492, 677);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(105, 23);
            this.StartBTN.TabIndex = 4;
            this.StartBTN.Text = "Go to start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // restartBTN
            // 
            this.restartBTN.ForeColor = System.Drawing.Color.Red;
            this.restartBTN.Location = new System.Drawing.Point(603, 677);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(75, 23);
            this.restartBTN.TabIndex = 5;
            this.restartBTN.Text = "Restart";
            this.restartBTN.UseVisualStyleBackColor = true;
            this.restartBTN.Click += new System.EventHandler(this.restartBTN_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(418, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pleas enter your name and enter Submit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(390, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(550, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "to write your score into a WORLDWIDE database";
            // 
            // endPlayerScore
            // 
            this.endPlayerScore.AutoSize = true;
            this.endPlayerScore.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPlayerScore.Location = new System.Drawing.Point(623, 209);
            this.endPlayerScore.Name = "endPlayerScore";
            this.endPlayerScore.Size = new System.Drawing.Size(159, 34);
            this.endPlayerScore.TabIndex = 9;
            this.endPlayerScore.Text = "_ _ _ _ ";
            // 
            // losescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1154, 726);
            this.Controls.Add(this.endPlayerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.restartBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.endScorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "losescreen";
            this.Text = "losescreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label endScorLabel;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button restartBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label endPlayerScore;
    }
}