namespace Battleship
{
    partial class Selection
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
            this.btnBoard7 = new System.Windows.Forms.Button();
            this.btnBoard10 = new System.Windows.Forms.Button();
            this.btnBoard20 = new System.Windows.Forms.Button();
            this.btnAirCraft = new System.Windows.Forms.Button();
            this.btnFrigate = new System.Windows.Forms.Button();
            this.btnSubmarine = new System.Windows.Forms.Button();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnBattleShip = new System.Windows.Forms.Button();
            this.btnDestroyer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.pbxTopDown = new System.Windows.Forms.PictureBox();
            this.btnConfirmN = new System.Windows.Forms.Button();
            this.btnConfirmY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoard7
            // 
            this.btnBoard7.Location = new System.Drawing.Point(93, 78);
            this.btnBoard7.Name = "btnBoard7";
            this.btnBoard7.Size = new System.Drawing.Size(113, 45);
            this.btnBoard7.TabIndex = 0;
            this.btnBoard7.Text = "7x7 Board";
            this.btnBoard7.UseVisualStyleBackColor = true;
            this.btnBoard7.Click += new System.EventHandler(this.btnBoard7_Click);
            // 
            // btnBoard10
            // 
            this.btnBoard10.Location = new System.Drawing.Point(289, 67);
            this.btnBoard10.Name = "btnBoard10";
            this.btnBoard10.Size = new System.Drawing.Size(159, 66);
            this.btnBoard10.TabIndex = 1;
            this.btnBoard10.Text = "10x10 Board";
            this.btnBoard10.UseVisualStyleBackColor = true;
            this.btnBoard10.Click += new System.EventHandler(this.btnBoard10_Click);
            // 
            // btnBoard20
            // 
            this.btnBoard20.Location = new System.Drawing.Point(523, 46);
            this.btnBoard20.Name = "btnBoard20";
            this.btnBoard20.Size = new System.Drawing.Size(189, 108);
            this.btnBoard20.TabIndex = 2;
            this.btnBoard20.Text = "20x20 Board";
            this.btnBoard20.UseVisualStyleBackColor = true;
            this.btnBoard20.Click += new System.EventHandler(this.btnBoard20_Click);
            // 
            // btnAirCraft
            // 
            this.btnAirCraft.Enabled = false;
            this.btnAirCraft.Location = new System.Drawing.Point(403, 186);
            this.btnAirCraft.Name = "btnAirCraft";
            this.btnAirCraft.Size = new System.Drawing.Size(176, 92);
            this.btnAirCraft.TabIndex = 5;
            this.btnAirCraft.Text = "Aircraft Carrier";
            this.btnAirCraft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAirCraft.UseVisualStyleBackColor = true;
            this.btnAirCraft.Click += new System.EventHandler(this.btnAircraft_Click);
            // 
            // btnFrigate
            // 
            this.btnFrigate.Enabled = false;
            this.btnFrigate.Location = new System.Drawing.Point(212, 186);
            this.btnFrigate.Name = "btnFrigate";
            this.btnFrigate.Size = new System.Drawing.Size(185, 92);
            this.btnFrigate.TabIndex = 4;
            this.btnFrigate.Text = "Frigate";
            this.btnFrigate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFrigate.UseVisualStyleBackColor = true;
            this.btnFrigate.Click += new System.EventHandler(this.btnFrigate_Click);
            // 
            // btnSubmarine
            // 
            this.btnSubmarine.Enabled = false;
            this.btnSubmarine.Location = new System.Drawing.Point(28, 186);
            this.btnSubmarine.Name = "btnSubmarine";
            this.btnSubmarine.Size = new System.Drawing.Size(178, 92);
            this.btnSubmarine.TabIndex = 3;
            this.btnSubmarine.Text = "Submarine";
            this.btnSubmarine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmarine.UseVisualStyleBackColor = true;
            this.btnSubmarine.Click += new System.EventHandler(this.btnSubmarine_Click);
            // 
            // btnMedical
            // 
            this.btnMedical.Enabled = false;
            this.btnMedical.Location = new System.Drawing.Point(403, 325);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(176, 92);
            this.btnMedical.TabIndex = 8;
            this.btnMedical.Text = "Medical";
            this.btnMedical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedical.UseVisualStyleBackColor = true;
            this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
            // 
            // btnBattleShip
            // 
            this.btnBattleShip.Enabled = false;
            this.btnBattleShip.Location = new System.Drawing.Point(212, 325);
            this.btnBattleShip.Name = "btnBattleShip";
            this.btnBattleShip.Size = new System.Drawing.Size(185, 92);
            this.btnBattleShip.TabIndex = 7;
            this.btnBattleShip.Text = "Battleship";
            this.btnBattleShip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBattleShip.UseVisualStyleBackColor = true;
            this.btnBattleShip.Click += new System.EventHandler(this.btnBattleship_Click);
            // 
            // btnDestroyer
            // 
            this.btnDestroyer.Enabled = false;
            this.btnDestroyer.Location = new System.Drawing.Point(28, 325);
            this.btnDestroyer.Name = "btnDestroyer";
            this.btnDestroyer.Size = new System.Drawing.Size(178, 92);
            this.btnDestroyer.TabIndex = 6;
            this.btnDestroyer.Text = "Destroyer";
            this.btnDestroyer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDestroyer.UseVisualStyleBackColor = true;
            this.btnDestroyer.Click += new System.EventHandler(this.btnDestroyer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 488);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(212, 468);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(327, 468);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(70, 23);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(509, 488);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(70, 23);
            this.btnCont.TabIndex = 12;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStats.Location = new System.Drawing.Point(604, 305);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(136, 100);
            this.lblStats.TabIndex = 15;
            // 
            // pbxTopDown
            // 
            this.pbxTopDown.Location = new System.Drawing.Point(604, 186);
            this.pbxTopDown.Name = "pbxTopDown";
            this.pbxTopDown.Size = new System.Drawing.Size(136, 116);
            this.pbxTopDown.TabIndex = 16;
            this.pbxTopDown.TabStop = false;
            // 
            // btnConfirmN
            // 
            this.btnConfirmN.Location = new System.Drawing.Point(689, 408);
            this.btnConfirmN.Name = "btnConfirmN";
            this.btnConfirmN.Size = new System.Drawing.Size(51, 52);
            this.btnConfirmN.TabIndex = 18;
            this.btnConfirmN.Text = "N";
            this.btnConfirmN.UseVisualStyleBackColor = true;
            // 
            // btnConfirmY
            // 
            this.btnConfirmY.Location = new System.Drawing.Point(607, 408);
            this.btnConfirmY.Name = "btnConfirmY";
            this.btnConfirmY.Size = new System.Drawing.Size(51, 52);
            this.btnConfirmY.TabIndex = 19;
            this.btnConfirmY.Text = "Y";
            this.btnConfirmY.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 526);
            this.Controls.Add(this.btnConfirmY);
            this.Controls.Add(this.btnConfirmN);
            this.Controls.Add(this.pbxTopDown);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMedical);
            this.Controls.Add(this.btnBattleShip);
            this.Controls.Add(this.btnDestroyer);
            this.Controls.Add(this.btnAirCraft);
            this.Controls.Add(this.btnFrigate);
            this.Controls.Add(this.btnSubmarine);
            this.Controls.Add(this.btnBoard20);
            this.Controls.Add(this.btnBoard10);
            this.Controls.Add(this.btnBoard7);
            this.Name = "Selection";
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTopDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoard7;
        private System.Windows.Forms.Button btnBoard10;
        private System.Windows.Forms.Button btnBoard20;
        private System.Windows.Forms.Button btnAirCraft;
        private System.Windows.Forms.Button btnFrigate;
        private System.Windows.Forms.Button btnSubmarine;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnBattleShip;
        private System.Windows.Forms.Button btnDestroyer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.PictureBox pbxTopDown;
        private System.Windows.Forms.Button btnConfirmN;
        private System.Windows.Forms.Button btnConfirmY;
    }
}