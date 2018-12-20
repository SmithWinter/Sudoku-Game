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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuMainForm));
            this.SudokuMainMenu = new System.Windows.Forms.MenuStrip();
            this.SudokuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SudokuMainMenu
            // 
            this.SudokuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SudokuNewGame,
            this.SudokuLoadGame,
            this.SudokuHelp,
            this.SudokuAbout});
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
            // SudokuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SudokuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem SudokuNewGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuLoadGame;
        private System.Windows.Forms.ToolStripMenuItem SudokuHelp;
        private System.Windows.Forms.ToolStripMenuItem SudokuAbout;
    }
}

