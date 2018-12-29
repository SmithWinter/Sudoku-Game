using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class SudokuMainForm : Form
    {
        //Global variables
        public  Random random = new Random();
        public int DifficultyIndicator;
        public int DeletedCellCounter;
        public int[,] SudokuMatrix = new int[9, 9];
        public int[,] SudokuSolve = new int[9, 9];
        //Custom Functon
        public void BuildSudokuTable ()
        {                    
        //This function render Sudoku table as DataGridView
        //Initialize DataGridView
        SudokuTable.ColumnCount = 9;
            SudokuTable.Rows.Add(9);               
            //Run loop to render column and row and limit cell input is 1 character
            for (int i = 0; i < 9; i++)
            {
                DataGridViewColumn column = SudokuTable.Columns[i];
                ((DataGridViewTextBoxColumn) column).MaxInputLength = 1;
                column.Width = (int)(SudokuTable.Width / 9f);
                DataGridViewRow row = SudokuTable.Rows[i];
                row.Height = (int)(SudokuTable.Height / 9f);
            }
            //Set width to DataGridView column
            SudokuTable.Width = SudokuTable.Columns[1].Width * 9;        
            //Run loop to fill LightCyan color to DataGridView
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SudokuTable.Rows[i].Cells[j].Style.BackColor = Color.LightCyan;
                }
            }
            //Run loop to fill LightBlue color to DataGridView
            for (int i = 0; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    SudokuTable.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    SudokuTable.Rows[j].Cells[i].Style.BackColor = Color.LightBlue;
                }
            }
            //Run loop to fill LightCyan color to DataGridView
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    SudokuTable.Rows[i].Cells[j].Style.BackColor = Color.LightCyan;
                }
            }
            SudokuTable.Enabled = false;
            SudokuTable.ClearSelection();
        }
        public void NewGame()
        {
            //This function will pop up confirmation box and ask user if he/she want to create a new game
            //If yes then reset the main form 
            //For protect user's process if he/she accidentally press F1 button  
            DialogResult result = MessageBox.Show("Are you sure you want to create a new game", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                SudokuMainForm New_SudokuMainForm = new SudokuMainForm();
                New_SudokuMainForm.Show();
                this.Dispose(false);
            }
        }
        public void AboutGame()
        {
            MessageBox.Show("Contributor of game's sourcecode \n\n 1. Hồ Vũ Minh Đức \n 2. Nguyễn Duy Hiếu \n 3. Đỗ Quốc Khánh",  "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExitGame()
        {
            //This function will pop up confirmation box and ask user if he/she want to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        public void CreateRandomPuzzle()
        {
            switch (DifficultyIndicator)
            {
                case 1:
                    DeletedCellCounter = random.Next(30, 39);
                    break;
                case 2:
                    DeletedCellCounter = random.Next(40, 49);
                    break;
                case 3:
                    DeletedCellCounter = random.Next(50, 59);
                    break;
            }
            for (int i = 0; i < SudokuMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < SudokuMatrix.GetLength(1); j++)
                {
                    SudokuMatrix[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
            Randomize.Mix(SudokuMatrix);
            SudokuSolve = Copy(SudokuMatrix, SudokuSolve);
            MatrixAllocation();
            ShowMatrix();
        }
        public int[,] Copy(int[,] matrix, int[,] solve)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    solve[i, j] = matrix[i, j];
                }
            }
            return solve;
        }
        public void MatrixAllocation()
        {
            int DeleteCounter = 81 - DeletedCellCounter;
            bool[,] Checked = new bool[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Checked[i, j] = false;
                }
            }

            for (int i = 0; i < DeletedCellCounter; i++)
            {
                int a = random.Next(0, 9);
                int b = random.Next(0, 9);
                if (Checked[a, b] == false)
                {
                    SudokuMatrix[a, b] = 0;
                    Checked[a, b] = true;
                }
                else
                {
                    DeletedCellCounter += 1;
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SudokuMatrix[i, j] == 0)
                    {
                        SudokuTable.Rows[i].Cells[j].Value = "";
                    }
                    else
                    {
                        SudokuTable.Rows[i].Cells[j].Value = SudokuMatrix[i, j].ToString();
                        SudokuTable.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------

        public SudokuMainForm()
        {
            //Initialize form
            InitializeComponent();
        }
        private void SudokuMainForm_Load(object sender, EventArgs e)
        {

            //When application loaded, call these function
            BuildSudokuTable();
        }

        private void SudokuMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "F1":
                    NewGame();
                    break;
                case "F2":
                    break;
                case "F3":
                    break;
                case "F4":
                    break;
                case "F5":
                    break;
                case "F6":
                    break;
                case "F7":
                    break;
                case "F8":
                    AboutGame();
                    break;
                case "F9":
                    ExitGame();
                    break;
            }
        }
        private void SudokuTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SudokuTable.ClearSelection();
        }
        private void SudokuMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Add from ExitGame() function for resolving problem of event
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void SudokuNewGame_Click(object sender, EventArgs e)
        {
            //When click new game button, application will restart
            NewGame();
        }
        private void SudokuSaveGame_Click(object sender, EventArgs e)
        {

        }
        private void SudokuLoadGame_Click(object sender, EventArgs e)
        {
            //When click load game button, application will input data from selected file to application
        }
        private void SudokuHelp_Click(object sender, EventArgs e)
        {
           //When click help button, a dialog box will be appeared to give information
        }
        private void SudokuAbout_Click(object sender, EventArgs e)
        {
            //When cick about button, a dialog box will be appeared to give information
            AboutGame();
        }
        private void SudokuExit_Click(object sender, EventArgs e)
        {
            //When click exit button, confirmation box will appear to confirm user's exit
            ExitGame();
        }
        private void SudokuValidate_Click(object sender, EventArgs e)
        {
            //When click validate button, application will consider if player is win or not 
        }
        private void SudokuHighScore_Click(object sender, EventArgs e)
        {
            //When click high score button, a dialog box will be appeared to give information of top ten record with lowest time
        }
        private void SudokuTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Application will validate and consider if user's input is numeric or not
            DataGridViewTextBoxCell cell = SudokuTable[e.ColumnIndex, e.RowIndex] as DataGridViewTextBoxCell;
            if (cell != null)
            {
                char[] chars = e.FormattedValue.ToString().ToCharArray();
                foreach (char c in chars)
                {
                    if (char.IsDigit(c) == false ||  c - '0' == 0)
                    {
                        MessageBox.Show("You have to enter digit 1-9 only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }
        private void EasySelector_CheckedChanged(object sender, EventArgs e)
        {
            //If Easy checkbox is ticked
            if (EasySelector.Checked) { 
                DialogResult result = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    EasySelector.Enabled = false;
                    MediumSelector.Enabled = false;
                    HardSelector.Enabled = false;
                    SudokuTable.Enabled = true;
                    DifficultyIndicator = 1;
                    CreateRandomPuzzle();
                }
                else
                {
                    EasySelector.Checked = false;
                }
            }
        }

        private void MediumSelector_CheckedChanged(object sender, EventArgs e)
        {
            //If Medium checkbox is ticked
            if (MediumSelector.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    EasySelector.Enabled = false;
                    MediumSelector.Enabled = false;
                    HardSelector.Enabled = false;
                    SudokuTable.Enabled = true;
                    DifficultyIndicator = 2;
                    CreateRandomPuzzle();
                }
                else
                {
                    MediumSelector.Checked = false;
                }
            }
        }

        private void HardSelector_CheckedChanged(object sender, EventArgs e)
        {
            //If Hard checkbox is ticked
            if (HardSelector.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    EasySelector.Enabled = false;
                    MediumSelector.Enabled = false;
                    HardSelector.Enabled = false;
                    SudokuTable.Enabled = true;
                    DifficultyIndicator = 3;
                    CreateRandomPuzzle();
                }
                else
                {
                    HardSelector.Checked = false;
                }
            }
        }
    }
}
