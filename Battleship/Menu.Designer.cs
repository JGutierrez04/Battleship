namespace Battleship
{
    partial class Menu
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnResumeGame = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pbxBattleShip = new System.Windows.Forms.PictureBox();
            this.lblBattleShip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(31, 103);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(87, 29);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnResumeGame
            // 
            this.btnResumeGame.Location = new System.Drawing.Point(31, 152);
            this.btnResumeGame.Name = "btnResumeGame";
            this.btnResumeGame.Size = new System.Drawing.Size(87, 29);
            this.btnResumeGame.TabIndex = 1;
            this.btnResumeGame.Text = "Resume";
            this.btnResumeGame.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(31, 203);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(87, 29);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(31, 254);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(87, 29);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // pbxBattleShip
            // 
            this.pbxBattleShip.Location = new System.Drawing.Point(167, 103);
            this.pbxBattleShip.Name = "pbxBattleShip";
            this.pbxBattleShip.Size = new System.Drawing.Size(135, 180);
            this.pbxBattleShip.TabIndex = 4;
            this.pbxBattleShip.TabStop = false;
            // 
            // lblBattleShip
            // 
            this.lblBattleShip.AutoSize = true;
            this.lblBattleShip.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattleShip.Location = new System.Drawing.Point(26, 18);
            this.lblBattleShip.Name = "lblBattleShip";
            this.lblBattleShip.Size = new System.Drawing.Size(276, 64);
            this.lblBattleShip.TabIndex = 6;
            this.lblBattleShip.Text = "BattleShip";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 312);
            this.Controls.Add(this.lblBattleShip);
            this.Controls.Add(this.pbxBattleShip);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnResumeGame);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattleShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnResumeGame;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbxBattleShip;
        private System.Windows.Forms.Label lblBattleShip;
    }
}

