using System.IO;
namespace NotepadPro
{
    public partial class MainForm : Form
    {
        private bool fileAlreadySaved;
        private bool fileUpdated;
        private string currentFileName;
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
        }

        //This will for Redo feature
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
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
            richTextBox1.Clear();
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
                FileName = FileName.Remove(FileName.LastIndexOf('.'));
                this.Text = FileName + " - Notepad Pro";
            }
        }

        //This will save as feature , used to save the file with new name
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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
                FileName = FileName.Remove(FileName.LastIndexOf('.'));
                this.Text = FileName + " - Notepad Pro";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
