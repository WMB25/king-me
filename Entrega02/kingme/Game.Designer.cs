namespace kingme
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.lblCardsTitle = new System.Windows.Forms.Label();
            this.btnListCards = new System.Windows.Forms.Button();
            this.lblCardsContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lstCards = new System.Windows.Forms.ListBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.btnUpdatePlayerList = new System.Windows.Forms.Button();
            this.lblPlayerPassword = new System.Windows.Forms.Label();
            this.lblListPlayers = new System.Windows.Forms.Label();
            this.lstMatchPlayers = new System.Windows.Forms.ListBox();
            this.btnInitializeMatch = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetCharacter = new System.Windows.Forms.Button();
            this.lstSections = new System.Windows.Forms.ListBox();
            this.btnVerifyTurn = new System.Windows.Forms.Button();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblIdPlayerTurn = new System.Windows.Forms.Label();
            this.lblPlayerIdValue = new System.Windows.Forms.Label();
            this.lblPlayerNameValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBeatrizPaiva = new System.Windows.Forms.Button();
            this.rdoBeatriz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLeonardo = new System.Windows.Forms.RadioButton();
            this.rdoKelly = new System.Windows.Forms.RadioButton();
            this.rdoGuilherme = new System.Windows.Forms.RadioButton();
            this.rdoEduardo = new System.Windows.Forms.RadioButton();
            this.rdoMario = new System.Windows.Forms.RadioButton();
            this.rdoDouglas = new System.Windows.Forms.RadioButton();
            this.rdoAdilson = new System.Windows.Forms.RadioButton();
            this.rdoClaro = new System.Windows.Forms.RadioButton();
            this.rdoHeredia = new System.Windows.Forms.RadioButton();
            this.btnLeonardo = new System.Windows.Forms.Button();
            this.btnKelly = new System.Windows.Forms.Button();
            this.btnGuilherme = new System.Windows.Forms.Button();
            this.btnEduardo = new System.Windows.Forms.Button();
            this.btnClaro = new System.Windows.Forms.Button();
            this.btnAdilson = new System.Windows.Forms.Button();
            this.btnHeredia = new System.Windows.Forms.Button();
            this.btnDouglas = new System.Windows.Forms.Button();
            this.btnMario = new System.Windows.Forms.Button();
            this.rdoRanulfo = new System.Windows.Forms.RadioButton();
            this.rdoQuintas = new System.Windows.Forms.RadioButton();
            this.rdoToshio = new System.Windows.Forms.RadioButton();
            this.btnToshio = new System.Windows.Forms.Button();
            this.btnQuintas = new System.Windows.Forms.Button();
            this.btnRanulfo = new System.Windows.Forms.Button();
            this.pboSetorUm = new System.Windows.Forms.PictureBox();
            this.pboSetorZero = new System.Windows.Forms.PictureBox();
            this.pboSetorDois = new System.Windows.Forms.PictureBox();
            this.pboSetorCinco = new System.Windows.Forms.PictureBox();
            this.pboSetorTres = new System.Windows.Forms.PictureBox();
            this.pboSetorQuatro = new System.Windows.Forms.PictureBox();
            this.pboSetorDez = new System.Windows.Forms.PictureBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.tmrAutomacao = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorQuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorDez)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardsTitle
            // 
            this.lblCardsTitle.AutoSize = true;
            this.lblCardsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCardsTitle.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCardsTitle.Location = new System.Drawing.Point(963, 600);
            this.lblCardsTitle.Name = "lblCardsTitle";
            this.lblCardsTitle.Size = new System.Drawing.Size(127, 26);
            this.lblCardsTitle.TabIndex = 42;
            this.lblCardsTitle.Text = "Suas cartas:";
            // 
            // btnListCards
            // 
            this.btnListCards.BackColor = System.Drawing.Color.Black;
            this.btnListCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListCards.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnListCards.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListCards.Location = new System.Drawing.Point(1264, 634);
            this.btnListCards.Name = "btnListCards";
            this.btnListCards.Size = new System.Drawing.Size(169, 40);
            this.btnListCards.TabIndex = 43;
            this.btnListCards.Text = "Listar cartas";
            this.btnListCards.UseVisualStyleBackColor = false;
            this.btnListCards.Click += new System.EventHandler(this.btnListCards_Click);
            // 
            // lblCardsContent
            // 
            this.lblCardsContent.AutoSize = true;
            this.lblCardsContent.Location = new System.Drawing.Point(855, 349);
            this.lblCardsContent.Name = "lblCardsContent";
            this.lblCardsContent.Size = new System.Drawing.Size(0, 13);
            this.lblCardsContent.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(963, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Personagens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(175, 751);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Versão:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(12, 751);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(132, 13);
            this.lblTeam.TabIndex = 49;
            this.lblTeam.Text = "Guardiões de Windsor";
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(966, 634);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(283, 95);
            this.lstCards.TabIndex = 51;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(240, 751);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 16);
            this.lblVersion.TabIndex = 52;
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(38, 77);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.ReadOnly = true;
            this.txtPlayerId.Size = new System.Drawing.Size(172, 20);
            this.txtPlayerId.TabIndex = 45;
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(37, 126);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.ReadOnly = true;
            this.txtPlayerPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPlayerPassword.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Info";
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerID.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerID.Location = new System.Drawing.Point(37, 59);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(91, 13);
            this.lblPlayerID.TabIndex = 32;
            this.lblPlayerID.Text = "ID do Jogador:";
            // 
            // btnUpdatePlayerList
            // 
            this.btnUpdatePlayerList.BackColor = System.Drawing.Color.Black;
            this.btnUpdatePlayerList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdatePlayerList.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePlayerList.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePlayerList.Location = new System.Drawing.Point(37, 452);
            this.btnUpdatePlayerList.Name = "btnUpdatePlayerList";
            this.btnUpdatePlayerList.Size = new System.Drawing.Size(172, 35);
            this.btnUpdatePlayerList.TabIndex = 40;
            this.btnUpdatePlayerList.Text = "Atualizar";
            this.btnUpdatePlayerList.UseVisualStyleBackColor = false;
            this.btnUpdatePlayerList.Click += new System.EventHandler(this.btnUpdatePlayerList_Click);
            // 
            // lblPlayerPassword
            // 
            this.lblPlayerPassword.AutoSize = true;
            this.lblPlayerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPlayerPassword.Location = new System.Drawing.Point(37, 110);
            this.lblPlayerPassword.Name = "lblPlayerPassword";
            this.lblPlayerPassword.Size = new System.Drawing.Size(114, 13);
            this.lblPlayerPassword.TabIndex = 34;
            this.lblPlayerPassword.Text = "Senha do Jogador:";
            // 
            // lblListPlayers
            // 
            this.lblListPlayers.AutoSize = true;
            this.lblListPlayers.BackColor = System.Drawing.Color.Transparent;
            this.lblListPlayers.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblListPlayers.ForeColor = System.Drawing.Color.Black;
            this.lblListPlayers.Location = new System.Drawing.Point(32, 218);
            this.lblListPlayers.Name = "lblListPlayers";
            this.lblListPlayers.Size = new System.Drawing.Size(177, 26);
            this.lblListPlayers.TabIndex = 37;
            this.lblListPlayers.Text = "Lista de jogadores";
            // 
            // lstMatchPlayers
            // 
            this.lstMatchPlayers.FormattingEnabled = true;
            this.lstMatchPlayers.Location = new System.Drawing.Point(36, 247);
            this.lstMatchPlayers.Name = "lstMatchPlayers";
            this.lstMatchPlayers.Size = new System.Drawing.Size(173, 199);
            this.lstMatchPlayers.TabIndex = 36;
            // 
            // btnInitializeMatch
            // 
            this.btnInitializeMatch.BackColor = System.Drawing.Color.Black;
            this.btnInitializeMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInitializeMatch.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnInitializeMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInitializeMatch.Location = new System.Drawing.Point(37, 152);
            this.btnInitializeMatch.Name = "btnInitializeMatch";
            this.btnInitializeMatch.Size = new System.Drawing.Size(172, 35);
            this.btnInitializeMatch.TabIndex = 31;
            this.btnInitializeMatch.Text = "Iniciar partida";
            this.btnInitializeMatch.UseVisualStyleBackColor = false;
            this.btnInitializeMatch.Click += new System.EventHandler(this.btnInitializeMatch_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Red;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeave.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeave.Location = new System.Drawing.Point(40, 494);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(169, 34);
            this.btnLeave.TabIndex = 48;
            this.btnLeave.Text = "Sair";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1466, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 53;
            this.label3.Text = "Setores";
            // 
            // btnSetCharacter
            // 
            this.btnSetCharacter.BackColor = System.Drawing.Color.Black;
            this.btnSetCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetCharacter.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCharacter.ForeColor = System.Drawing.Color.White;
            this.btnSetCharacter.Location = new System.Drawing.Point(1641, 634);
            this.btnSetCharacter.Name = "btnSetCharacter";
            this.btnSetCharacter.Size = new System.Drawing.Size(108, 57);
            this.btnSetCharacter.TabIndex = 54;
            this.btnSetCharacter.Text = "Colocar personagem";
            this.btnSetCharacter.UseVisualStyleBackColor = false;
            this.btnSetCharacter.Click += new System.EventHandler(this.btnSetCharacter_Click);
            // 
            // lstSections
            // 
            this.lstSections.FormattingEnabled = true;
            this.lstSections.Items.AddRange(new object[] {
            "4",
            "3",
            "2",
            "1"});
            this.lstSections.Location = new System.Drawing.Point(1468, 634);
            this.lstSections.Name = "lstSections";
            this.lstSections.Size = new System.Drawing.Size(147, 95);
            this.lstSections.TabIndex = 55;
            // 
            // btnVerifyTurn
            // 
            this.btnVerifyTurn.BackColor = System.Drawing.Color.Black;
            this.btnVerifyTurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerifyTurn.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnVerifyTurn.ForeColor = System.Drawing.Color.White;
            this.btnVerifyTurn.Location = new System.Drawing.Point(1264, 690);
            this.btnVerifyTurn.Name = "btnVerifyTurn";
            this.btnVerifyTurn.Size = new System.Drawing.Size(169, 39);
            this.btnVerifyTurn.TabIndex = 57;
            this.btnVerifyTurn.Text = "Verificar vez";
            this.btnVerifyTurn.UseVisualStyleBackColor = false;
            this.btnVerifyTurn.Click += new System.EventHandler(this.btnVerifyTurn_Click);
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(20, 657);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(124, 20);
            this.lblPlayerTurn.TabIndex = 58;
            this.lblPlayerTurn.Text = "Nome do Jogador:";
            // 
            // lblIdPlayerTurn
            // 
            this.lblIdPlayerTurn.AutoSize = true;
            this.lblIdPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPlayerTurn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPlayerTurn.Location = new System.Drawing.Point(22, 602);
            this.lblIdPlayerTurn.Name = "lblIdPlayerTurn";
            this.lblIdPlayerTurn.Size = new System.Drawing.Size(101, 20);
            this.lblIdPlayerTurn.TabIndex = 59;
            this.lblIdPlayerTurn.Text = "ID do Jogador:";
            // 
            // lblPlayerIdValue
            // 
            this.lblPlayerIdValue.AutoSize = true;
            this.lblPlayerIdValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerIdValue.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerIdValue.Location = new System.Drawing.Point(23, 634);
            this.lblPlayerIdValue.Name = "lblPlayerIdValue";
            this.lblPlayerIdValue.Size = new System.Drawing.Size(0, 16);
            this.lblPlayerIdValue.TabIndex = 60;
            // 
            // lblPlayerNameValue
            // 
            this.lblPlayerNameValue.AutoSize = true;
            this.lblPlayerNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerNameValue.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameValue.Location = new System.Drawing.Point(21, 687);
            this.lblPlayerNameValue.Name = "lblPlayerNameValue";
            this.lblPlayerNameValue.Size = new System.Drawing.Size(0, 16);
            this.lblPlayerNameValue.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 62;
            this.label4.Text = "Quem deve jogar";
            // 
            // btnBeatrizPaiva
            // 
            this.btnBeatrizPaiva.BackColor = System.Drawing.Color.Transparent;
            this.btnBeatrizPaiva.BackgroundImage = global::kingme.Properties.Resources.Sem_título_11;
            this.btnBeatrizPaiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBeatrizPaiva.FlatAppearance.BorderSize = 0;
            this.btnBeatrizPaiva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBeatrizPaiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeatrizPaiva.Location = new System.Drawing.Point(22, 28);
            this.btnBeatrizPaiva.Name = "btnBeatrizPaiva";
            this.btnBeatrizPaiva.Size = new System.Drawing.Size(98, 139);
            this.btnBeatrizPaiva.TabIndex = 63;
            this.btnBeatrizPaiva.UseVisualStyleBackColor = false;
            // 
            // rdoBeatriz
            // 
            this.rdoBeatriz.AutoSize = true;
            this.rdoBeatriz.BackColor = System.Drawing.Color.Transparent;
            this.rdoBeatriz.Location = new System.Drawing.Point(106, 25);
            this.rdoBeatriz.Name = "rdoBeatriz";
            this.rdoBeatriz.Size = new System.Drawing.Size(14, 13);
            this.rdoBeatriz.TabIndex = 64;
            this.rdoBeatriz.TabStop = true;
            this.rdoBeatriz.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoLeonardo);
            this.groupBox1.Controls.Add(this.rdoKelly);
            this.groupBox1.Controls.Add(this.rdoGuilherme);
            this.groupBox1.Controls.Add(this.rdoEduardo);
            this.groupBox1.Controls.Add(this.rdoBeatriz);
            this.groupBox1.Controls.Add(this.rdoMario);
            this.groupBox1.Controls.Add(this.rdoDouglas);
            this.groupBox1.Controls.Add(this.rdoAdilson);
            this.groupBox1.Controls.Add(this.rdoClaro);
            this.groupBox1.Controls.Add(this.rdoHeredia);
            this.groupBox1.Controls.Add(this.btnLeonardo);
            this.groupBox1.Controls.Add(this.btnKelly);
            this.groupBox1.Controls.Add(this.btnGuilherme);
            this.groupBox1.Controls.Add(this.btnEduardo);
            this.groupBox1.Controls.Add(this.btnClaro);
            this.groupBox1.Controls.Add(this.btnAdilson);
            this.groupBox1.Controls.Add(this.btnHeredia);
            this.groupBox1.Controls.Add(this.btnDouglas);
            this.groupBox1.Controls.Add(this.btnMario);
            this.groupBox1.Controls.Add(this.btnBeatrizPaiva);
            this.groupBox1.Controls.Add(this.rdoRanulfo);
            this.groupBox1.Controls.Add(this.rdoQuintas);
            this.groupBox1.Controls.Add(this.rdoToshio);
            this.groupBox1.Controls.Add(this.btnToshio);
            this.groupBox1.Controls.Add(this.btnQuintas);
            this.groupBox1.Controls.Add(this.btnRanulfo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(966, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 523);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // rdoLeonardo
            // 
            this.rdoLeonardo.AutoSize = true;
            this.rdoLeonardo.BackColor = System.Drawing.Color.Transparent;
            this.rdoLeonardo.Location = new System.Drawing.Point(514, 190);
            this.rdoLeonardo.Name = "rdoLeonardo";
            this.rdoLeonardo.Size = new System.Drawing.Size(14, 13);
            this.rdoLeonardo.TabIndex = 84;
            this.rdoLeonardo.TabStop = true;
            this.rdoLeonardo.UseVisualStyleBackColor = false;
            // 
            // rdoKelly
            // 
            this.rdoKelly.AutoSize = true;
            this.rdoKelly.BackColor = System.Drawing.Color.Transparent;
            this.rdoKelly.Location = new System.Drawing.Point(382, 190);
            this.rdoKelly.Name = "rdoKelly";
            this.rdoKelly.Size = new System.Drawing.Size(14, 13);
            this.rdoKelly.TabIndex = 82;
            this.rdoKelly.TabStop = true;
            this.rdoKelly.UseVisualStyleBackColor = false;
            // 
            // rdoGuilherme
            // 
            this.rdoGuilherme.AutoSize = true;
            this.rdoGuilherme.BackColor = System.Drawing.Color.Transparent;
            this.rdoGuilherme.Location = new System.Drawing.Point(249, 190);
            this.rdoGuilherme.Name = "rdoGuilherme";
            this.rdoGuilherme.Size = new System.Drawing.Size(14, 13);
            this.rdoGuilherme.TabIndex = 83;
            this.rdoGuilherme.TabStop = true;
            this.rdoGuilherme.UseVisualStyleBackColor = false;
            // 
            // rdoEduardo
            // 
            this.rdoEduardo.AutoSize = true;
            this.rdoEduardo.BackColor = System.Drawing.Color.Transparent;
            this.rdoEduardo.Location = new System.Drawing.Point(106, 190);
            this.rdoEduardo.Name = "rdoEduardo";
            this.rdoEduardo.Size = new System.Drawing.Size(14, 13);
            this.rdoEduardo.TabIndex = 82;
            this.rdoEduardo.TabStop = true;
            this.rdoEduardo.UseVisualStyleBackColor = false;
            // 
            // rdoMario
            // 
            this.rdoMario.AutoSize = true;
            this.rdoMario.BackColor = System.Drawing.Color.Transparent;
            this.rdoMario.Location = new System.Drawing.Point(249, 25);
            this.rdoMario.Name = "rdoMario";
            this.rdoMario.Size = new System.Drawing.Size(14, 13);
            this.rdoMario.TabIndex = 77;
            this.rdoMario.TabStop = true;
            this.rdoMario.UseVisualStyleBackColor = false;
            // 
            // rdoDouglas
            // 
            this.rdoDouglas.AutoSize = true;
            this.rdoDouglas.BackColor = System.Drawing.Color.Transparent;
            this.rdoDouglas.Location = new System.Drawing.Point(382, 25);
            this.rdoDouglas.Name = "rdoDouglas";
            this.rdoDouglas.Size = new System.Drawing.Size(14, 13);
            this.rdoDouglas.TabIndex = 78;
            this.rdoDouglas.TabStop = true;
            this.rdoDouglas.UseVisualStyleBackColor = false;
            // 
            // rdoAdilson
            // 
            this.rdoAdilson.AutoSize = true;
            this.rdoAdilson.BackColor = System.Drawing.Color.Transparent;
            this.rdoAdilson.Location = new System.Drawing.Point(635, 25);
            this.rdoAdilson.Name = "rdoAdilson";
            this.rdoAdilson.Size = new System.Drawing.Size(14, 13);
            this.rdoAdilson.TabIndex = 80;
            this.rdoAdilson.TabStop = true;
            this.rdoAdilson.UseVisualStyleBackColor = false;
            // 
            // rdoClaro
            // 
            this.rdoClaro.AutoSize = true;
            this.rdoClaro.BackColor = System.Drawing.Color.Transparent;
            this.rdoClaro.Location = new System.Drawing.Point(751, 25);
            this.rdoClaro.Name = "rdoClaro";
            this.rdoClaro.Size = new System.Drawing.Size(14, 13);
            this.rdoClaro.TabIndex = 81;
            this.rdoClaro.TabStop = true;
            this.rdoClaro.UseVisualStyleBackColor = false;
            // 
            // rdoHeredia
            // 
            this.rdoHeredia.AutoSize = true;
            this.rdoHeredia.BackColor = System.Drawing.Color.Transparent;
            this.rdoHeredia.Location = new System.Drawing.Point(514, 25);
            this.rdoHeredia.Name = "rdoHeredia";
            this.rdoHeredia.Size = new System.Drawing.Size(14, 13);
            this.rdoHeredia.TabIndex = 79;
            this.rdoHeredia.TabStop = true;
            this.rdoHeredia.UseVisualStyleBackColor = false;
            // 
            // btnLeonardo
            // 
            this.btnLeonardo.BackColor = System.Drawing.Color.Transparent;
            this.btnLeonardo.BackgroundImage = global::kingme.Properties.Resources.leonardo;
            this.btnLeonardo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeonardo.FlatAppearance.BorderSize = 0;
            this.btnLeonardo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeonardo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeonardo.Location = new System.Drawing.Point(430, 190);
            this.btnLeonardo.Name = "btnLeonardo";
            this.btnLeonardo.Size = new System.Drawing.Size(98, 139);
            this.btnLeonardo.TabIndex = 73;
            this.btnLeonardo.UseVisualStyleBackColor = false;
            // 
            // btnKelly
            // 
            this.btnKelly.BackColor = System.Drawing.Color.Transparent;
            this.btnKelly.BackgroundImage = global::kingme.Properties.Resources.kelly;
            this.btnKelly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKelly.FlatAppearance.BorderSize = 0;
            this.btnKelly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKelly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelly.Location = new System.Drawing.Point(298, 187);
            this.btnKelly.Name = "btnKelly";
            this.btnKelly.Size = new System.Drawing.Size(98, 139);
            this.btnKelly.TabIndex = 72;
            this.btnKelly.UseVisualStyleBackColor = false;
            // 
            // btnGuilherme
            // 
            this.btnGuilherme.BackColor = System.Drawing.Color.Transparent;
            this.btnGuilherme.BackgroundImage = global::kingme.Properties.Resources.guilherme;
            this.btnGuilherme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuilherme.FlatAppearance.BorderSize = 0;
            this.btnGuilherme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuilherme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuilherme.Location = new System.Drawing.Point(165, 190);
            this.btnGuilherme.Name = "btnGuilherme";
            this.btnGuilherme.Size = new System.Drawing.Size(98, 139);
            this.btnGuilherme.TabIndex = 71;
            this.btnGuilherme.UseVisualStyleBackColor = false;
            // 
            // btnEduardo
            // 
            this.btnEduardo.BackColor = System.Drawing.Color.Transparent;
            this.btnEduardo.BackgroundImage = global::kingme.Properties.Resources.eduardo;
            this.btnEduardo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEduardo.FlatAppearance.BorderSize = 0;
            this.btnEduardo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEduardo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEduardo.Location = new System.Drawing.Point(22, 190);
            this.btnEduardo.Name = "btnEduardo";
            this.btnEduardo.Size = new System.Drawing.Size(98, 139);
            this.btnEduardo.TabIndex = 70;
            this.btnEduardo.UseVisualStyleBackColor = false;
            // 
            // btnClaro
            // 
            this.btnClaro.BackColor = System.Drawing.Color.Transparent;
            this.btnClaro.BackgroundImage = global::kingme.Properties.Resources.claro;
            this.btnClaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClaro.FlatAppearance.BorderSize = 0;
            this.btnClaro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaro.Location = new System.Drawing.Point(667, 26);
            this.btnClaro.Name = "btnClaro";
            this.btnClaro.Size = new System.Drawing.Size(98, 139);
            this.btnClaro.TabIndex = 69;
            this.btnClaro.UseVisualStyleBackColor = false;
            // 
            // btnAdilson
            // 
            this.btnAdilson.BackColor = System.Drawing.Color.Transparent;
            this.btnAdilson.BackgroundImage = global::kingme.Properties.Resources.Sem_titulo_4;
            this.btnAdilson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdilson.FlatAppearance.BorderSize = 0;
            this.btnAdilson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdilson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdilson.Location = new System.Drawing.Point(551, 28);
            this.btnAdilson.Name = "btnAdilson";
            this.btnAdilson.Size = new System.Drawing.Size(98, 139);
            this.btnAdilson.TabIndex = 68;
            this.btnAdilson.UseVisualStyleBackColor = false;
            // 
            // btnHeredia
            // 
            this.btnHeredia.BackColor = System.Drawing.Color.Transparent;
            this.btnHeredia.BackgroundImage = global::kingme.Properties.Resources.heredia;
            this.btnHeredia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHeredia.FlatAppearance.BorderSize = 0;
            this.btnHeredia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHeredia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeredia.Location = new System.Drawing.Point(430, 25);
            this.btnHeredia.Name = "btnHeredia";
            this.btnHeredia.Size = new System.Drawing.Size(98, 139);
            this.btnHeredia.TabIndex = 67;
            this.btnHeredia.UseVisualStyleBackColor = false;
            // 
            // btnDouglas
            // 
            this.btnDouglas.BackColor = System.Drawing.Color.Transparent;
            this.btnDouglas.BackgroundImage = global::kingme.Properties.Resources.douglas;
            this.btnDouglas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDouglas.FlatAppearance.BorderSize = 0;
            this.btnDouglas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDouglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDouglas.Location = new System.Drawing.Point(298, 25);
            this.btnDouglas.Name = "btnDouglas";
            this.btnDouglas.Size = new System.Drawing.Size(98, 139);
            this.btnDouglas.TabIndex = 66;
            this.btnDouglas.UseVisualStyleBackColor = false;
            // 
            // btnMario
            // 
            this.btnMario.BackColor = System.Drawing.Color.Transparent;
            this.btnMario.BackgroundImage = global::kingme.Properties.Resources.mario;
            this.btnMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMario.FlatAppearance.BorderSize = 0;
            this.btnMario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMario.Location = new System.Drawing.Point(165, 28);
            this.btnMario.Name = "btnMario";
            this.btnMario.Size = new System.Drawing.Size(98, 139);
            this.btnMario.TabIndex = 65;
            this.btnMario.UseVisualStyleBackColor = false;
            // 
            // rdoRanulfo
            // 
            this.rdoRanulfo.AutoSize = true;
            this.rdoRanulfo.BackColor = System.Drawing.Color.Transparent;
            this.rdoRanulfo.Location = new System.Drawing.Point(106, 350);
            this.rdoRanulfo.Name = "rdoRanulfo";
            this.rdoRanulfo.Size = new System.Drawing.Size(14, 13);
            this.rdoRanulfo.TabIndex = 87;
            this.rdoRanulfo.TabStop = true;
            this.rdoRanulfo.UseVisualStyleBackColor = false;
            // 
            // rdoQuintas
            // 
            this.rdoQuintas.AutoSize = true;
            this.rdoQuintas.BackColor = System.Drawing.Color.Transparent;
            this.rdoQuintas.Location = new System.Drawing.Point(751, 190);
            this.rdoQuintas.Name = "rdoQuintas";
            this.rdoQuintas.Size = new System.Drawing.Size(14, 13);
            this.rdoQuintas.TabIndex = 86;
            this.rdoQuintas.TabStop = true;
            this.rdoQuintas.UseVisualStyleBackColor = false;
            // 
            // rdoToshio
            // 
            this.rdoToshio.AutoSize = true;
            this.rdoToshio.BackColor = System.Drawing.Color.Transparent;
            this.rdoToshio.Location = new System.Drawing.Point(635, 190);
            this.rdoToshio.Name = "rdoToshio";
            this.rdoToshio.Size = new System.Drawing.Size(14, 13);
            this.rdoToshio.TabIndex = 85;
            this.rdoToshio.TabStop = true;
            this.rdoToshio.UseVisualStyleBackColor = false;
            // 
            // btnToshio
            // 
            this.btnToshio.BackColor = System.Drawing.Color.Transparent;
            this.btnToshio.BackgroundImage = global::kingme.Properties.Resources.toshio;
            this.btnToshio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnToshio.FlatAppearance.BorderSize = 0;
            this.btnToshio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnToshio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToshio.Location = new System.Drawing.Point(551, 190);
            this.btnToshio.Name = "btnToshio";
            this.btnToshio.Size = new System.Drawing.Size(98, 139);
            this.btnToshio.TabIndex = 74;
            this.btnToshio.UseVisualStyleBackColor = false;
            // 
            // btnQuintas
            // 
            this.btnQuintas.BackColor = System.Drawing.Color.Transparent;
            this.btnQuintas.BackgroundImage = global::kingme.Properties.Resources.quintas;
            this.btnQuintas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuintas.FlatAppearance.BorderSize = 0;
            this.btnQuintas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuintas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuintas.Location = new System.Drawing.Point(667, 190);
            this.btnQuintas.Name = "btnQuintas";
            this.btnQuintas.Size = new System.Drawing.Size(98, 139);
            this.btnQuintas.TabIndex = 75;
            this.btnQuintas.UseVisualStyleBackColor = false;
            // 
            // btnRanulfo
            // 
            this.btnRanulfo.BackColor = System.Drawing.Color.Transparent;
            this.btnRanulfo.BackgroundImage = global::kingme.Properties.Resources.ranulfo;
            this.btnRanulfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRanulfo.FlatAppearance.BorderSize = 0;
            this.btnRanulfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRanulfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanulfo.Location = new System.Drawing.Point(22, 350);
            this.btnRanulfo.Name = "btnRanulfo";
            this.btnRanulfo.Size = new System.Drawing.Size(98, 139);
            this.btnRanulfo.TabIndex = 76;
            this.btnRanulfo.UseVisualStyleBackColor = false;
            // 
            // pboSetorUm
            // 
            this.pboSetorUm.BackgroundImage = global::kingme.Properties.Resources.setor1;
            this.pboSetorUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorUm.Location = new System.Drawing.Point(449, 729);
            this.pboSetorUm.Name = "pboSetorUm";
            this.pboSetorUm.Size = new System.Drawing.Size(406, 141);
            this.pboSetorUm.TabIndex = 66;
            this.pboSetorUm.TabStop = false;
            // 
            // pboSetorZero
            // 
            this.pboSetorZero.BackgroundImage = global::kingme.Properties.Resources.setor0;
            this.pboSetorZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorZero.Location = new System.Drawing.Point(449, 870);
            this.pboSetorZero.Name = "pboSetorZero";
            this.pboSetorZero.Size = new System.Drawing.Size(406, 133);
            this.pboSetorZero.TabIndex = 67;
            this.pboSetorZero.TabStop = false;
            // 
            // pboSetorDois
            // 
            this.pboSetorDois.BackgroundImage = global::kingme.Properties.Resources.setor2;
            this.pboSetorDois.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorDois.Location = new System.Drawing.Point(449, 588);
            this.pboSetorDois.Name = "pboSetorDois";
            this.pboSetorDois.Size = new System.Drawing.Size(406, 141);
            this.pboSetorDois.TabIndex = 68;
            this.pboSetorDois.TabStop = false;
            // 
            // pboSetorCinco
            // 
            this.pboSetorCinco.BackgroundImage = global::kingme.Properties.Resources.setor5;
            this.pboSetorCinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorCinco.Location = new System.Drawing.Point(449, 165);
            this.pboSetorCinco.Name = "pboSetorCinco";
            this.pboSetorCinco.Size = new System.Drawing.Size(406, 141);
            this.pboSetorCinco.TabIndex = 71;
            this.pboSetorCinco.TabStop = false;
            // 
            // pboSetorTres
            // 
            this.pboSetorTres.BackgroundImage = global::kingme.Properties.Resources.setor3;
            this.pboSetorTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorTres.Location = new System.Drawing.Point(449, 447);
            this.pboSetorTres.Name = "pboSetorTres";
            this.pboSetorTres.Size = new System.Drawing.Size(406, 141);
            this.pboSetorTres.TabIndex = 70;
            this.pboSetorTres.TabStop = false;
            // 
            // pboSetorQuatro
            // 
            this.pboSetorQuatro.BackgroundImage = global::kingme.Properties.Resources.setor4;
            this.pboSetorQuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorQuatro.Location = new System.Drawing.Point(449, 306);
            this.pboSetorQuatro.Name = "pboSetorQuatro";
            this.pboSetorQuatro.Size = new System.Drawing.Size(406, 141);
            this.pboSetorQuatro.TabIndex = 69;
            this.pboSetorQuatro.TabStop = false;
            // 
            // pboSetorDez
            // 
            this.pboSetorDez.BackgroundImage = global::kingme.Properties.Resources.setor10;
            this.pboSetorDez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboSetorDez.Location = new System.Drawing.Point(449, 24);
            this.pboSetorDez.Name = "pboSetorDez";
            this.pboSetorDez.Size = new System.Drawing.Size(406, 141);
            this.pboSetorDez.TabIndex = 72;
            this.pboSetorDez.TabStop = false;
            // 
            // btnPromote
            // 
            this.btnPromote.BackColor = System.Drawing.Color.Black;
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPromote.Font = new System.Drawing.Font("Old London Alternate", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromote.ForeColor = System.Drawing.Color.White;
            this.btnPromote.Location = new System.Drawing.Point(1641, 697);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(108, 32);
            this.btnPromote.TabIndex = 73;
            this.btnPromote.Text = "Promover";
            this.btnPromote.UseVisualStyleBackColor = false;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // tmrAutomacao
            // 
            this.tmrAutomacao.Interval = 5000;
            this.tmrAutomacao.Tick += new System.EventHandler(this.tmrAutomacao_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kingme.Properties.Resources.texture1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1806, 1015);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.pboSetorDez);
            this.Controls.Add(this.pboSetorCinco);
            this.Controls.Add(this.pboSetorTres);
            this.Controls.Add(this.pboSetorQuatro);
            this.Controls.Add(this.pboSetorDois);
            this.Controls.Add(this.pboSetorZero);
            this.Controls.Add(this.pboSetorUm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayerNameValue);
            this.Controls.Add(this.lblPlayerIdValue);
            this.Controls.Add(this.lblIdPlayerTurn);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.btnVerifyTurn);
            this.Controls.Add(this.lstSections);
            this.Controls.Add(this.btnSetCharacter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnInitializeMatch);
            this.Controls.Add(this.lstCards);
            this.Controls.Add(this.lstMatchPlayers);
            this.Controls.Add(this.lblListPlayers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerPassword);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnUpdatePlayerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardsContent);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.btnListCards);
            this.Controls.Add(this.txtPlayerId);
            this.Controls.Add(this.lblCardsTitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorQuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboSetorDez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCardsTitle;
        private System.Windows.Forms.Button btnListCards;
        private System.Windows.Forms.Label lblCardsContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Button btnUpdatePlayerList;
        private System.Windows.Forms.Label lblPlayerPassword;
        private System.Windows.Forms.Label lblListPlayers;
        private System.Windows.Forms.ListBox lstMatchPlayers;
        private System.Windows.Forms.Button btnInitializeMatch;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetCharacter;
        private System.Windows.Forms.ListBox lstSections;
        private System.Windows.Forms.Button btnVerifyTurn;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblIdPlayerTurn;
        private System.Windows.Forms.Label lblPlayerIdValue;
        private System.Windows.Forms.Label lblPlayerNameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBeatrizPaiva;
        private System.Windows.Forms.RadioButton rdoBeatriz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRanulfo;
        private System.Windows.Forms.Button btnQuintas;
        private System.Windows.Forms.Button btnToshio;
        private System.Windows.Forms.Button btnLeonardo;
        private System.Windows.Forms.Button btnKelly;
        private System.Windows.Forms.Button btnGuilherme;
        private System.Windows.Forms.Button btnEduardo;
        private System.Windows.Forms.Button btnClaro;
        private System.Windows.Forms.Button btnAdilson;
        private System.Windows.Forms.Button btnHeredia;
        private System.Windows.Forms.Button btnDouglas;
        private System.Windows.Forms.Button btnMario;
        private System.Windows.Forms.RadioButton rdoMario;
        private System.Windows.Forms.RadioButton rdoRanulfo;
        private System.Windows.Forms.RadioButton rdoQuintas;
        private System.Windows.Forms.RadioButton rdoToshio;
        private System.Windows.Forms.RadioButton rdoLeonardo;
        private System.Windows.Forms.RadioButton rdoGuilherme;
        private System.Windows.Forms.RadioButton rdoEduardo;
        private System.Windows.Forms.RadioButton rdoKelly;
        private System.Windows.Forms.RadioButton rdoClaro;
        private System.Windows.Forms.RadioButton rdoAdilson;
        private System.Windows.Forms.RadioButton rdoHeredia;
        private System.Windows.Forms.RadioButton rdoDouglas;
        private System.Windows.Forms.PictureBox pboSetorUm;
        private System.Windows.Forms.PictureBox pboSetorZero;
        private System.Windows.Forms.PictureBox pboSetorDois;
        private System.Windows.Forms.PictureBox pboSetorCinco;
        private System.Windows.Forms.PictureBox pboSetorTres;
        private System.Windows.Forms.PictureBox pboSetorQuatro;
        private System.Windows.Forms.PictureBox pboSetorDez;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Timer tmrAutomacao;
    }
}