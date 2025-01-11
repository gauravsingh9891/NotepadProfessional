using System.IO;
using System.Runtime.CompilerServices;
namespace NotepadPro
{
    public partial class MainForm : Form
    {
        private bool IsAlreadySaved;
        private bool IsFileUpdated;
        private string CurrentFilename;
        public MainForm()
        {
            InitializeComponent();
        }

        // This will open font dialog box to change font style &  size
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        //This will Enable or Disable the Word Wrap feature
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        //This will for Undo feature
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        //This will for Redo feature
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        //This will Enable or Disable status bar
        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        //This will close  the Notepad Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This will show details about Application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        //This will clear and open fresh notepad
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(IsFileUpdated)
            {
                DialogResult dr = MessageBox.Show("Do you want to save your changes?", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveFileUpdate(); ClearScreen();
                        break;
                    case DialogResult.No:
                        ClearScreen();
                        break;
                }
            }
            else
            { 
                ClearScreen();
            }
            
        }

        //This will open the dialog box to choose .txt or .rtf file and load  
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text File|*.txt|Rich Text File|*.rtf";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                else if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                FileName = Path.GetFileName(openFileDialog1.FileName);
                //FileName = FileName.Remove(FileName.LastIndexOf('.'));
                this.Text = FileName + " - Notepad Pro";

                IsAlreadySaved = true;
                IsFileUpdated = false;
                CurrentFilename = openFileDialog1.FileName;
            }
        }

        //This will save as feature , used to save the file with new name
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //Save File function
        private void SaveFile()
        {
            string FileName = "";
            saveFileDialog1.FileName = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|Rich Text File|*.rtf";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".txt")
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(saveFileDialog1.Filter) == ".rtf")
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                FileName = Path.GetFileName(saveFileDialog1.FileName);
                //FileName = FileName.Remove(FileName.LastIndexOf('.'));
                this.Text = FileName + " - Notepad Pro";
                IsAlreadySaved = true;
                IsFileUpdated = false;
                CurrentFilename = saveFileDialog1.FileName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IsAlreadySaved = false;
            IsFileUpdated = false;
            CurrentFilename = "";
        }

        //This Used for any file changes then update the status
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IsFileUpdated = true;
            undoToolStripMenuItem.Enabled = true;
        }

        //This is used for implement Save file feature
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileUpdate();
        }

        //This function is used to save file updated status
        private void SaveFileUpdate()
        {
            if (IsAlreadySaved)
            {
                if (Path.GetExtension(CurrentFilename) == ".txt")
                {
                    richTextBox1.SaveFile(CurrentFilename, RichTextBoxStreamType.PlainText);
                }
                else if (Path.GetExtension(CurrentFilename) == ".rtf")
                {
                    richTextBox1.SaveFile(CurrentFilename, RichTextBoxStreamType.RichText);
                }
                IsFileUpdated = false;
            }
            else
            {
                if (IsFileUpdated)
                {
                    SaveFile();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        //This function is used to Clear the text on Notepad.
        private void ClearScreen()
        {
            richTextBox1.Clear();
            IsFileUpdated = false;
            IsAlreadySaved = false;
            this.Text = "Untitled - Notepad Pro";
        }
    }
}
