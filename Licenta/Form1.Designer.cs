namespace Licenta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtScore = new Label();
            enemyOne = new PictureBox();
            enemyThree = new PictureBox();
            enemyTwo = new PictureBox();
            player = new PictureBox();
            bullet = new PictureBox();
            bullet2 = new PictureBox();
            endingLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = SystemColors.ControlLightLight;
            txtScore.Location = new Point(2, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(122, 49);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: ";
            // 
            // enemyOne
            // 
            enemyOne.Image = Properties.Resources.enemy;
            enemyOne.Location = new Point(154, 90);
            enemyOne.Name = "enemyOne";
            enemyOne.Size = new Size(142, 123);
            enemyOne.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyOne.TabIndex = 1;
            enemyOne.TabStop = false;
            // 
            // enemyThree
            // 
            enemyThree.Image = Properties.Resources.enemy;
            enemyThree.Location = new Point(489, 90);
            enemyThree.Name = "enemyThree";
            enemyThree.Size = new Size(125, 123);
            enemyThree.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyThree.TabIndex = 2;
            enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            enemyTwo.Image = Properties.Resources.enemy;
            enemyTwo.Location = new Point(844, 90);
            enemyTwo.Name = "enemyTwo";
            enemyTwo.Size = new Size(125, 123);
            enemyTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyTwo.TabIndex = 3;
            enemyTwo.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.player;
            player.Location = new Point(436, 657);
            player.Name = "player";
            player.Size = new Size(155, 133);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(396, 380);
            bullet.Name = "bullet";
            bullet.Size = new Size(21, 40);
            bullet.TabIndex = 5;
            bullet.TabStop = false;
            // 
            // bullet2
            // 
            bullet2.Image = Properties.Resources.bullet;
            bullet2.Location = new Point(616, 381);
            bullet2.Name = "bullet2";
            bullet2.Size = new Size(20, 39);
            bullet2.TabIndex = 6;
            bullet2.TabStop = false;
            // 
            // endingLabel
            // 
            endingLabel.Font = new Font("Sans Serif Collection", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endingLabel.ForeColor = SystemColors.ControlLight;
            endingLabel.Location = new Point(-6, 264);
            endingLabel.Name = "endingLabel";
            endingLabel.Size = new Size(1072, 289);
            endingLabel.TabIndex = 7;
            endingLabel.Text = ".........";
            endingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1067, 830);
            Controls.Add(bullet2);
            Controls.Add(bullet);
            Controls.Add(endingLabel);
            Controls.Add(player);
            Controls.Add(enemyTwo);
            Controls.Add(enemyThree);
            Controls.Add(enemyOne);
            Controls.Add(txtScore);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Space War";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)enemyOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox enemyOne;
        private PictureBox enemyThree;
        private PictureBox enemyTwo;
        private PictureBox player;
        private PictureBox bullet;
        private PictureBox bullet2;
        private Label endingLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}
