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
            this.GameInstructor = new System.Windows.Forms.TextBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SudokuGameInstructorContainer = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).BeginInit();
            this.SudokuDifficultySelectorContainer.SuspendLayout();
            this.SudokuTimerContainer.SuspendLayout();
            this.SudokuGameInstructorContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.SudokuTable.Location = new System.Drawing.Point(397, 19);
            this.SudokuTable.Margin = new System.Windows.Forms.Padding(10);
            this.SudokuTable.MultiSelect = false;
            this.SudokuTable.Name = "SudokuTable";
            this.SudokuTable.RowHeadersVisible = false;
            this.SudokuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SudokuTable.Size = new System.Drawing.Size(360, 370);
            this.SudokuTable.TabIndex = 0;
            this.SudokuTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SudokuTable_CellEndEdit);
            this.SudokuTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SudokuTable_CellEnter);
            this.SudokuTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SudokuTable_CellValidating);
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
            this.SudokuDifficultySelector.Size = new System.Drawing.Size(121, 24);
            this.SudokuDifficultySelector.TabIndex = 6;
            this.SudokuDifficultySelector.SelectedIndexChanged += new System.EventHandler(this.SudokuDifficultySelector_SelectedIndexChanged);
            // 
            // SudokuDifficultySelectorContainer
            // 
            this.SudokuDifficultySelectorContainer.Controls.Add(this.SudokuDifficultySelector);
            this.SudokuDifficultySelectorContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SudokuDifficultySelectorContainer.Location = new System.Drawing.Point(25, 19);
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
            this.SudokuTimerContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SudokuTimerContainer.Location = new System.Drawing.Point(208, 19);
            this.SudokuTimerContainer.Name = "SudokuTimerContainer";
            this.SudokuTimerContainer.Size = new System.Drawing.Size(162, 73);
            this.SudokuTimerContainer.TabIndex = 14;
            this.SudokuTimerContainer.TabStop = false;
            this.SudokuTimerContainer.Text = "Game Timer";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(96, 98);
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
            this.TriggerButton.Location = new System.Drawing.Point(25, 98);
            this.TriggerButton.Name = "TriggerButton";
            this.TriggerButton.Size = new System.Drawing.Size(55, 55);
            this.TriggerButton.TabIndex = 16;
            this.TriggerButton.Text = "Start Game";
            this.TriggerButton.UseVisualStyleBackColor = true;
            this.TriggerButton.Click += new System.EventHandler(this.TriggerButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(170, 98);
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
            this.ValidateButton.Location = new System.Drawing.Point(243, 98);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(55, 55);
            this.ValidateButton.TabIndex = 18;
            this.ValidateButton.Text = "Validate Sudoku";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // GameInstructor
            // 
            this.GameInstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GameInstructor.Location = new System.Drawing.Point(6, 19);
            this.GameInstructor.Multiline = true;
            this.GameInstructor.Name = "GameInstructor";
            this.GameInstructor.ReadOnly = true;
            this.GameInstructor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameInstructor.Size = new System.Drawing.Size(250, 184);
            this.GameInstructor.TabIndex = 19;
            this.GameInstructor.Text = "Please choose difficulty before start a new game\r\nIf you don\'t want to start a ne" +
    "w game, you can load game from proper save file\r\nOnly beginner difficulty has ga" +
    "me helper\r\n";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(294, 226);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(76, 50);
            this.HelpButton.TabIndex = 20;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(294, 282);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(76, 50);
            this.AboutButton.TabIndex = 21;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SudokuGameInstructorContainer
            // 
            this.SudokuGameInstructorContainer.Controls.Add(this.GameInstructor);
            this.SudokuGameInstructorContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SudokuGameInstructorContainer.Location = new System.Drawing.Point(25, 169);
            this.SudokuGameInstructorContainer.Name = "SudokuGameInstructorContainer";
            this.SudokuGameInstructorContainer.Size = new System.Drawing.Size(263, 220);
            this.SudokuGameInstructorContainer.TabIndex = 22;
            this.SudokuGameInstructorContainer.TabStop = false;
            this.SudokuGameInstructorContainer.Text = "Game Instructor";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(294, 338);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 50);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Enabled = false;
            this.SolveButton.Location = new System.Drawing.Point(315, 98);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(55, 55);
            this.SolveButton.TabIndex = 24;
            this.SolveButton.Text = "Solve Sudoku";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Enabled = false;
            this.NewGameButton.Location = new System.Drawing.Point(294, 169);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(76, 50);
            this.NewGameButton.TabIndex = 25;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 402);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.TriggerButton);
            this.Controls.Add(this.SudokuTable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SudokuGameInstructorContainer);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SudokuTimerContainer);
            this.Controls.Add(this.SudokuDifficultySelectorContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SudokuMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SudokuMainForm_FormClosing);
            this.Load += new System.EventHandler(this.SudokuMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).EndInit();
            this.SudokuDifficultySelectorContainer.ResumeLayout(false);
            this.SudokuTimerContainer.ResumeLayout(false);
            this.SudokuTimerContainer.PerformLayout();
            this.SudokuGameInstructorContainer.ResumeLayout(false);
            this.SudokuGameInstructorContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView SudokuTable;
        private System.Windows.Forms.ComboBox SudokuDifficultySelector;
        private System.Windows.Forms.GroupBox SudokuDifficultySelectorContainer;
        private System.Windows.Forms.Label TimeCounter;
        private System.Windows.Forms.GroupBox SudokuTimerContainer;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button TriggerButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.TextBox GameInstructor;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.GroupBox SudokuGameInstructorContainer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button NewGameButton;
    }
}

