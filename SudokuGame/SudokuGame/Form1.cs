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
        public void Build()
        {
            SudokuTable.ColumnCount = 9;
            SudokuTable.Rows.Add(9);                         
            for (int i = 0; i < 9; i++)
            {
                DataGridViewColumn column = SudokuTable.Columns[i];
                column.Width = (int)(SudokuTable.Width / 9f);
                DataGridViewRow row = SudokuTable.Rows[i];
                row.Height = (int)(SudokuTable.Height / 9f);
            }
            SudokuTable.Width = SudokuTable.Columns[1].Width * 9;         // Визначення розмірів стовпців та рядків

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SudokuTable.Rows[i].Cells[j].Style.BackColor = Color.LightCyan;
                }

            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    SudokuTable.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    SudokuTable.Rows[j].Cells[i].Style.BackColor = Color.LightBlue;
                }

            }

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
            InitializeComponent();
        }

        private void SudokuMainForm_Load(object sender, EventArgs e)
        {
            Build();
        }


        private void SudokuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SudokuNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SudokuLoadGame_Click(object sender, EventArgs e)
        {

        }

        private void SudokuHelp_Click(object sender, EventArgs e)
        {

        }

        private void SudokuAbout_Click(object sender, EventArgs e)
        {

        }

        private void SudokuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SudokuValidate_Click(object sender, EventArgs e)
        {

        }

        private void SudokuHighScore_Click(object sender, EventArgs e)
        {

        }

    }
}
