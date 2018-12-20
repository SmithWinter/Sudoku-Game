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
        public SudokuMainForm()
        {
            //Initialize form
            InitializeComponent();
        }

        private void SudokuMainForm_Load(object sender, EventArgs e)
        {
            //When application loaded, call these function below
            BuildSudokuTable();
        }


        private void SudokuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SudokuNewGame_Click(object sender, EventArgs e)
        {
            //When click new game button, application will restart
            Application.Restart();
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
            //When click exit button, application will close 
            Application.Exit();
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
                        MessageBox.Show("You have to enter digits only", "Alert");
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }
    }
}
