namespace RegelSpil
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
            this.txtbxAddPlayer = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lstvwPlayers = new System.Windows.Forms.ListView();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.rtxtbxHistory = new System.Windows.Forms.RichTextBox();
            this.lblDrawnCard = new System.Windows.Forms.Label();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.tsmStartNew = new System.Windows.Forms.ToolStripMenuItem();
            this.imgDrawCard = new System.Windows.Forms.PictureBox();
            this.lblCardsLeft = new System.Windows.Forms.Label();
            this.mnuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrawCard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxAddPlayer
            // 
            this.txtbxAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAddPlayer.Location = new System.Drawing.Point(293, 219);
            this.txtbxAddPlayer.Name = "txtbxAddPlayer";
            this.txtbxAddPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddPlayer.TabIndex = 1;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPlayer.Location = new System.Drawing.Point(293, 245);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(100, 20);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Tilføj spiller";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lstvwPlayers
            // 
            this.lstvwPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvwPlayers.Location = new System.Drawing.Point(293, 33);
            this.lstvwPlayers.Name = "lstvwPlayers";
            this.lstvwPlayers.Size = new System.Drawing.Size(100, 180);
            this.lstvwPlayers.TabIndex = 3;
            this.lstvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lstvwPlayers.View = System.Windows.Forms.View.List;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDrawCard.Enabled = false;
            this.btnDrawCard.Location = new System.Drawing.Point(12, 245);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(75, 20);
            this.btnDrawCard.TabIndex = 5;
            this.btnDrawCard.Text = "Træk kort";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // rtxtbxHistory
            // 
            this.rtxtbxHistory.Location = new System.Drawing.Point(142, 33);
            this.rtxtbxHistory.Name = "rtxtbxHistory";
            this.rtxtbxHistory.ReadOnly = true;
            this.rtxtbxHistory.Size = new System.Drawing.Size(145, 180);
            this.rtxtbxHistory.TabIndex = 8;
            this.rtxtbxHistory.Text = "";
            // 
            // lblDrawnCard
            // 
            this.lblDrawnCard.AutoSize = true;
            this.lblDrawnCard.Location = new System.Drawing.Point(12, 222);
            this.lblDrawnCard.Name = "lblDrawnCard";
            this.lblDrawnCard.Size = new System.Drawing.Size(70, 13);
            this.lblDrawnCard.TabIndex = 9;
            this.lblDrawnCard.Text = "lblDrawnCard";
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStartNew});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(405, 24);
            this.mnuTop.TabIndex = 11;
            this.mnuTop.Text = "mnuTop";
            // 
            // tsmStartNew
            // 
            this.tsmStartNew.Name = "tsmStartNew";
            this.tsmStartNew.Size = new System.Drawing.Size(84, 20);
            this.tsmStartNew.Text = "Start nyt spil";
            this.tsmStartNew.Click += new System.EventHandler(this.tsmStartNew_Click);
            // 
            // imgDrawCard
            // 
            this.imgDrawCard.Image = global::RegelSpil.Properties.Resources.BG;
            this.imgDrawCard.Location = new System.Drawing.Point(12, 33);
            this.imgDrawCard.Name = "imgDrawCard";
            this.imgDrawCard.Size = new System.Drawing.Size(124, 180);
            this.imgDrawCard.TabIndex = 7;
            this.imgDrawCard.TabStop = false;
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.AutoSize = true;
            this.lblCardsLeft.Location = new System.Drawing.Point(93, 249);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(62, 13);
            this.lblCardsLeft.TabIndex = 12;
            this.lblCardsLeft.Text = "lblCardsLeft";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 285);
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.lblDrawnCard);
            this.Controls.Add(this.rtxtbxHistory);
            this.Controls.Add(this.imgDrawCard);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.lstvwPlayers);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtbxAddPlayer);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.MinimumSize = new System.Drawing.Size(421, 294);
            this.Name = "Form1";
            this.Text = "Regelspil";
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDrawCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxAddPlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListView lstvwPlayers;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.PictureBox imgDrawCard;
        private System.Windows.Forms.RichTextBox rtxtbxHistory;
        private System.Windows.Forms.Label lblDrawnCard;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem tsmStartNew;
        private System.Windows.Forms.Label lblCardsLeft;
    }
}

