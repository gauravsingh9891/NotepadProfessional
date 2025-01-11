namespace NotepadPro
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            pageSetupToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            timeDateToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            documentFontToolStripMenuItem = new ToolStripMenuItem();
            selectedTextToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            changeTextColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            normalToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikethroughToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            restoreDefualtZoomToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(838, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, pageSetupToolStripMenuItem, printToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.New;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(195, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.Open;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(195, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.Save;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(195, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.save_as;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            pageSetupToolStripMenuItem.Image = Properties.Resources.Page_Setup;
            pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            pageSetupToolStripMenuItem.Size = new Size(195, 22);
            pageSetupToolStripMenuItem.Text = "Page Setup...";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = Properties.Resources.print;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(195, 22);
            printToolStripMenuItem.Text = "Print...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.close;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator4, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator5, deleteToolStripMenuItem, toolStripSeparator6, selectAllToolStripMenuItem, timeDateToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Image = Properties.Resources.arrow_undo;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(164, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Image = Properties.Resources.arrow_redo;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(164, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = Properties.Resources.cut;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = Properties.Resources.copy;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = Properties.Resources.paste;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(161, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Image = Properties.Resources.Select_all;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // timeDateToolStripMenuItem
            // 
            timeDateToolStripMenuItem.Image = Properties.Resources.DateTime;
            timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            timeDateToolStripMenuItem.Size = new Size(164, 22);
            timeDateToolStripMenuItem.Text = "Time/Date";
            timeDateToolStripMenuItem.Click += timeDateToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, toolStripSeparator7, changeTextColorToolStripMenuItem, toolStripSeparator9, normalToolStripMenuItem, boldToolStripMenuItem, italicToolStripMenuItem, toolStripSeparator10, underlineToolStripMenuItem, strikethroughToolStripMenuItem, toolStripSeparator8, wordWrapToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { documentFontToolStripMenuItem, selectedTextToolStripMenuItem });
            fontToolStripMenuItem.Image = Properties.Resources.typography;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(210, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // documentFontToolStripMenuItem
            // 
            documentFontToolStripMenuItem.Name = "documentFontToolStripMenuItem";
            documentFontToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
            documentFontToolStripMenuItem.Size = new Size(221, 22);
            documentFontToolStripMenuItem.Text = "Document Font Style";
            documentFontToolStripMenuItem.Click += documentFontToolStripMenuItem_Click;
            // 
            // selectedTextToolStripMenuItem
            // 
            selectedTextToolStripMenuItem.Name = "selectedTextToolStripMenuItem";
            selectedTextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.F;
            selectedTextToolStripMenuItem.Size = new Size(221, 22);
            selectedTextToolStripMenuItem.Text = "Selected Text";
            selectedTextToolStripMenuItem.Click += selectedTextToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(207, 6);
            // 
            // changeTextColorToolStripMenuItem
            // 
            changeTextColorToolStripMenuItem.Image = Properties.Resources.textColor;
            changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            changeTextColorToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.H;
            changeTextColorToolStripMenuItem.Size = new Size(210, 22);
            changeTextColorToolStripMenuItem.Text = "Change Text Color";
            changeTextColorToolStripMenuItem.Click += changeTextColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(207, 6);
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Image = Properties.Resources.letter;
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            normalToolStripMenuItem.Size = new Size(210, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = Properties.Resources.bold;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(210, 22);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = Properties.Resources.italic;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(210, 22);
            italicToolStripMenuItem.Text = "Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(207, 6);
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = Properties.Resources.Underline;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            underlineToolStripMenuItem.Size = new Size(210, 22);
            underlineToolStripMenuItem.Text = "Underline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // strikethroughToolStripMenuItem
            // 
            strikethroughToolStripMenuItem.Image = Properties.Resources.strike;
            strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            strikethroughToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.K;
            strikethroughToolStripMenuItem.Size = new Size(210, 22);
            strikethroughToolStripMenuItem.Text = "Strikethrough";
            strikethroughToolStripMenuItem.Click += strikethroughToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(207, 6);
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Checked = true;
            wordWrapToolStripMenuItem.CheckState = CheckState.Checked;
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(210, 22);
            wordWrapToolStripMenuItem.Text = "Word Wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusBarToolStripMenuItem, zoomToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(126, 22);
            statusBarToolStripMenuItem.Text = "Status Bar";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, restoreDefualtZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(126, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Image = Properties.Resources.zoom_in;
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new Size(229, 22);
            zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Image = Properties.Resources.zoom_out;
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new Size(229, 22);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // restoreDefualtZoomToolStripMenuItem
            // 
            restoreDefualtZoomToolStripMenuItem.Name = "restoreDefualtZoomToolStripMenuItem";
            restoreDefualtZoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            restoreDefualtZoomToolStripMenuItem.Size = new Size(229, 22);
            restoreDefualtZoomToolStripMenuItem.Text = "Restore Defualt Zoom";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = Properties.Resources.About;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(177, 22);
            aboutToolStripMenuItem.Text = "About Notepad Pro";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(838, 389);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(richTextBox1);
            toolStripContainer1.ContentPanel.Size = new Size(838, 389);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 24);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(838, 436);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(838, 22);
            statusStrip1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(111, 25);
            toolStrip1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 460);
            Controls.Add(toolStripContainer1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad Pro";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem pageSetupToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem restoreDefualtZoomToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem timeDateToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikethroughToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem documentFontToolStripMenuItem;
        private ToolStripMenuItem selectedTextToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
    }
}
