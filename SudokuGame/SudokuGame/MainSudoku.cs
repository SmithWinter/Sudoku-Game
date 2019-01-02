using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace SudokuGame
{
    public partial class SudokuMainForm : Form
    {
        //Global variables
        public Random random = new Random();
        public int GameState = 0;
        public int SaveState = 0;
        public int LoadState = 0;
        public int CurrentRow = 0;
        public int CurrentColumn = 0;
        public int DifficultyIndicator;
        public int DeletedCellCounter;
        public int[,] SudokuMatrix = new int[9, 9];
        public int[,] SudokuTempSolution = new int[9, 9];
        //Global Timer
        System.Timers.Timer SudokuTimer;
        public int hour = 0, minute = 0, second = 0;
        //---------------------------------Custom Functon Section-------------------------------------------------
        public void BuildSudokuTable()
        {
            //This function render Sudoku table as DataGridView
            //Initialize DataGridView
            SudokuTable.ColumnCount = 9;
            SudokuTable.Rows.Add(9);
            //Run loop to render column and row and limit cell input is 1 character
            for (int i = 0; i < 9; i++)
            {
                //Add input validator, accept only 1 char
                DataGridViewColumn column = SudokuTable.Columns[i];
                ((DataGridViewTextBoxColumn)column).MaxInputLength = 1;
                //Set height and row for sudoku table
                SudokuTable.Columns[i].Width = 38 + ((i + 1) % 3 == 0 ? 5 : 0);
                SudokuTable.Rows[i].Height = 38 + ((i + 1) % 3 == 0 ? 5 : 0);
            }
            //Set divider for sudoku
            SudokuTable.Columns[2].DividerWidth = 5;
            SudokuTable.Columns[5].DividerWidth = 5;
            SudokuTable.Rows[2].DividerHeight = 5;
            SudokuTable.Rows[5].DividerHeight = 5;
            //Set height for divider
            SudokuTable.Rows[2].Height += 5;
            SudokuTable.Rows[5].Height += 5;

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
        public void SaveGame()
        {
            string text = "";
            string CellValue;
            string GameDifficulty = DifficultyIndicator.ToString();
            string ExportSecond = (second < 10) ? ("0" + second.ToString()) : (second.ToString());
            string ExportMinute = (minute < 10) ? ("0" + minute.ToString()) : (minute.ToString());
            string ExportHour = (hour < 10) ? ("0" + hour.ToString()) : (hour.ToString());
            string ExportCurrentColumn = CurrentColumn.ToString();
            string ExportCurrentRow = CurrentRow.ToString();
            int EmptyCell;

            SaveFileDialog SaveGameDialog = new SaveFileDialog();
            SaveGameDialog.Filter = "Sudoku Game (*.game)|*.game";
            SaveGameDialog.AddExtension = true;
            SaveGameDialog.OverwritePrompt = true;
            SaveGameDialog.Title = "Save Sudoku Game";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    CellValue = (SudokuTable[i, j].Value.ToString());
                    if (CellValue == "")
                    {
                        CellValue = "0";
                    }
                    EmptyCell = Convert.ToInt32(CellValue);
                    if (EmptyCell == 0)
                    {
                        text += "0";
                    }
                    else
                    {
                        text += SudokuTable[i, j].Value.ToString();
                    }
                }
            }
            text += ExportHour;
            text += ExportMinute;
            text += ExportSecond;
            text += ExportCurrentColumn;
            text += ExportCurrentRow;
            text += GameDifficulty;
            DialogResult result = SaveGameDialog.ShowDialog();
            try
            {
                if (result == DialogResult.OK)
                {
                    string difficulty = SudokuDifficultySelector.SelectedItem.ToString();
                    SaveState = 2;
                    System.IO.File.WriteAllText(SaveGameDialog.FileName, text);
                    MessageBox.Show(" Save game successful \n Difficulty: " + difficulty + "\n Time: " + ExportHour + " : " + ExportMinute + " : " + ExportSecond + "\n Selected Cell: " + "[" + (CurrentRow + 1) + ":" + (CurrentColumn + 1) + "]" , "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddInstructorText("Save game successful");
                    AddInstructorText("Difficulty: " + difficulty);
                    AddInstructorText("Time: " + ExportHour + ":" + ExportMinute + ":" + ExportSecond);
                    
                }
                if (result == DialogResult.Cancel)
                {
                    AddInstructorText("Game save canceled");
                }
            }
            catch
            {
                MessageBox.Show("Error saving game file ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GameState = 2;
                CheckGameState();
            }
        }
        public void LoadGame()
        {
            if (GameState != 0)
            {
                GameState = 1;
            }
            LoadState = 1;

            OpenFileDialog LoadGameDialog = new OpenFileDialog();
            LoadGameDialog.CheckFileExists = true;
            LoadGameDialog.Filter = "Sudoku Game (*.game)|*.game";
            LoadGameDialog.Multiselect = false;
            LoadGameDialog.Title = "Load Sudoku Game";
            DialogResult result = LoadGameDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    SudokuTable.Enabled = true;
                    string text = System.IO.File.ReadAllText(LoadGameDialog.FileName);
                    int a = 0;
                    int b = 0;
                    int indicator = 0;
                    int impHour = 0;
                    int impMinute = 0;
                    int impSecond = 0;
                    int impCurrentColumn = 0;
                    int impCurrentRow = 0;
                    for (int i = 0; i < 81; i++)
                    {
                        string CellValue = text[i].ToString();
                        int value = 0;
                        if (int.TryParse(CellValue, out value))
                        {
                            a = (i % 9);
                            b = (i / 9);
                            SudokuMatrix[a, b] = value;
                        }
                    }
                    for (int i = 0; i < SudokuMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < SudokuMatrix.GetLength(1); j++)
                        {
                            SudokuTable[j, i].Value = "";
                        }
                    }
                    string ImportHour = (text[81].ToString() != "0") ? (text.Substring(81, 2).ToString()) : (text[82].ToString());
                    string ImportMinute = (text[83].ToString() != "0") ? (text.Substring(83, 2).ToString()) : (text[84].ToString());
                    string ImportSecond = (text[85].ToString() != "0") ? (text.Substring(85, 2).ToString()) : (text[8].ToString());
                    string ImportCurrentColumn = text[87].ToString();
                    string ImportCurrentRow = text[88].ToString();
                    string TempIndicator = text[89].ToString();
                    if (int.TryParse(TempIndicator, out indicator))
                    {
                        SudokuDifficultySelector.SelectedIndex = indicator - 1;
                    }
                    if (int.TryParse(ImportHour, out impHour) && int.TryParse(ImportMinute, out impMinute) && int.TryParse(ImportSecond, out impSecond))
                    {
                        hour = impHour;
                        minute = impMinute;
                        second = impSecond;
                        TimeCounter.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
                    }
                    if (int.TryParse(ImportCurrentColumn, out impCurrentColumn) && int.TryParse(ImportCurrentRow, out impCurrentRow))
                    {
                        CurrentColumn = impCurrentColumn;
                        CurrentRow = impCurrentRow;
                    }
                    string difficulty = SudokuDifficultySelector.SelectedItem.ToString();
                    MessageBox.Show(" Load game successful \n Difficulty: " + difficulty + "\n Time: " + ImportHour + " : " + ImportMinute + " : " + ImportSecond + "\n Selected Cell: " + "[" + (CurrentRow + 1).ToString() + ":" + (CurrentColumn + 1).ToString() + "]", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddInstructorText("Load game successful");
                    AddInstructorText("Time: " + ImportHour + ":" + ImportMinute + ":" + ImportSecond);
                    AddInstructorText("Difficulty: " + difficulty);
                    AddInstructorText("Selected cell: " + "[" + (CurrentRow + 1).ToString() + ":" + (CurrentColumn + 1).ToString() + "]");
                    SaveState = 1;
                    GameState = 1;
                    CheckGameState();
                    ChangeComponentState();
                    SaveButton.Enabled = true;
                    LoadButton.Enabled = true;
                    SudokuTable.Enabled = false;
                    ShowMatrix();

                }
                if (result == DialogResult.Cancel)
                {
                    if (GameState == 0)
                    {
                        AddInstructorText("Game load canceled");
                        TriggerButton.Text = "Start Game";
                        SaveButton.Enabled = false;
                    }
                    else
                    {
                        AddInstructorText("Game load canceled");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error loading game file ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddInstructorText("Game load error");
                if (GameState == 0 || SudokuDifficultySelector.SelectedIndex != -1)
                {
                    TriggerButton.Enabled = false;
                    SaveButton.Enabled = false;
                    SudokuDifficultySelector.ResetText();
                    SudokuDifficultySelector.SelectedIndex = -1;
                }
                else
                {
                    GameState = 1;
                    CheckGameState();
                }

            }
        }
        public void AboutGame()
        {
            MessageBox.Show("CONTRIBUTOR OF GAME'S SOURCECODE \n\n 1. HỒ VŨ MINH ĐỨC \n 2. NGUYỄN DUY HIẾU \n 3. ĐỖ QUỐC KHÁNH", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ExitGame()
        {
            //This function will pop up confirmation box and ask user if he/she want to exit
            if (SaveState == 1)
            {
                DialogResult NotSaved = MessageBox.Show("Do you want to save game", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (NotSaved == DialogResult.Yes)
                {
                    SaveGame();
                }
                if (NotSaved == DialogResult.No)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
            }
            else if (SaveState == 2 || SaveState == 0)
            {
                DialogResult Saved = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (Saved == DialogResult.Yes)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
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
                case 4:
                    DeletedCellCounter = random.Next(60, 69);
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
            Copy(SudokuMatrix, SudokuTempSolution);
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
        public void ValidateGame ()
        {
            if (SudokuChecker.SudokuValidation(SudokuMatrix) == true)
            {
                SudokuTimer.Stop();
                TriggerButton.Enabled = false;
                SuggestButton.Enabled = false;
                ValidateButton.Enabled = false;
                SolveButton.Enabled = false;
                MessageBox.Show(" Congratulation you have completed the game \n Please start a new game", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Sorry, the game is not completed yet", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SolveGame ()
        {
            if (SudokuChecker.SudokuSolver(SudokuTempSolution, 0, 0))
            {
                MessageBox.Show(" Resolve successful \n Timer will be reseted \n Please start a new game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SudokuTimer.Stop();
                hour = 0; minute = 0; second = 0;
                TimeCounter.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
                TriggerButton.Enabled = false;
                SuggestButton.Enabled = false;
                ValidateButton.Enabled = false;
                SolveButton.Enabled = false;
                Copy(SudokuTempSolution, SudokuMatrix);
                ShowMatrix();
            }
            else
            {
               MessageBox.Show(" Cannot solve due to rule violation \n Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ChangeComponentState()
        {
            SudokuTable.Rows[CurrentRow].Cells[CurrentColumn].Selected = true;
            NewGameButton.Enabled = true;
            SaveButton.Enabled = false;
            LoadButton.Enabled = false;
            SuggestButton.Enabled = true;
            ValidateButton.Enabled = true;
            SolveButton.Enabled = true;
            SudokuDifficultySelector.Enabled = false;
        }
        public void CheckGameState()
        {
            switch (GameState)
            {
                case 0:
                    GameState = 1;
                    SaveState = 1;
                    ChangeComponentState();
                    CreateRandomPuzzle();
                    TriggerButton.Text = "Pause Game";
                    SudokuTimer.Start();
                    SudokuTable.Enabled = true;
                    AddInstructorText("Game started. Clock start ticking");
                    break;
                case 1:
                    GameState = 2;
                    SudokuTimer.Stop();
                    TriggerButton.Text = "Resume Game";
                    SaveButton.Enabled = true;
                    LoadButton.Enabled = true;
                    SuggestButton.Enabled = false;
                    ValidateButton.Enabled = false;
                    SolveButton.Enabled = false;
                    SudokuTable.Enabled = false;
                    AddInstructorText("Game paused. Clock stop ticking");
                    break;
                case 2:
                    GameState = 1;
                    SudokuTimer.Start();
                    TriggerButton.Text = "Pause Game";
                    SaveButton.Enabled = false;
                    LoadButton.Enabled = false;
                    SuggestButton.Enabled = true;
                    ValidateButton.Enabled = true;
                    SolveButton.Enabled = true;
                    SudokuTable.Enabled = true;
                    AddInstructorText("Game continued. Clock resume ticking");
                    break;
            }
        }
        public void AutoValidateForBeginner ()
        {
            string value, column, row;
            value = SudokuMatrix[CurrentRow, CurrentColumn].ToString();
            column = (CurrentColumn + 1).ToString();
            row = (CurrentRow + 1).ToString();
            if (SudokuChecker.ValidateCell(SudokuMatrix, CurrentRow, CurrentColumn, SudokuMatrix[CurrentRow, CurrentColumn]) == false)
            {
                AddInstructorText("Value "+  value + " of [" + row + ":" + column + "] is not legit. Please try again");
            }
            else
            {
                AddInstructorText("Value " + value + " of [" + row + ":" + column + "] is legit. Hurray");
            }

        }
        public void SuggestCell()
        {
            if (SudokuChecker.SudokuSolver(SudokuTempSolution, 0, 0)) { 
                if (SudokuMatrix[CurrentRow, CurrentColumn] != SudokuTempSolution[CurrentRow, CurrentColumn])
                {
                    string SuggestNumber = SudokuTempSolution[CurrentRow, CurrentColumn].ToString();
                    AddInstructorText("You should fill " + SuggestNumber + " in the cell [" + (CurrentColumn + 1).ToString() + ":" + (CurrentRow + 1).ToString() + "]");
                }
                else
                {
                    AddInstructorText("You have filled the right number");
                }
            }
            else
            {
                AddInstructorText("Cannot suggest due to invalid value existed");
            }
        }
        public void AddInstructorText (string input)
        {
            GameInstructor.AppendText(input);
            GameInstructor.AppendText(Environment.NewLine);
        }
        //---------------------------------------Section End---------------------------------------------------------------


        //---------------------------------------Event Function Section----------------------------------------------------
        public SudokuMainForm()
        {
            //Initialize form
            InitializeComponent();
        }
        private void SudokuMainForm_Load(object sender, EventArgs e)
        {
            //When application loaded, call these function
            BuildSudokuTable();
            //Load new Timer
            SudokuTimer = new System.Timers.Timer();
            SudokuTimer.Interval = 1000;
            SudokuTimer.Elapsed += OnTimeEvent;

        }
        private void SudokuMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Add from ExitGame() function for resolving problem of event
            if (SaveState == 1)
            {
                DialogResult NotSaved = MessageBox.Show("Do you want to save game", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (NotSaved == DialogResult.Yes)
                {
                    SaveGame();
                }
                if (NotSaved == DialogResult.No)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (SaveState == 2 || SaveState == 0)
            {
                DialogResult Saved = MessageBox.Show("Are you sure you want to exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (Saved == DialogResult.Yes)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void TriggerButton_Click(object sender, EventArgs e)
        {
            CheckGameState();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveGame();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadGame();
        }
        private void SuggestButton_Click(object sender, EventArgs e)
        {
            SuggestCell();
        }
        private void ValidateButton_Click(object sender, EventArgs e)
        {
            ValidateGame();
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            SolveGame();
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutGame();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitGame();
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
        private void SudokuDifficultySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            TriggerButton.Enabled = true;
            switch (SudokuDifficultySelector.SelectedIndex)
            {
                case 0:
                    DifficultyIndicator = 1;
                    AddInstructorText("You selected beginner difficulty");
                    break;
                case 1:
                    DifficultyIndicator = 2;
                    AddInstructorText("You selected intermediate difficulty");
                    break;
                case 2:
                    DifficultyIndicator = 3;
                    AddInstructorText("You selected advanced difficulty");
                    break;
                case 3:
                    DifficultyIndicator = 4;
                    AddInstructorText("You selected expert difficulty");
                    break;
            }
        }
        private void SudokuTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SudokuMatrix[e.RowIndex, e.ColumnIndex] = Convert.ToInt32(SudokuTable.CurrentCell.Value);
            if (DifficultyIndicator == 1)
            {
                AutoValidateForBeginner();
            }
            SuggestButton.Enabled = true;
            ValidateButton.Enabled = true;
            SolveButton.Enabled = true;
        }

        private void SudokuTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SuggestButton.Enabled = false;
            ValidateButton.Enabled = false;
            SolveButton.Enabled = false;
        }

        private void SudokuTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CurrentColumn = e.ColumnIndex;
            CurrentRow = e.RowIndex;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
                {
                    second += 1;
                    if (second == 60)
                    {
                        second = 0;
                        minute += 1;
                    }
                    if (minute == 60)
                    {
                        minute = 0;
                        hour += 1;
                    }
                    TimeCounter.Text = string.Format("{0}:{1}:{2}", hour.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
                }   
            ));
        }
        //--------------------------------------------Section End------------------------------------------------
    }
}
