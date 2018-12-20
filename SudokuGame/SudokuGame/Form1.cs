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
        public SudokuMainForm()
        {
            InitializeComponent();
        }

        private void SudokuMainForm_Load(object sender, EventArgs e)
        {

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
    }
}
