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
            this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuHighScore = new System.Windows.Forms.ToolStripMenuItem();
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
            this.EasySelector = new System.Windows.Forms.CheckBox();
            this.MediumSelector = new System.Windows.Forms.CheckBox();
            this.HardSelector = new System.Windows.Forms.CheckBox();
            this.DifficultySelector = new System.Windows.Forms.GroupBox();
            this.SudokuTable = new System.Windows.Forms.DataGridView();
            this.SudokuMainMenu.SuspendLayout();
            this.DifficultySelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SudokuMainMenu
            // 
            this.SudokuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SudokuNewGame,
            this.SudokuSaveGame,
            this.SudokuLoadGame,
            this.SudokuValidate,
            this.solveToolStripMenuItem,
            this.SudokuHighScore,
            this.SudokuHelp,
            this.SudokuAbout,
            this.SudokuExit});
            this.SudokuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.SudokuMainMenu.Name = "SudokuMainMenu";
            this.SudokuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.SudokuMainMenu.TabIndex = 0;
            this.SudokuMainMenu.Text = "SudokuMainMenu";
            // 
            // SudokuNewGame
            // 
            this.SudokuNewGame.Name = "SudokuNewGame";
            this.SudokuNewGame.Size = new System.Drawing.Size(100, 20);
            this.SudokuNewGame.Text = "New Game (F1)";
            this.SudokuNewGame.Click += new System.EventHandler(this.SudokuNewGame_Click);
            // 
            // SudokuSaveGame
            // 
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
            this.SudokuValidate.Name = "SudokuValidate";
            this.SudokuValidate.Size = new System.Drawing.Size(83, 20);
            this.SudokuValidate.Text = "Validate (F4)";
            this.SudokuValidate.Click += new System.EventHandler(this.SudokuValidate_Click);
            // 
            // solveToolStripMenuItem
            // 
            this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            this.solveToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.solveToolStripMenuItem.Text = "Solve (F5)";
            // 
            // SudokuHighScore
            // 
            this.SudokuHighScore.Name = "SudokuHighScore";
            this.SudokuHighScore.Size = new System.Drawing.Size(100, 20);
            this.SudokuHighScore.Text = "High Score (F6)";
            this.SudokuHighScore.Click += new System.EventHandler(this.SudokuHighScore_Click);
            // 
            // SudokuHelp
            // 
            this.SudokuHelp.Name = "SudokuHelp";
            this.SudokuHelp.Size = new System.Drawing.Size(67, 20);
            this.SudokuHelp.Text = "Help (F7)";
            this.SudokuHelp.Click += new System.EventHandler(this.SudokuHelp_Click);
            // 
            // SudokuAbout
            // 
            this.SudokuAbout.Name = "SudokuAbout";
            this.SudokuAbout.Size = new System.Drawing.Size(75, 20);
            this.SudokuAbout.Text = "About (F8)";
            this.SudokuAbout.Click += new System.EventHandler(this.SudokuAbout_Click);
            // 
            // SudokuExit
            // 
            this.SudokuExit.Name = "SudokuExit";
            this.SudokuExit.Size = new System.Drawing.Size(60, 20);
            this.SudokuExit.Text = "Exit (F9)";
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
            // EasySelector
            // 
            this.EasySelector.AutoSize = true;
            this.EasySelector.Location = new System.Drawing.Point(20, 30);
            this.EasySelector.Name = "EasySelector";
            this.EasySelector.Size = new System.Drawing.Size(49, 17);
            this.EasySelector.TabIndex = 1;
            this.EasySelector.Text = "Easy";
            this.EasySelector.UseVisualStyleBackColor = true;
            this.EasySelector.CheckedChanged += new System.EventHandler(this.EasySelector_CheckedChanged);
            // 
            // MediumSelector
            // 
            this.MediumSelector.AutoSize = true;
            this.MediumSelector.Location = new System.Drawing.Point(20, 53);
            this.MediumSelector.Name = "MediumSelector";
            this.MediumSelector.Size = new System.Drawing.Size(63, 17);
            this.MediumSelector.TabIndex = 2;
            this.MediumSelector.Text = "Medium";
            this.MediumSelector.UseVisualStyleBackColor = true;
            this.MediumSelector.CheckedChanged += new System.EventHandler(this.MediumSelector_CheckedChanged);
            // 
            // HardSelector
            // 
            this.HardSelector.AutoSize = true;
            this.HardSelector.Location = new System.Drawing.Point(20, 76);
            this.HardSelector.Name = "HardSelector";
            this.HardSelector.Size = new System.Drawing.Size(49, 17);
            this.HardSelector.TabIndex = 3;
            this.HardSelector.Text = "Hard";
            this.HardSelector.UseVisualStyleBackColor = true;
            this.HardSelector.CheckedChanged += new System.EventHandler(this.HardSelector_CheckedChanged);
            // 
            // DifficultySelector
            // 
            this.DifficultySelector.Controls.Add(this.HardSelector);
            this.DifficultySelector.Controls.Add(this.MediumSelector);
            this.DifficultySelector.Controls.Add(this.EasySelector);
            this.DifficultySelector.Location = new System.Drawing.Point(25, 46);
            this.DifficultySelector.Name = "DifficultySelector";
            this.DifficultySelector.Size = new System.Drawing.Size(115, 110);
            this.DifficultySelector.TabIndex = 4;
            this.DifficultySelector.TabStop = false;
            this.DifficultySelector.Text = "Difficulty Selector";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.SudokuTable.GridColor = System.Drawing.Color.Black;
            this.SudokuTable.Location = new System.Drawing.Point(399, 46);
            this.SudokuTable.Margin = new System.Windows.Forms.Padding(10);
            this.SudokuTable.MultiSelect = false;
            this.SudokuTable.Name = "SudokuTable";
            this.SudokuTable.RowHeadersVisible = false;
            this.SudokuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SudokuTable.Size = new System.Drawing.Size(367, 345);
            this.SudokuTable.TabIndex = 0;
            this.SudokuTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SudokuTable_CellValidating);
            this.SudokuTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.SudokuTable_DataBindingComplete);
            // 
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SudokuTable);
            this.Controls.Add(this.DifficultySelector);
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
            this.DifficultySelector.ResumeLayout(false);
            this.DifficultySelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SudokuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem SudokuNewGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuLoadGame;
        private System.Windows.Forms.ToolStripMenuItem solveToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem SudokuHighScore;
        private System.Windows.Forms.ToolStripMenuItem SudokuSaveGame;
        private System.Windows.Forms.CheckBox EasySelector;
        private System.Windows.Forms.CheckBox MediumSelector;
        private System.Windows.Forms.CheckBox HardSelector;
        private System.Windows.Forms.GroupBox DifficultySelector;
        private System.Windows.Forms.DataGridView SudokuTable;
    }
}

