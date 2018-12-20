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
        }
        public void LoadNewGame()
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
        public void ExitGame()
        {
            //This function will pop up confirmation box and ask user if he/she want to exit
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
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
                    LoadNewGame();
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
                    break;
                case "F9":
                    ExitGame();
                    break;
            }
        }
        private void SudokuNewGame_Click(object sender, EventArgs e)
        {
            //When click new game button, application will restart
            LoadNewGame();
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
                    if (char.IsDigit(c) == false)
                    {
                        MessageBox.Show("You have to enter digits only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

    }
}
