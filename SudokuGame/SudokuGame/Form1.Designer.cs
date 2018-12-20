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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuMainForm));
            this.SudokuMainMenu = new System.Windows.Forms.MenuStrip();
            this.SudokuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.solveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuHighScore = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SudokuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SudokuMainMenu
            // 
            this.SudokuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SudokuNewGame,
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
            this.SudokuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SudokuMainMenu_ItemClicked);
            // 
            // SudokuNewGame
            // 
            this.SudokuNewGame.Name = "SudokuNewGame";
            this.SudokuNewGame.Size = new System.Drawing.Size(77, 20);
            this.SudokuNewGame.Text = "New Game";
            this.SudokuNewGame.Click += new System.EventHandler(this.SudokuNewGame_Click);
            // 
            // SudokuLoadGame
            // 
            this.SudokuLoadGame.Name = "SudokuLoadGame";
            this.SudokuLoadGame.Size = new System.Drawing.Size(79, 20);
            this.SudokuLoadGame.Text = "Load Game";
            this.SudokuLoadGame.Click += new System.EventHandler(this.SudokuLoadGame_Click);
            // 
            // SudokuValidate
            // 
            this.SudokuValidate.Name = "SudokuValidate";
            this.SudokuValidate.Size = new System.Drawing.Size(60, 20);
            this.SudokuValidate.Text = "Validate";
            this.SudokuValidate.Click += new System.EventHandler(this.SudokuValidate_Click);
            // 
            // solveToolStripMenuItem
            // 
            this.solveToolStripMenuItem.Name = "solveToolStripMenuItem";
            this.solveToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.solveToolStripMenuItem.Text = "Solve";
            // 
            // SudokuHighScore
            // 
            this.SudokuHighScore.Name = "SudokuHighScore";
            this.SudokuHighScore.Size = new System.Drawing.Size(77, 20);
            this.SudokuHighScore.Text = "High Score";
            this.SudokuHighScore.Click += new System.EventHandler(this.SudokuHighScore_Click);
            // 
            // SudokuHelp
            // 
            this.SudokuHelp.Name = "SudokuHelp";
            this.SudokuHelp.Size = new System.Drawing.Size(44, 20);
            this.SudokuHelp.Text = "Help";
            this.SudokuHelp.Click += new System.EventHandler(this.SudokuHelp_Click);
            // 
            // SudokuAbout
            // 
            this.SudokuAbout.Name = "SudokuAbout";
            this.SudokuAbout.Size = new System.Drawing.Size(52, 20);
            this.SudokuAbout.Text = "About";
            this.SudokuAbout.Click += new System.EventHandler(this.SudokuAbout_Click);
            // 
            // SudokuExit
            // 
            this.SudokuExit.Name = "SudokuExit";
            this.SudokuExit.Size = new System.Drawing.Size(37, 20);
            this.SudokuExit.Text = "Exit";
            this.SudokuExit.Click += new System.EventHandler(this.SudokuExit_Click);
            // 
            // SudokuTable
            // 
            this.SudokuTable.AllowUserToAddRows = false;
            this.SudokuTable.AllowUserToDeleteRows = false;
            this.SudokuTable.AllowUserToResizeColumns = false;
            this.SudokuTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SudokuTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SudokuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SudokuTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SudokuTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.SudokuTable.GridColor = System.Drawing.Color.Black;
            this.SudokuTable.Location = new System.Drawing.Point(408, 58);
            this.SudokuTable.MultiSelect = false;
            this.SudokuTable.Name = "SudokuTable";
            this.SudokuTable.RowHeadersVisible = false;
            this.SudokuTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SudokuTable.Size = new System.Drawing.Size(367, 345);
            this.SudokuTable.TabIndex = 1;
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
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SudokuTable);
            this.Controls.Add(this.SudokuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.SudokuMainMenu;
            this.MaximizeBox = false;
            this.Name = "SudokuMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Game";
            this.Load += new System.EventHandler(this.SudokuMainForm_Load);
            this.SudokuMainMenu.ResumeLayout(false);
            this.SudokuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SudokuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem SudokuNewGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuLoadGame;
        private System.Windows.Forms.DataGridView SudokuTable;
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
    }
}

