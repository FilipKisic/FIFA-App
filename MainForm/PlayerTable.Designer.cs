namespace MainForm
{
    partial class PlayerTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCaptain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFavorite = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPlayers
            // 
            this.dgwPlayers.BackgroundColor = System.Drawing.Color.White;
            this.dgwPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.PlayerNumber,
            this.PlayerPosition,
            this.IsCaptain,
            this.IsFavorite});
            this.dgwPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPlayers.Location = new System.Drawing.Point(0, 0);
            this.dgwPlayers.Name = "dgwPlayers";
            this.dgwPlayers.Size = new System.Drawing.Size(550, 398);
            this.dgwPlayers.TabIndex = 0;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Ime";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.HeaderText = "Broj";
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.ReadOnly = true;
            // 
            // PlayerPosition
            // 
            this.PlayerPosition.HeaderText = "Pozicija";
            this.PlayerPosition.Name = "PlayerPosition";
            this.PlayerPosition.ReadOnly = true;
            // 
            // IsCaptain
            // 
            this.IsCaptain.HeaderText = "Kapetan";
            this.IsCaptain.Name = "IsCaptain";
            this.IsCaptain.ReadOnly = true;
            this.IsCaptain.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCaptain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsFavorite
            // 
            this.IsFavorite.HeaderText = "Favorit";
            this.IsFavorite.Name = "IsFavorite";
            // 
            // PlayerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwPlayers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayerTable";
            this.Size = new System.Drawing.Size(550, 398);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCaptain;
        private System.Windows.Forms.DataGridViewImageColumn IsFavorite;
    }
}
