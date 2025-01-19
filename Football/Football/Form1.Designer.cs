namespace Football
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.GoalKeeper = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.topleft = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.topright = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.KeeperTimer = new System.Windows.Forms.Timer(this.components);
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.GAMEND = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblEndScore = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GoalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.GAMEND.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(0, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(157, 42);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.White;
            this.lblMissed.Location = new System.Drawing.Point(720, 0);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(178, 42);
            this.lblMissed.TabIndex = 1;
            this.lblMissed.Text = "Missed: 0";
            // 
            // GoalKeeper
            // 
            this.GoalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.GoalKeeper.Image = global::Football.Properties.Resources.stand_small;
            this.GoalKeeper.Location = new System.Drawing.Point(418, 169);
            this.GoalKeeper.Name = "GoalKeeper";
            this.GoalKeeper.Size = new System.Drawing.Size(82, 126);
            this.GoalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GoalKeeper.TabIndex = 2;
            this.GoalKeeper.TabStop = false;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Yellow;
            this.left.Image = global::Football.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(197, 238);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 40);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 3;
            this.left.TabStop = false;
            this.left.Tag = "left";
            this.left.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topleft
            // 
            this.topleft.BackColor = System.Drawing.Color.Yellow;
            this.topleft.Image = global::Football.Properties.Resources.target;
            this.topleft.Location = new System.Drawing.Point(197, 73);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(40, 40);
            this.topleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topleft.TabIndex = 8;
            this.topleft.TabStop = false;
            this.topleft.Tag = "topleft";
            this.topleft.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Yellow;
            this.top.Image = global::Football.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(436, 73);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(40, 40);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 9;
            this.top.TabStop = false;
            this.top.Tag = "top";
            this.top.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topright
            // 
            this.topright.BackColor = System.Drawing.Color.Yellow;
            this.topright.Image = global::Football.Properties.Resources.target;
            this.topright.Location = new System.Drawing.Point(676, 73);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(40, 40);
            this.topright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topright.TabIndex = 10;
            this.topright.TabStop = false;
            this.topright.Tag = "topright";
            this.topright.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Yellow;
            this.right.Image = global::Football.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(676, 238);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 40);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 11;
            this.right.TabStop = false;
            this.right.Tag = "right";
            this.right.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.Image = global::Football.Properties.Resources.football;
            this.football.Location = new System.Drawing.Point(430, 500);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(50, 51);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.football.TabIndex = 12;
            this.football.TabStop = false;
            // 
            // KeeperTimer
            // 
            this.KeeperTimer.Interval = 20;
            this.KeeperTimer.Tick += new System.EventHandler(this.KeeperTimerEvent);
            // 
            // BallTimer
            // 
            this.BallTimer.Interval = 20;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimerEvent);
            // 
            // GAMEND
            // 
            this.GAMEND.BackColor = System.Drawing.Color.Black;
            this.GAMEND.Controls.Add(this.lblEnter);
            this.GAMEND.Controls.Add(this.lblEndScore);
            this.GAMEND.Controls.Add(this.lblGameOver);
            this.GAMEND.Location = new System.Drawing.Point(-2, 0);
            this.GAMEND.Name = "GAMEND";
            this.GAMEND.Size = new System.Drawing.Size(900, 671);
            this.GAMEND.TabIndex = 13;
            this.GAMEND.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Jokerman", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(112, 147);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(673, 131);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GAME OVER!!";
            // 
            // lblEndScore
            // 
            this.lblEndScore.AutoSize = true;
            this.lblEndScore.Font = new System.Drawing.Font("Colonna MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndScore.ForeColor = System.Drawing.Color.DeepPink;
            this.lblEndScore.Location = new System.Drawing.Point(336, 292);
            this.lblEndScore.Name = "lblEndScore";
            this.lblEndScore.Size = new System.Drawing.Size(0, 50);
            this.lblEndScore.TabIndex = 1;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.HotPink;
            this.lblEnter.Location = new System.Drawing.Point(273, 365);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(350, 43);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Press Enter To Restart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::Football.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 670);
            this.Controls.Add(this.GAMEND);
            this.Controls.Add(this.football);
            this.Controls.Add(this.right);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.top);
            this.Controls.Add(this.topleft);
            this.Controls.Add(this.left);
            this.Controls.Add(this.GoalKeeper);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penalty Shooter";
            this.Click += new System.EventHandler(this.SetGoalTargetEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GoalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.GAMEND.ResumeLayout(false);
            this.GAMEND.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.PictureBox GoalKeeper;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox topleft;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox topright;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox football;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.Panel GAMEND;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblEndScore;
    }
}