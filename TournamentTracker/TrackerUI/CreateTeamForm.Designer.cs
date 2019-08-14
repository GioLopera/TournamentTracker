namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.createNewMemberLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.Teal;
            this.addMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.LightCyan;
            this.addMemberButton.Location = new System.Drawing.Point(55, 277);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(420, 63);
            this.addMemberButton.TabIndex = 26;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.Teal;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(48, 167);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(283, 38);
            this.selectTeamMemberLabel.TabIndex = 25;
            this.selectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(55, 208);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(420, 45);
            this.selectTeamMemberDropDown.TabIndex = 24;
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(55, 112);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(420, 43);
            this.teamNameValue.TabIndex = 23;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.teamNameLabel.Location = new System.Drawing.Point(48, 71);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(170, 38);
            this.teamNameLabel.TabIndex = 22;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Teal;
            this.headerLabel.Location = new System.Drawing.Point(417, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(276, 65);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "Create Team";
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.OrangeRed;
            this.createTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.LightCyan;
            this.createTeamButton.Location = new System.Drawing.Point(55, 387);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(1008, 63);
            this.createTeamButton.TabIndex = 31;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removeSelectedMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.Teal;
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(950, 172);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(113, 94);
            this.removeSelectedMemberButton.TabIndex = 30;
            this.removeSelectedMemberButton.Text = "Delete Selected";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = false;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.ItemHeight = 37;
            this.teamMemberListBox.Location = new System.Drawing.Point(498, 113);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(430, 224);
            this.teamMemberListBox.TabIndex = 29;
            // 
            // createNewMemberLabel
            // 
            this.createNewMemberLabel.AutoSize = true;
            this.createNewMemberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewMemberLabel.Location = new System.Drawing.Point(394, 174);
            this.createNewMemberLabel.Name = "createNewMemberLabel";
            this.createNewMemberLabel.Size = new System.Drawing.Size(86, 28);
            this.createNewMemberLabel.TabIndex = 32;
            this.createNewMemberLabel.TabStop = true;
            this.createNewMemberLabel.Text = "add new";
            this.createNewMemberLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewMemberLabel_LinkClicked);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1110, 506);
            this.Controls.Add(this.createNewMemberLabel);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button removeSelectedMemberButton;
        private System.Windows.Forms.ListBox teamMemberListBox;
        private System.Windows.Forms.LinkLabel createNewMemberLabel;
    }
}