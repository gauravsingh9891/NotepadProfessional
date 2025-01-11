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
        #region MainMenu
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
            UndotoolStrip.Enabled = false;
            RedotoolStrip.Enabled = true;
        }

        //This will for Redo feature
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
            UndotoolStrip.Enabled = true;
            RedotoolStrip.Enabled = false;
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
            NewMenu();
            UndotoolStrip.Enabled = false;
        }

        private void NewMenu()
        {
            if (IsFileUpdated)
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
            undoToolStripMenuItem.Enabled = false;
        }

        //This will open the dialog box to choose .txt or .rtf file and load  
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMenu();
        }

        private void OpenFileMenu()
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
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            UndotoolStrip.Enabled = false;
            RedotoolStrip.Enabled = false;
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
            UndotoolStrip.Enabled = true;
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

        //This funtionality is for select All Text
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //This is for Add Current System Date and Time to Text
        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = DateTime.Now.ToString();
        }

        //This is for change Text Font style
        private void FontTextStyle(FontStyle fontStyle)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, fontStyle);
        }

        //This is for make Text Font bold
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Bold);
        }

        //This is for make Text Font Italic
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Italic);
        }

        //This is for make Text Font Normal
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Regular);
        }

        //This is code for Add Underline to Text
        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Underline);
        }

        //This is code for Add Strikethrought to Text
        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Strikeout);
        }

        // This will open font dialog box to change font style, color, & size of whole document
        private void documentFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.ShowColor = true;
            DialogResult dr = fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        //This is code fo selected change Text Font style,Color,Size Functionality implemented here.
        private void selectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontFormat();
        }

        private void FontFormat()
        {
            DialogResult dr = fontDialog1.ShowDialog();
            fontDialog1.ShowColor = true;
            if (dr == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
        }

        //This is code for selected change Text Color Functionality implemented here.
        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedColorChange();
        }

        private void SelectedColorChange()
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
            }
        }
        #endregion

        #region Tool Tip Menu
        //Implemented "New File" functionality in Tool strip 
        private void NewtoolStrip_Click(object sender, EventArgs e)
        {
            NewMenu();
        }

        //Implemented "Open File" functionality in Tool strip 
        private void OpentoolStrip_Click(object sender, EventArgs e)
        {
            OpenFileMenu();
        }

        //Implemented "Save File" functionality in Tool strip 
        private void SavetoolStrip_Click(object sender, EventArgs e)
        {
            SaveFileUpdate();
        }

        //Implemented "Save As File" functionality in Tool strip 
        private void SaveAstoolStrip_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //Implemented "Undo" functionality in Tool strip 
        private void UndotoolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
            UndotoolStrip.Enabled = false;
            RedotoolStrip.Enabled = true;
        }

        //Implemented "Redo" functionality in Tool strip 
        private void RedotoolStrip_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
            UndotoolStrip.Enabled = true;
            RedotoolStrip.Enabled = false;
        }

        //Implemented "Bold Text" functionality in Tool strip 
        private void BoldtoolStrip_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Bold);
        }

        //Implemented "Italic Text" functionality in Tool strip 
        private void ItalictoolStrip_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Italic);
        }

        //Implemented "Underline Text" functionality in Tool strip 
        private void UnderlinetoolStrip_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Underline);
        }

        //Implemented "Underline Text" functionality in Tool strip 
        private void TextColorStrip_Click(object sender, EventArgs e)
        {
            SelectedColorChange();
        }

        //Implemented "Strike throught Text" functionality in Tool strip 
        private void StrikethroughtoolStrip_Click(object sender, EventArgs e)
        {
            FontTextStyle(FontStyle.Strikeout);
        }

        //Implemented "Format Font Style" functionality in Tool strip 
        private void FontstyletoolStrip_Click(object sender, EventArgs e)
        {
            FontFormat();
        }
        #endregion
    }
}
