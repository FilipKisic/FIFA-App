namespace MainForm
{
    partial class FavoriteRepresentationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteRepresentationPage));
            this.cbRepresentations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbRepresentations
            // 
            this.cbRepresentations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRepresentations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRepresentations.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRepresentations.FormattingEnabled = true;
            this.cbRepresentations.Location = new System.Drawing.Point(94, 75);
            this.cbRepresentations.Name = "cbRepresentations";
            this.cbRepresentations.Size = new System.Drawing.Size(121, 33);
            this.cbRepresentations.Sorted = true;
            this.cbRepresentations.TabIndex = 0;
            this.cbRepresentations.Text = "Odabir";
            this.cbRepresentations.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // FavoriteRepresentationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 191);
            this.Controls.Add(this.cbRepresentations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FavoriteRepresentationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Omiljena reprezentacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRepresentations;
    }
}