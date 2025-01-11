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
            NewtoolStrip = new ToolStripButton();
            OpentoolStrip = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            SavetoolStrip = new ToolStripButton();
            SaveAstoolStrip = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            PrinttoolStrip = new ToolStripButton();
            PrintPageStrip = new ToolStripButton();
            toolStripSeparator13 = new ToolStripSeparator();
            CuttoolStrip = new ToolStripButton();
            CopytoolStrip = new ToolStripButton();
            PastetoolStrip = new ToolStripButton();
            DeletetoolStrip = new ToolStripButton();
            toolStripSeparator14 = new ToolStripSeparator();
            UndotoolStrip = new ToolStripButton();
            RedotoolStrip = new ToolStripButton();
            toolStripSeparator15 = new ToolStripSeparator();
            BoldtoolStrip = new ToolStripButton();
            ItalictoolStrip = new ToolStripButton();
            UnderlinetoolStrip = new ToolStripButton();
            StrikethroughtoolStrip = new ToolStripButton();
            toolStripSeparator16 = new ToolStripSeparator();
            TextColorStrip = new ToolStripButton();
            FontstyletoolStrip = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { NewtoolStrip, OpentoolStrip, toolStripSeparator11, SavetoolStrip, SaveAstoolStrip, toolStripSeparator12, PrinttoolStrip, PrintPageStrip, toolStripSeparator13, CuttoolStrip, CopytoolStrip, PastetoolStrip, DeletetoolStrip, toolStripSeparator14, UndotoolStrip, RedotoolStrip, toolStripSeparator15, BoldtoolStrip, ItalictoolStrip, UnderlinetoolStrip, StrikethroughtoolStrip, toolStripSeparator16, FontstyletoolStrip, TextColorStrip });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(493, 25);
            toolStrip1.TabIndex = 0;
            // 
            // NewtoolStrip
            // 
            NewtoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewtoolStrip.Image = Properties.Resources.New;
            NewtoolStrip.ImageTransparentColor = Color.Magenta;
            NewtoolStrip.Name = "NewtoolStrip";
            NewtoolStrip.Size = new Size(23, 22);
            NewtoolStrip.Text = "toolStripButton1";
            NewtoolStrip.Click += NewtoolStrip_Click;
            // 
            // OpentoolStrip
            // 
            OpentoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpentoolStrip.Image = Properties.Resources.Open;
            OpentoolStrip.ImageTransparentColor = Color.Magenta;
            OpentoolStrip.Name = "OpentoolStrip";
            OpentoolStrip.Size = new Size(23, 22);
            OpentoolStrip.Text = "toolStripButton2";
            OpentoolStrip.Click += OpentoolStrip_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 25);
            // 
            // SavetoolStrip
            // 
            SavetoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SavetoolStrip.Image = Properties.Resources.Save;
            SavetoolStrip.ImageTransparentColor = Color.Magenta;
            SavetoolStrip.Name = "SavetoolStrip";
            SavetoolStrip.Size = new Size(23, 22);
            SavetoolStrip.Text = "toolStripButton3";
            SavetoolStrip.Click += SavetoolStrip_Click;
            // 
            // SaveAstoolStrip
            // 
            SaveAstoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveAstoolStrip.Image = Properties.Resources.save_as;
            SaveAstoolStrip.ImageTransparentColor = Color.Magenta;
            SaveAstoolStrip.Name = "SaveAstoolStrip";
            SaveAstoolStrip.Size = new Size(23, 22);
            SaveAstoolStrip.Text = "toolStripButton4";
            SaveAstoolStrip.Click += SaveAstoolStrip_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 25);
            // 
            // PrinttoolStrip
            // 
            PrinttoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PrinttoolStrip.Image = Properties.Resources.print;
            PrinttoolStrip.ImageTransparentColor = Color.Magenta;
            PrinttoolStrip.Name = "PrinttoolStrip";
            PrinttoolStrip.Size = new Size(23, 22);
            PrinttoolStrip.Text = "toolStripButton5";
            // 
            // PrintPageStrip
            // 
            PrintPageStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PrintPageStrip.Image = Properties.Resources.Page_Setup;
            PrintPageStrip.ImageTransparentColor = Color.Magenta;
            PrintPageStrip.Name = "PrintPageStrip";
            PrintPageStrip.Size = new Size(23, 22);
            PrintPageStrip.Text = "toolStripButton6";
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(6, 25);
            // 
            // CuttoolStrip
            // 
            CuttoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CuttoolStrip.Image = Properties.Resources.cut_red1;
            CuttoolStrip.ImageTransparentColor = Color.Magenta;
            CuttoolStrip.Name = "CuttoolStrip";
            CuttoolStrip.Size = new Size(23, 22);
            CuttoolStrip.Text = "toolStripButton7";
            // 
            // CopytoolStrip
            // 
            CopytoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CopytoolStrip.Image = Properties.Resources.copy;
            CopytoolStrip.ImageTransparentColor = Color.Magenta;
            CopytoolStrip.Name = "CopytoolStrip";
            CopytoolStrip.Size = new Size(23, 22);
            CopytoolStrip.Text = "toolStripButton8";
            // 
            // PastetoolStrip
            // 
            PastetoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PastetoolStrip.Image = Properties.Resources.paste;
            PastetoolStrip.ImageTransparentColor = Color.Magenta;
            PastetoolStrip.Name = "PastetoolStrip";
            PastetoolStrip.Size = new Size(23, 22);
            PastetoolStrip.Text = "toolStripButton9";
            // 
            // DeletetoolStrip
            // 
            DeletetoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DeletetoolStrip.Image = Properties.Resources.delete;
            DeletetoolStrip.ImageTransparentColor = Color.Magenta;
            DeletetoolStrip.Name = "DeletetoolStrip";
            DeletetoolStrip.Size = new Size(23, 22);
            DeletetoolStrip.Text = "toolStripButton10";
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(6, 25);
            // 
            // UndotoolStrip
            // 
            UndotoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UndotoolStrip.Enabled = false;
            UndotoolStrip.Image = Properties.Resources.arrow_undo;
            UndotoolStrip.ImageTransparentColor = Color.Magenta;
            UndotoolStrip.Name = "UndotoolStrip";
            UndotoolStrip.Size = new Size(23, 22);
            UndotoolStrip.Text = "toolStripButton11";
            UndotoolStrip.Click += UndotoolStrip_Click;
            // 
            // RedotoolStrip
            // 
            RedotoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RedotoolStrip.Enabled = false;
            RedotoolStrip.Image = Properties.Resources.arrow_redo;
            RedotoolStrip.ImageTransparentColor = Color.Magenta;
            RedotoolStrip.Name = "RedotoolStrip";
            RedotoolStrip.Size = new Size(23, 22);
            RedotoolStrip.Text = "toolStripButton12";
            RedotoolStrip.Click += RedotoolStrip_Click;
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new Size(6, 25);
            // 
            // BoldtoolStrip
            // 
            BoldtoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldtoolStrip.Image = Properties.Resources.text_bold;
            BoldtoolStrip.ImageTransparentColor = Color.Magenta;
            BoldtoolStrip.Name = "BoldtoolStrip";
            BoldtoolStrip.Size = new Size(23, 22);
            BoldtoolStrip.Text = "toolStripButton13";
            BoldtoolStrip.Click += BoldtoolStrip_Click;
            // 
            // ItalictoolStrip
            // 
            ItalictoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ItalictoolStrip.Image = Properties.Resources.text_italic;
            ItalictoolStrip.ImageTransparentColor = Color.Magenta;
            ItalictoolStrip.Name = "ItalictoolStrip";
            ItalictoolStrip.Size = new Size(23, 22);
            ItalictoolStrip.Text = "toolStripButton14";
            ItalictoolStrip.Click += ItalictoolStrip_Click;
            // 
            // UnderlinetoolStrip
            // 
            UnderlinetoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlinetoolStrip.Image = Properties.Resources.text_underline;
            UnderlinetoolStrip.ImageTransparentColor = Color.Magenta;
            UnderlinetoolStrip.Name = "UnderlinetoolStrip";
            UnderlinetoolStrip.Size = new Size(23, 22);
            UnderlinetoolStrip.Text = "toolStripButton15";
            UnderlinetoolStrip.Click += UnderlinetoolStrip_Click;
            // 
            // StrikethroughtoolStrip
            // 
            StrikethroughtoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            StrikethroughtoolStrip.Image = Properties.Resources.text_strikethrough;
            StrikethroughtoolStrip.ImageTransparentColor = Color.Magenta;
            StrikethroughtoolStrip.Name = "StrikethroughtoolStrip";
            StrikethroughtoolStrip.Size = new Size(23, 22);
            StrikethroughtoolStrip.Text = "toolStripButton1";
            StrikethroughtoolStrip.Click += StrikethroughtoolStrip_Click;
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new Size(6, 25);
            // 
            // TextColorStrip
            // 
            TextColorStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TextColorStrip.Image = Properties.Resources.textColor;
            TextColorStrip.ImageTransparentColor = Color.Magenta;
            TextColorStrip.Name = "TextColorStrip";
            TextColorStrip.Size = new Size(23, 22);
            TextColorStrip.Text = "toolStripButton16";
            TextColorStrip.Click += TextColorStrip_Click;
            // 
            // FontstyletoolStrip
            // 
            FontstyletoolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FontstyletoolStrip.Image = Properties.Resources.font;
            FontstyletoolStrip.ImageTransparentColor = Color.Magenta;
            FontstyletoolStrip.Name = "FontstyletoolStrip";
            FontstyletoolStrip.Size = new Size(23, 22);
            FontstyletoolStrip.Text = "toolStripButton1";
            FontstyletoolStrip.Click += FontstyletoolStrip_Click;
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripButton NewtoolStrip;
        private ToolStripButton OpentoolStrip;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton SavetoolStrip;
        private ToolStripButton SaveAstoolStrip;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton PrinttoolStrip;
        private ToolStripButton PrintPageStrip;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton CuttoolStrip;
        private ToolStripButton CopytoolStrip;
        private ToolStripButton PastetoolStrip;
        private ToolStripButton DeletetoolStrip;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton UndotoolStrip;
        private ToolStripButton RedotoolStrip;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripButton BoldtoolStrip;
        private ToolStripButton ItalictoolStrip;
        private ToolStripButton UnderlinetoolStrip;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripButton TextColorStrip;
        private ToolStripButton StrikethroughtoolStrip;
        private ToolStripButton FontstyletoolStrip;
    }
}
