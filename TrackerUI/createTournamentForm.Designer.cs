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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPriceButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectPlayerButton = new System.Windows.Forms.Button();
            this.deleteSelectedPriceButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.createTournamentLabel.Location = new System.Drawing.Point(28, 42);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(463, 65);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Tag = "HeaderLabel";
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(67, 212);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(300, 29);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tournamentNameLabel.Location = new System.Drawing.Point(62, 168);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(175, 25);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(215, 287);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 29);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Location = new System.Drawing.Point(73, 290);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(96, 25);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(78, 433);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(318, 32);
            this.selectTeamDropdown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Location = new System.Drawing.Point(73, 391);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(123, 25);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(267, 391);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(120, 25);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New ";
            // 
            // addTeamButton
            // 
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTeamButton.Location = new System.Drawing.Point(160, 486);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(186, 39);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPriceButton
            // 
            this.createPriceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPriceButton.Location = new System.Drawing.Point(160, 580);
            this.createPriceButton.Name = "createPriceButton";
            this.createPriceButton.Size = new System.Drawing.Size(186, 39);
            this.createPriceButton.TabIndex = 17;
            this.createPriceButton.Text = "Create Prize";
            this.createPriceButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 24;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(580, 212);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(387, 148);
            this.tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(575, 168);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(154, 25);
            this.tournamentPlayersLabel.TabIndex = 19;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectPlayerButton
            // 
            this.deleteSelectPlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteSelectPlayerButton.Location = new System.Drawing.Point(818, 160);
            this.deleteSelectPlayerButton.Name = "deleteSelectPlayerButton";
            this.deleteSelectPlayerButton.Size = new System.Drawing.Size(149, 33);
            this.deleteSelectPlayerButton.TabIndex = 20;
            this.deleteSelectPlayerButton.Text = "Delete";
            this.deleteSelectPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPriceButton
            // 
            this.deleteSelectedPriceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteSelectedPriceButton.Location = new System.Drawing.Point(818, 448);
            this.deleteSelectedPriceButton.Name = "deleteSelectedPriceButton";
            this.deleteSelectedPriceButton.Size = new System.Drawing.Size(149, 33);
            this.deleteSelectedPriceButton.TabIndex = 23;
            this.deleteSelectedPriceButton.Text = "Delete";
            this.deleteSelectedPriceButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Location = new System.Drawing.Point(575, 456);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(66, 25);
            this.prizesLabel.TabIndex = 22;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 24;
            this.prizesListBox.Location = new System.Drawing.Point(580, 500);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(387, 148);
            this.prizesListBox.TabIndex = 21;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTournamentButton.Location = new System.Drawing.Point(394, 686);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(335, 109);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1149, 835);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPriceButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectPlayerButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPriceButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPriceButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectPlayerButton;
        private System.Windows.Forms.Button deleteSelectedPriceButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}