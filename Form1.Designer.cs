namespace boxing
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
            this.components = new System.ComponentModel.Container();
            this.EnemyBar = new System.Windows.Forms.ProgressBar();
            this.BoxerHealthBar = new System.Windows.Forms.ProgressBar();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Boxer = new System.Windows.Forms.PictureBox();
            this.boxerattacktimer = new System.Windows.Forms.Timer(this.components);
            this.boxermovetimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyBar
            // 
            this.EnemyBar.Location = new System.Drawing.Point(17, 63);
            this.EnemyBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnemyBar.Name = "EnemyBar";
            this.EnemyBar.Size = new System.Drawing.Size(341, 38);
            this.EnemyBar.TabIndex = 0;
            // 
            // BoxerHealthBar
            // 
            this.BoxerHealthBar.Location = new System.Drawing.Point(661, 63);
            this.BoxerHealthBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxerHealthBar.Name = "BoxerHealthBar";
            this.BoxerHealthBar.Size = new System.Drawing.Size(341, 38);
            this.BoxerHealthBar.TabIndex = 1;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::boxing.Properties.Resources.boxer_stand;
            this.Player.Location = new System.Drawing.Point(348, 407);
            this.Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(61, 153);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Boxer
            // 
            this.Boxer.BackColor = System.Drawing.Color.Transparent;
            this.Boxer.Image = global::boxing.Properties.Resources.enemy_stand;
            this.Boxer.Location = new System.Drawing.Point(404, 321);
            this.Boxer.Name = "Boxer";
            this.Boxer.Size = new System.Drawing.Size(77, 185);
            this.Boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Boxer.TabIndex = 3;
            this.Boxer.TabStop = false;
            // 
            // boxerattacktimer
            // 
            this.boxerattacktimer.Enabled = true;
            this.boxerattacktimer.Interval = 500;
            this.boxerattacktimer.Tick += new System.EventHandler(this.boxerattackevent);
            // 
            // boxermovetimer
            // 
            this.boxermovetimer.Enabled = true;
            this.boxermovetimer.Interval = 20;
            this.boxermovetimer.Tick += new System.EventHandler(this.boxermovetimereEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::boxing.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 702);
            this.Controls.Add(this.BoxerHealthBar);
            this.Controls.Add(this.EnemyBar);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Boxer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "boxing ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar EnemyBar;
        private ProgressBar BoxerHealthBar;
        private PictureBox Player;
        private PictureBox Boxer;
        private System.Windows.Forms.Timer boxerattacktimer;
        private System.Windows.Forms.Timer boxermovetimer;
    }
}