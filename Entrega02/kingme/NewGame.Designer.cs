namespace kingme
{
    partial class NewGame
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
            this.btnCreateNewMatch = new System.Windows.Forms.Button();
            this.txtGroupNameMatch = new System.Windows.Forms.TextBox();
            this.lblGroupNameMatch = new System.Windows.Forms.Label();
            this.txtPasswordMatch = new System.Windows.Forms.TextBox();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.lblNameMatch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lstMatchesTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewMatch
            // 
            this.btnCreateNewMatch.BackColor = System.Drawing.Color.Black;
            this.btnCreateNewMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewMatch.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCreateNewMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateNewMatch.Location = new System.Drawing.Point(434, 345);
            this.btnCreateNewMatch.Name = "btnCreateNewMatch";
            this.btnCreateNewMatch.Size = new System.Drawing.Size(210, 35);
            this.btnCreateNewMatch.TabIndex = 23;
            this.btnCreateNewMatch.Text = "Criar partida";
            this.btnCreateNewMatch.UseVisualStyleBackColor = false;
            this.btnCreateNewMatch.Click += new System.EventHandler(this.btnCreateNewMatch_Click);
            // 
            // txtGroupNameMatch
            // 
            this.txtGroupNameMatch.Location = new System.Drawing.Point(434, 298);
            this.txtGroupNameMatch.Name = "txtGroupNameMatch";
            this.txtGroupNameMatch.Size = new System.Drawing.Size(210, 20);
            this.txtGroupNameMatch.TabIndex = 22;
            // 
            // lblGroupNameMatch
            // 
            this.lblGroupNameMatch.AutoSize = true;
            this.lblGroupNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupNameMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNameMatch.ForeColor = System.Drawing.Color.Black;
            this.lblGroupNameMatch.Location = new System.Drawing.Point(431, 279);
            this.lblGroupNameMatch.Name = "lblGroupNameMatch";
            this.lblGroupNameMatch.Size = new System.Drawing.Size(97, 13);
            this.lblGroupNameMatch.TabIndex = 21;
            this.lblGroupNameMatch.Text = "Nome do grupo:";
            // 
            // txtPasswordMatch
            // 
            this.txtPasswordMatch.Location = new System.Drawing.Point(434, 246);
            this.txtPasswordMatch.Name = "txtPasswordMatch";
            this.txtPasswordMatch.PasswordChar = '*';
            this.txtPasswordMatch.Size = new System.Drawing.Size(210, 20);
            this.txtPasswordMatch.TabIndex = 20;
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMatch.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordMatch.Location = new System.Drawing.Point(431, 227);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(47, 13);
            this.lblPasswordMatch.TabIndex = 19;
            this.lblPasswordMatch.Text = "Senha:";
            // 
            // txtMatchName
            // 
            this.txtMatchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchName.Location = new System.Drawing.Point(434, 198);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(210, 20);
            this.txtMatchName.TabIndex = 18;
            // 
            // lblNameMatch
            // 
            this.lblNameMatch.AutoSize = true;
            this.lblNameMatch.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMatch.ForeColor = System.Drawing.Color.Black;
            this.lblNameMatch.Location = new System.Drawing.Point(431, 180);
            this.lblNameMatch.Name = "lblNameMatch";
            this.lblNameMatch.Padding = new System.Windows.Forms.Padding(0, 0, 91, 0);
            this.lblNameMatch.Size = new System.Drawing.Size(195, 13);
            this.lblNameMatch.TabIndex = 17;
            this.lblNameMatch.Text = "Nome da partida:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::kingme.Properties.Resources.king;
            this.pictureBox1.Location = new System.Drawing.Point(89, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(745, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 32);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(242, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(86, 508);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(132, 13);
            this.lblTeam.TabIndex = 37;
            this.lblTeam.Text = "Guardiões de Windsor";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(298, 508);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 13);
            this.lblVersion.TabIndex = 39;
            // 
            // lstMatchesTitle
            // 
            this.lstMatchesTitle.AutoSize = true;
            this.lstMatchesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lstMatchesTitle.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatchesTitle.ForeColor = System.Drawing.Color.Black;
            this.lstMatchesTitle.Location = new System.Drawing.Point(429, 129);
            this.lstMatchesTitle.Name = "lstMatchesTitle";
            this.lstMatchesTitle.Size = new System.Drawing.Size(163, 32);
            this.lstMatchesTitle.TabIndex = 40;
            this.lstMatchesTitle.Text = "Informações";
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.texture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.lstMatchesTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateNewMatch);
            this.Controls.Add(this.txtGroupNameMatch);
            this.Controls.Add(this.lblGroupNameMatch);
            this.Controls.Add(this.txtPasswordMatch);
            this.Controls.Add(this.lblPasswordMatch);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.lblNameMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(816, 542);
            this.MinimumSize = new System.Drawing.Size(800, 542);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewMatch;
        private System.Windows.Forms.TextBox txtGroupNameMatch;
        private System.Windows.Forms.Label lblGroupNameMatch;
        private System.Windows.Forms.TextBox txtPasswordMatch;
        private System.Windows.Forms.Label lblPasswordMatch;
        private System.Windows.Forms.TextBox txtMatchName;
        private System.Windows.Forms.Label lblNameMatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lstMatchesTitle;
    }
}