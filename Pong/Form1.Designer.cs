namespace Pong
{
    partial class Pong
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.pongball = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.pongTimerLabel = new System.Windows.Forms.Label();
            this.pongTimerMinute = new System.Windows.Forms.Label();
            this.pongTimerSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.player1.Location = new System.Drawing.Point(12, 221);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(22, 213);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.player2.Location = new System.Drawing.Point(1120, 221);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(22, 213);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // pongball
            // 
            this.pongball.BackColor = System.Drawing.Color.Black;
            this.pongball.Location = new System.Drawing.Point(571, 319);
            this.pongball.Name = "pongball";
            this.pongball.Size = new System.Drawing.Size(20, 19);
            this.pongball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pongball.TabIndex = 2;
            this.pongball.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("MS Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Orange;
            this.Score.Location = new System.Drawing.Point(517, 139);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(123, 34);
            this.Score.TabIndex = 4;
            this.Score.Text = "label1";
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // pongTimerLabel
            // 
            this.pongTimerLabel.AutoSize = true;
            this.pongTimerLabel.Location = new System.Drawing.Point(520, 704);
            this.pongTimerLabel.Name = "pongTimerLabel";
            this.pongTimerLabel.Size = new System.Drawing.Size(33, 13);
            this.pongTimerLabel.TabIndex = 5;
            this.pongTimerLabel.Text = "Time:";
            // 
            // pongTimerMinute
            // 
            this.pongTimerMinute.AutoSize = true;
            this.pongTimerMinute.Location = new System.Drawing.Point(570, 704);
            this.pongTimerMinute.Name = "pongTimerMinute";
            this.pongTimerMinute.Size = new System.Drawing.Size(35, 13);
            this.pongTimerMinute.TabIndex = 6;
            this.pongTimerMinute.Text = "label1";
            // 
            // pongTimerSecond
            // 
            this.pongTimerSecond.AutoSize = true;
            this.pongTimerSecond.Location = new System.Drawing.Point(605, 704);
            this.pongTimerSecond.Name = "pongTimerSecond";
            this.pongTimerSecond.Size = new System.Drawing.Size(0, 13);
            this.pongTimerSecond.TabIndex = 7;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 726);
            this.Controls.Add(this.pongTimerSecond);
            this.Controls.Add(this.pongTimerMinute);
            this.Controls.Add(this.pongball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.pongTimerLabel);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox pongball;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Label pongTimerLabel;
        private System.Windows.Forms.Label pongTimerMinute;
        private System.Windows.Forms.Label pongTimerSecond;
    }
}

