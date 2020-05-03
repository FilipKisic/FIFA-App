namespace MainForm
{
    partial class FavoritePlayersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritePlayersPage));
            this.playerTable1 = new MainForm.PlayerTable();
            this.lbTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerTable1
            // 
            this.playerTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTable1.Location = new System.Drawing.Point(13, 81);
            this.playerTable1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerTable1.Name = "playerTable1";
            this.playerTable1.Size = new System.Drawing.Size(550, 398);
            this.playerTable1.TabIndex = 0;
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(630, 81);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(35, 13);
            this.lbTest.TabIndex = 1;
            this.lbTest.Text = "label1";
            // 
            // FavoritePlayersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.playerTable1);
            this.Name = "FavoritePlayersPage";
            this.Text = "Omiljeni igrači";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlayerTable playerTable1;
        private System.Windows.Forms.Label lbTest;
    }
}