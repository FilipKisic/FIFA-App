namespace MainForm
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.btnMen = new System.Windows.Forms.Button();
            this.btnWomen = new System.Windows.Forms.Button();
            this.rbtnHR = new System.Windows.Forms.RadioButton();
            this.rbtnEN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnMen
            // 
            this.btnMen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMen.BackColor = System.Drawing.Color.Gray;
            this.btnMen.FlatAppearance.BorderSize = 0;
            this.btnMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMen.Location = new System.Drawing.Point(108, 136);
            this.btnMen.Name = "btnMen";
            this.btnMen.Size = new System.Drawing.Size(218, 60);
            this.btnMen.TabIndex = 0;
            this.btnMen.Text = "Muško prvenstvo";
            this.btnMen.UseVisualStyleBackColor = false;
            this.btnMen.Click += new System.EventHandler(this.btnMen_Click);
            // 
            // btnWomen
            // 
            this.btnWomen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWomen.BackColor = System.Drawing.Color.Gray;
            this.btnWomen.FlatAppearance.BorderSize = 0;
            this.btnWomen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWomen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWomen.Location = new System.Drawing.Point(108, 215);
            this.btnWomen.Name = "btnWomen";
            this.btnWomen.Size = new System.Drawing.Size(218, 60);
            this.btnWomen.TabIndex = 1;
            this.btnWomen.Text = "Žensko prvenstvo";
            this.btnWomen.UseVisualStyleBackColor = false;
            this.btnWomen.Click += new System.EventHandler(this.btnWomen_Click);
            // 
            // rbtnHR
            // 
            this.rbtnHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnHR.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHR.AutoSize = true;
            this.rbtnHR.Image = ((System.Drawing.Image)(resources.GetObject("rbtnHR.Image")));
            this.rbtnHR.Location = new System.Drawing.Point(340, 370);
            this.rbtnHR.Name = "rbtnHR";
            this.rbtnHR.Size = new System.Drawing.Size(38, 38);
            this.rbtnHR.TabIndex = 4;
            this.rbtnHR.TabStop = true;
            this.rbtnHR.UseVisualStyleBackColor = true;
            // 
            // rbtnEN
            // 
            this.rbtnEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnEN.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnEN.AutoSize = true;
            this.rbtnEN.Image = ((System.Drawing.Image)(resources.GetObject("rbtnEN.Image")));
            this.rbtnEN.Location = new System.Drawing.Point(384, 370);
            this.rbtnEN.Name = "rbtnEN";
            this.rbtnEN.Size = new System.Drawing.Size(38, 38);
            this.rbtnEN.TabIndex = 5;
            this.rbtnEN.TabStop = true;
            this.rbtnEN.UseVisualStyleBackColor = true;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.rbtnEN);
            this.Controls.Add(this.rbtnHR);
            this.Controls.Add(this.btnWomen);
            this.Controls.Add(this.btnMen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartPage";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMen;
        private System.Windows.Forms.Button btnWomen;
        private System.Windows.Forms.RadioButton rbtnHR;
        private System.Windows.Forms.RadioButton rbtnEN;
    }
}