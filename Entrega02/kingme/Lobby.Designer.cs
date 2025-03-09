﻿namespace kingme
{
    partial class Lobby
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListMatches = new System.Windows.Forms.Button();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.lstMatchesTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.Black;
            this.btnListMatches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListMatches.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMatches.ForeColor = System.Drawing.Color.White;
            this.btnListMatches.Location = new System.Drawing.Point(200, 457);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(210, 35);
            this.btnListMatches.TabIndex = 0;
            this.btnListMatches.Text = "Atualizar";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // lstMatches
            // 
            this.lstMatches.BackColor = System.Drawing.Color.White;
            this.lstMatches.FormattingEnabled = true;
            this.lstMatches.Location = new System.Drawing.Point(167, 125);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(283, 316);
            this.lstMatches.TabIndex = 4;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // lstMatchesTitle
            // 
            this.lstMatchesTitle.AutoSize = true;
            this.lstMatchesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lstMatchesTitle.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatchesTitle.ForeColor = System.Drawing.Color.White;
            this.lstMatchesTitle.Location = new System.Drawing.Point(203, 66);
            this.lstMatchesTitle.Name = "lstMatchesTitle";
            this.lstMatchesTitle.Size = new System.Drawing.Size(216, 32);
            this.lstMatchesTitle.TabIndex = 7;
            this.lstMatchesTitle.Text = "Lista de partidas";
            this.lstMatchesTitle.Click += new System.EventHandler(this.lstMatchesTitle_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(557, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 32);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.White;
            this.lblTeam.Location = new System.Drawing.Point(162, 513);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(176, 25);
            this.lblTeam.TabIndex = 39;
            this.lblTeam.Text = "Windsor Guardians";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMatchesTitle);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.btnListMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(612, 547);
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby King Me";
            this.Load += new System.EventHandler(this.lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.Label lstMatchesTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
    }
}

