namespace SudokuGame
{
    partial class SudokuMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuMainForm));
            this.SudokuMainMenu = new System.Windows.Forms.MenuStrip();
            this.SudokuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuSolver = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SudokuTable = new System.Windows.Forms.DataGridView();
            this.SudokuDifficultySelector = new System.Windows.Forms.ComboBox();
            this.SudokuDifficultySelectorContainer = new System.Windows.Forms.GroupBox();
            this.TimeCounter = new System.Windows.Forms.Label();
            this.SudokuTimerContainer = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TriggerButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.HighScoreList = new System.Windows.Forms.TextBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SudokuHighScoreContainer = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.SudokuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).BeginInit();
            this.SudokuDifficultySelectorContainer.SuspendLayout();
            this.SudokuTimerContainer.SuspendLayout();
            this.SudokuHighScoreContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SudokuMainMenu
            // 
            this.SudokuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SudokuNewGame,
            this.SudokuSaveGame,
            this.SudokuLoadGame,
            this.SudokuValidate,
            this.SudokuSolver,
            this.SudokuHelp,
            this.SudokuAbout,
            this.SudokuExit});
            this.SudokuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.SudokuMainMenu.Name = "SudokuMainMenu";
            this.SudokuMainMenu.Size = new System.Drawing.Size(787, 24);
            this.SudokuMainMenu.TabIndex = 0;
            this.SudokuMainMenu.Text = "SudokuMainMenu";
            // 
            // SudokuNewGame
            // 
            this.SudokuNewGame.Enabled = false;
            this.SudokuNewGame.Name = "SudokuNewGame";
            this.SudokuNewGame.Size = new System.Drawing.Size(100, 20);
            this.SudokuNewGame.Text = "New Game (F1)";
            this.SudokuNewGame.Click += new System.EventHandler(this.SudokuNewGame_Click);
            // 
            // SudokuSaveGame
            // 
            this.SudokuSaveGame.Enabled = false;
            this.SudokuSaveGame.Name = "SudokuSaveGame";
            this.SudokuSaveGame.Size = new System.Drawing.Size(100, 20);
            this.SudokuSaveGame.Text = "Save Game (F2)";
            this.SudokuSaveGame.Click += new System.EventHandler(this.SudokuSaveGame_Click);
            // 
            // SudokuLoadGame
            // 
            this.SudokuLoadGame.Name = "SudokuLoadGame";
            this.SudokuLoadGame.Size = new System.Drawing.Size(102, 20);
            this.SudokuLoadGame.Text = "Load Game (F3)";
            this.SudokuLoadGame.Click += new System.EventHandler(this.SudokuLoadGame_Click);
            // 
            // SudokuValidate
            // 
            this.SudokuValidate.Enabled = false;
            this.SudokuValidate.Name = "SudokuValidate";
            this.SudokuValidate.Size = new System.Drawing.Size(83, 20);
            this.SudokuValidate.Text = "Validate (F4)";
            this.SudokuValidate.Click += new System.EventHandler(this.SudokuValidate_Click);
            // 
            // SudokuSolver
            // 
            this.SudokuSolver.Enabled = false;
            this.SudokuSolver.Name = "SudokuSolver";
            this.SudokuSolver.Size = new System.Drawing.Size(70, 20);
            this.SudokuSolver.Text = "Solve (F5)";
            // 
            // SudokuHelp
            // 
            this.SudokuHelp.Name = "SudokuHelp";
            this.SudokuHelp.Size = new System.Drawing.Size(67, 20);
            this.SudokuHelp.Text = "Help (F6)";
            this.SudokuHelp.Click += new System.EventHandler(this.SudokuHelp_Click);
            // 
            // SudokuAbout
            // 
            this.SudokuAbout.Name = "SudokuAbout";
            this.SudokuAbout.Size = new System.Drawing.Size(75, 20);
            this.SudokuAbout.Text = "About (F7)";
            this.SudokuAbout.Click += new System.EventHandler(this.SudokuAbout_Click);
            // 
            // SudokuExit
            // 
            this.SudokuExit.Name = "SudokuExit";
            this.SudokuExit.Size = new System.Drawing.Size(60, 20);
            this.SudokuExit.Text = "Exit (F8)";
            this.SudokuExit.Click += new System.EventHandler(this.SudokuExit_Click);
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.Name = "Column9";
            // 
            // SudokuTable
            // 
            this.SudokuTable.AllowUserToAddRows = false;
            this.SudokuTable.AllowUserToDeleteRows = false;
            this.SudokuTable.AllowUserToResizeColumns = false;
            this.SudokuTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SudokuTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SudokuTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SudokuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SudokuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SudokuTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SudokuTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.SudokuTable.Enabled = false;
            this.SudokuTable.GridColor = System.Drawing.Color.Black;
            this.SudokuTable.Location = new System.Drawing.Point(396, 60);
            this.SudokuTable.Margin = new System.Windows.Forms.Padding(10);
            this.SudokuTable.MultiSelect = false;
            this.SudokuTable.Name = "SudokuTable";
            this.SudokuTable.RowHeadersVisible = false;
            this.SudokuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SudokuTable.Size = new System.Drawing.Size(360, 370);
            this.SudokuTable.TabIndex = 0;
            this.SudokuTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SudokuTable_CellEndEdit);
            this.SudokuTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SudokuTable_CellValidating);
            this.SudokuTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.SudokuTable_DataBindingComplete);
            // 
            // SudokuDifficultySelector
            // 
            this.SudokuDifficultySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SudokuDifficultySelector.FormattingEnabled = true;
            this.SudokuDifficultySelector.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced",
            "Expert"});
            this.SudokuDifficultySelector.Location = new System.Drawing.Point(16, 25);
            this.SudokuDifficultySelector.Name = "SudokuDifficultySelector";
            this.SudokuDifficultySelector.Size = new System.Drawing.Size(121, 21);
            this.SudokuDifficultySelector.TabIndex = 6;
            this.SudokuDifficultySelector.SelectedIndexChanged += new System.EventHandler(this.SudokuDifficultySelector_SelectedIndexChanged);
            // 
            // SudokuDifficultySelectorContainer
            // 
            this.SudokuDifficultySelectorContainer.Controls.Add(this.SudokuDifficultySelector);
            this.SudokuDifficultySelectorContainer.Location = new System.Drawing.Point(25, 60);
            this.SudokuDifficultySelectorContainer.Name = "SudokuDifficultySelectorContainer";
            this.SudokuDifficultySelectorContainer.Size = new System.Drawing.Size(155, 73);
            this.SudokuDifficultySelectorContainer.TabIndex = 7;
            this.SudokuDifficultySelectorContainer.TabStop = false;
            this.SudokuDifficultySelectorContainer.Text = "Difficulty Selector";
            // 
            // TimeCounter
            // 
            this.TimeCounter.AutoSize = true;
            this.TimeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCounter.Location = new System.Drawing.Point(18, 25);
            this.TimeCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeCounter.Name = "TimeCounter";
            this.TimeCounter.Size = new System.Drawing.Size(128, 31);
            this.TimeCounter.TabIndex = 13;
            this.TimeCounter.Text = "00:00:00";
            // 
            // SudokuTimerContainer
            // 
            this.SudokuTimerContainer.Controls.Add(this.TimeCounter);
            this.SudokuTimerContainer.Location = new System.Drawing.Point(208, 60);
            this.SudokuTimerContainer.Name = "SudokuTimerContainer";
            this.SudokuTimerContainer.Size = new System.Drawing.Size(162, 73);
            this.SudokuTimerContainer.TabIndex = 14;
            this.SudokuTimerContainer.TabStop = false;
            this.SudokuTimerContainer.Text = "Game Timer";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(96, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(55, 55);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save Game";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TriggerButton
            // 
            this.TriggerButton.Enabled = false;
            this.TriggerButton.Location = new System.Drawing.Point(25, 140);
            this.TriggerButton.Name = "TriggerButton";
            this.TriggerButton.Size = new System.Drawing.Size(55, 55);
            this.TriggerButton.TabIndex = 16;
            this.TriggerButton.Text = "Start Game";
            this.TriggerButton.UseVisualStyleBackColor = true;
            this.TriggerButton.Click += new System.EventHandler(this.TriggerButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(169, 140);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(55, 55);
            this.LoadButton.TabIndex = 17;
            this.LoadButton.Text = "Load Game";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ValidateButton
            // 
            this.ValidateButton.Enabled = false;
            this.ValidateButton.Location = new System.Drawing.Point(242, 140);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(55, 55);
            this.ValidateButton.TabIndex = 18;
            this.ValidateButton.Text = "Validate Sudoku";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.Validate_Click);
            // 
            // HighScoreList
            // 
            this.HighScoreList.Location = new System.Drawing.Point(6, 19);
            this.HighScoreList.Multiline = true;
            this.HighScoreList.Name = "HighScoreList";
            this.HighScoreList.ReadOnly = true;
            this.HighScoreList.Size = new System.Drawing.Size(250, 184);
            this.HighScoreList.TabIndex = 19;
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(294, 231);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(76, 60);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(294, 297);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(76, 58);
            this.AboutButton.TabIndex = 21;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SudokuHighScoreContainer
            // 
            this.SudokuHighScoreContainer.Controls.Add(this.HighScoreList);
            this.SudokuHighScoreContainer.Location = new System.Drawing.Point(25, 218);
            this.SudokuHighScoreContainer.Name = "SudokuHighScoreContainer";
            this.SudokuHighScoreContainer.Size = new System.Drawing.Size(263, 209);
            this.SudokuHighScoreContainer.TabIndex = 22;
            this.SudokuHighScoreContainer.TabStop = false;
            this.SudokuHighScoreContainer.Text = "High Score";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(294, 361);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 60);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Enabled = false;
            this.SolveButton.Location = new System.Drawing.Point(315, 140);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(55, 55);
            this.SolveButton.TabIndex = 24;
            this.SolveButton.Text = "Solve Sudoku";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 453);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.TriggerButton);
            this.Controls.Add(this.SudokuTable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SudokuHighScoreContainer);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SudokuTimerContainer);
            this.Controls.Add(this.SudokuDifficultySelectorContainer);
            this.Controls.Add(this.SudokuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.SudokuMainMenu;
            this.MaximizeBox = false;
            this.Name = "SudokuMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SudokuMainForm_FormClosing);
            this.Load += new System.EventHandler(this.SudokuMainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SudokuMainForm_KeyDown);
            this.SudokuMainMenu.ResumeLayout(false);
            this.SudokuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).EndInit();
            this.SudokuDifficultySelectorContainer.ResumeLayout(false);
            this.SudokuTimerContainer.ResumeLayout(false);
            this.SudokuTimerContainer.PerformLayout();
            this.SudokuHighScoreContainer.ResumeLayout(false);
            this.SudokuHighScoreContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SudokuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem SudokuNewGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuLoadGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuSolver;
        private System.Windows.Forms.ToolStripMenuItem SudokuHelp;
        private System.Windows.Forms.ToolStripMenuItem SudokuAbout;
        private System.Windows.Forms.ToolStripMenuItem SudokuExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ToolStripMenuItem SudokuValidate;
        private System.Windows.Forms.ToolStripMenuItem SudokuSaveGame;
        private System.Windows.Forms.DataGridView SudokuTable;
        private System.Windows.Forms.ComboBox SudokuDifficultySelector;
        private System.Windows.Forms.GroupBox SudokuDifficultySelectorContainer;
        private System.Windows.Forms.Label TimeCounter;
        private System.Windows.Forms.GroupBox SudokuTimerContainer;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button TriggerButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.TextBox HighScoreList;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.GroupBox SudokuHighScoreContainer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SolveButton;
    }
}

