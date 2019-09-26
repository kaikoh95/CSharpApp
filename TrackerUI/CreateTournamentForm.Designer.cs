namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(786, 115);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.Location = new System.Drawing.Point(348, 153);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(437, 65);
            this.tournamentNameLabel.TabIndex = 8;
            this.tournamentNameLabel.Text = "Tournament Name:";
            this.tournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Location = new System.Drawing.Point(833, 153);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(639, 72);
            this.tournamentNameTextBox.TabIndex = 9;
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Location = new System.Drawing.Point(833, 269);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(216, 72);
            this.entryFeeTextBox.TabIndex = 11;
            this.entryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.Location = new System.Drawing.Point(552, 257);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(233, 65);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry Fee:";
            this.entryFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(487, 474);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(541, 72);
            this.selectTeamComboBox.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Impact", 15.75F);
            this.selectTeamLabel.Location = new System.Drawing.Point(506, 381);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(292, 65);
            this.selectTeamLabel.TabIndex = 12;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectTeamLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Font = new System.Drawing.Font("Impact", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(827, 400);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(171, 42);
            this.createNewTeamLinkLabel.TabIndex = 14;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Location = new System.Drawing.Point(129, 597);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(357, 77);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Location = new System.Drawing.Point(1005, 597);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(357, 77);
            this.createPrizeButton.TabIndex = 16;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 64;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(32, 793);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(597, 388);
            this.tournamentPlayersListBox.TabIndex = 17;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Impact", 15.75F);
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(118, 716);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(373, 65);
            this.tournamentPlayersLabel.TabIndex = 18;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            this.tournamentPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteSelectedPlayerButton
            // 
            this.deleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayerButton.Font = new System.Drawing.Font("Impact", 10.75F);
            this.deleteSelectedPlayerButton.Location = new System.Drawing.Point(163, 1221);
            this.deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            this.deleteSelectedPlayerButton.Size = new System.Drawing.Size(231, 77);
            this.deleteSelectedPlayerButton.TabIndex = 19;
            this.deleteSelectedPlayerButton.Text = "Delete Player";
            this.deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Impact", 10.75F);
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(1061, 1221);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(226, 77);
            this.deleteSelectedPrizeButton.TabIndex = 22;
            this.deleteSelectedPrizeButton.Text = "Delete Prize";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Impact", 15.75F);
            this.prizesLabel.Location = new System.Drawing.Point(1105, 716);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(160, 65);
            this.prizesLabel.TabIndex = 21;
            this.prizesLabel.Text = "Prizes";
            this.prizesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 64;
            this.prizesListBox.Location = new System.Drawing.Point(882, 807);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(597, 388);
            this.prizesListBox.TabIndex = 20;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Impact", 15.75F);
            this.createTournamentButton.Location = new System.Drawing.Point(502, 1292);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(481, 77);
            this.createTournamentButton.TabIndex = 23;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 64F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1527, 1395);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayerButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamComboBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}