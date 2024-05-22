using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pglab3_task2
{
    public partial class Fmmain : Form
    {
        MenuStrip menuStrip;
        ToolStripMenuItem fileToolStripMenuItem;
        ToolStripMenuItem viewToolStripMenuItem;
        ToolStripMenuItem editToolStripMenuItem;
        ToolStripMenuItem formatToolStripMenuItem;
        ToolStripMenuItem windowToolStripMenuItem;
        ToolStripMenuItem aboutToolStripMenuItem;
        ToolStripMenuItem newToolStripMenuItem;
        ToolStripMenuItem openToolStripMenuItem;
        ToolStripMenuItem safeToolStripMenuItem;
        ToolStripMenuItem safeasToolStripMenuItem;
        ToolStripMenuItem closeToolStripMenuItem;
        ToolStripMenuItem closeallToolStripMenuItem;
        ToolStripMenuItem exitToolStripMenuItem;
        ToolStripMenuItem toolbarToolStripMenuItem;
        ToolStripMenuItem statusbarToolStripMenuItem;
        ToolStripMenuItem undoToolStripMenuItem;
        ToolStripMenuItem redoToolStripMenuItem;
        ToolStripMenuItem cutToolStripMenuItem;
        ToolStripMenuItem copyToolStripMenuItem;
        ToolStripMenuItem pasteToolStripMenuItem;
        ToolStripMenuItem insertimageToolStripMenuItem;
        ToolStripMenuItem searchToolStripMenuItem;
        ToolStripMenuItem replaceToolStripMenuItem;
        ToolStripMenuItem fontToolStripMenuItem;
        ToolStripMenuItem colorToolStripMenuItem;
        ToolStripMenuItem cascadeToolStripMenuItem;
        ToolStripMenuItem tilehorizontalToolStripMenuItem;
        ToolStripMenuItem tileverticalToolStripMenuItem;
        ToolStripMenuItem arrangeiconsToolStripMenuItem;
        ToolStripMenuItem minimizeallToolStripMenuItem;
        ToolStripMenuItem maximizeallToolStripMenuItem;
        ToolStripMenuItem listToolStripMenuItem;
        StatusBar statusBar;
        Timer timer;
        int MDIchildFormNumber = 1;
        fmAbout aboutFormFlag;


        public Fmmain()
        {
            InitializeComponent();
            this.Text = "Головна програма";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true; 

            menuStrip = new MenuStrip();    
            fileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();    
            editToolStripMenuItem = new ToolStripMenuItem();    
            formatToolStripMenuItem = new ToolStripMenuItem();  
            windowToolStripMenuItem = new ToolStripMenuItem();  
            aboutToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem(); 
            openToolStripMenuItem = new ToolStripMenuItem();    
            safeToolStripMenuItem = new ToolStripMenuItem();
            safeasToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            closeallToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolbarToolStripMenuItem = new ToolStripMenuItem();
            statusbarToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            insertimageToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tilehorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileverticalToolStripMenuItem = new ToolStripMenuItem();
            arrangeiconsToolStripMenuItem = new ToolStripMenuItem();
            minimizeallToolStripMenuItem = new ToolStripMenuItem();
            maximizeallToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();

            menuStrip.Items.AddRange(new ToolStripItem[] {
                fileToolStripMenuItem,
                viewToolStripMenuItem,
                editToolStripMenuItem,
                formatToolStripMenuItem,
                windowToolStripMenuItem,
                aboutToolStripMenuItem});

            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                newToolStripMenuItem,
                openToolStripMenuItem,
                safeToolStripMenuItem,
                safeasToolStripMenuItem,
                closeToolStripMenuItem,
                closeallToolStripMenuItem,
                exitToolStripMenuItem
            });

            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                toolbarToolStripMenuItem,
                statusbarToolStripMenuItem
            });

            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                undoToolStripMenuItem,
                redoToolStripMenuItem,
                cutToolStripMenuItem,
                copyToolStripMenuItem,
                pasteToolStripMenuItem,
                insertimageToolStripMenuItem,
                searchToolStripMenuItem,
                replaceToolStripMenuItem
            });

            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                fontToolStripMenuItem,
                colorToolStripMenuItem
            });

            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                cascadeToolStripMenuItem,
                tilehorizontalToolStripMenuItem,
                tileverticalToolStripMenuItem,
                arrangeiconsToolStripMenuItem,
                minimizeallToolStripMenuItem,
                maximizeallToolStripMenuItem,
                listToolStripMenuItem
            });

            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";

            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";

            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";

            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(44, 20);
            editToolStripMenuItem.Text = "&Edit";

            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(50, 20);
            formatToolStripMenuItem.Text = "&Format";

            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(50, 20);
            windowToolStripMenuItem.Text = "&Window";

            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(50, 20);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;

            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\pageicon.png");
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Click += newToolMenuItem_Click;

            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\openicon.png");
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;

            safeToolStripMenuItem.Name = "safeToolStripMenuItem";
            safeToolStripMenuItem.Size = new Size(180, 22);
            safeToolStripMenuItem.Text = "Save";
            safeToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\saveicon.png");
            safeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            safeToolStripMenuItem.Click += saveToolStripMenuItem_Click;

            safeasToolStripMenuItem.Name = "safeasToolStripMenuItem";
            safeasToolStripMenuItem.Size = new Size(180, 22);
            safeasToolStripMenuItem.Text = "Save As";
            safeasToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;

            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;

            closeallToolStripMenuItem.Name = "closeallToolStripMenuItem";
            closeallToolStripMenuItem.Size = new Size(180, 22);
            closeallToolStripMenuItem.Text = "Close All";
            closeallToolStripMenuItem.Click += closeallToolStripMenuItem_Click;

            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            toolbarToolStripMenuItem.Size = new Size(180, 22);
            toolbarToolStripMenuItem.Text = "ToolBar";
            toolbarToolStripMenuItem.Click += toolbarToolStripMenuItem_Click;

            statusbarToolStripMenuItem.Name = "statusbarToolStripMenuItem";
            statusbarToolStripMenuItem.Size = new Size(180, 22);
            statusbarToolStripMenuItem.Text = "Status Bar";
            statusbarToolStripMenuItem.Click += statusbarToolStripMenuItem_Click;

            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\undoicon.png");
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;

            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\redoicon.png");
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;

            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\cuticon.png");
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;

            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\copyicon.png");
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;

            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Image = Image.FromFile(@"C:\!D\Halya\pasteicon.png");
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;

            insertimageToolStripMenuItem.Name = "insertimageToolStripMenuItem";
            insertimageToolStripMenuItem.Size = new Size(180, 22);
            insertimageToolStripMenuItem.Text = "Insert Image";
            insertimageToolStripMenuItem.Click +=  insertimageToolStripMenuItem_Click;

            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(180, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;

            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(180, 22);
            replaceToolStripMenuItem.Text = "Replace";
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;

            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;

            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;

            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;

            tilehorizontalToolStripMenuItem.Name = "tilehorizontalToolStripMenuItem";
            tilehorizontalToolStripMenuItem.Size = new Size(180, 22);
            tilehorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tilehorizontalToolStripMenuItem.Click += tilehorizontalToolStripMenuItem_Click;

            tileverticalToolStripMenuItem.Name = "tileverticalToolStripMenuItem";
            tileverticalToolStripMenuItem.Size = new Size(180, 22);
            tileverticalToolStripMenuItem.Text = "Tile Vertical";
            tileverticalToolStripMenuItem.Click += tileverticalToolStripMenuItem_Click;


            arrangeiconsToolStripMenuItem.Name = "arrangeiconsToolStripMenuItem";
            arrangeiconsToolStripMenuItem.Size = new Size(180, 22);
            arrangeiconsToolStripMenuItem.Text = "Arrange Icons";
            arrangeiconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;

            minimizeallToolStripMenuItem.Name = "minimizeallToolStripMenuItem";
            minimizeallToolStripMenuItem.Size = new Size(180, 22);
            minimizeallToolStripMenuItem.Text = "Minimize All";
            minimizeallToolStripMenuItem.Click +=  minimizeallToolStripMenuItem_Click;

            maximizeallToolStripMenuItem.Name = "maximizeallToolStripMenuItem";
            maximizeallToolStripMenuItem.Size = new Size(180, 22);
            maximizeallToolStripMenuItem.Text = "Maximize All";
            maximizeallToolStripMenuItem.Click +=  maximizeallToolStripMenuItem_Click;

            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(180, 22);
            listToolStripMenuItem.Text = "Список відкритих вікон";
            listToolStripMenuItem.DropDownOpening += UpdateOpenWindowsList;


            Controls.Add(menuStrip);

            statusBar = new StatusBar();
            statusBar.Visible = false;
            Controls.Add(statusBar);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void UpdateOpenWindowsList(object sender, EventArgs e)
        {
            ToolStripMenuItem listToolStripMenuItem = sender as ToolStripMenuItem;

            // Очищення списку підпунктів перед додаванням нових
            listToolStripMenuItem.DropDownItems.Clear();

            // Створення нового списку вікон
            List<Form> openWindows = new List<Form>();
            foreach (Form form in this.MdiChildren)
            {
                openWindows.Add(form);
            }

            // Додавання підпунктів до списку
            foreach (Form form in openWindows)
            {
                ToolStripMenuItem windowItem = new ToolStripMenuItem(form.Text);
                listToolStripMenuItem.DropDownItems.Add(windowItem);
            }

            if (openWindows.Count == 0)
            {
                ToolStripMenuItem noWindowsItem = new ToolStripMenuItem("Відкритих дочірніх вікон немає");
                noWindowsItem.Enabled = false;
                listToolStripMenuItem.DropDownItems.Add(noWindowsItem);
            }
        }
        private void newToolMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm MDIChildNew = new ChildForm();
            MDIChildNew.MdiParent = this;
            MDIChildNew.Text = "Дочірнє вікно " + MDIchildFormNumber++;
            MDIChildNew.Show();

            UpdateOpenWindowsList();
        }
       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool isChildFormOpen = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form is ChildForm)
                {
                    isChildFormOpen = true;
                    ((ChildForm)form).OpenFile();
                    break;
                }
            }

            if (!isChildFormOpen)
            {
                ChildForm newChildForm = new ChildForm();
                newChildForm.MdiParent = this;
                newChildForm.Text = "Дочірнє вікно " + MDIchildFormNumber++;
                newChildForm.OpenFile();
                newChildForm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null && activeChild is ChildForm)
            {
                string contentToSave = ((ChildForm)activeChild).GetContent();
                if (!string.IsNullOrEmpty(contentToSave))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, contentToSave);
                        MessageBox.Show("Файл збережено успішно.");
                    }
                }
                else
                {
                    MessageBox.Show("Немає вмісту для збереження.");
                }
            }
            else
            {
                MessageBox.Show("Немає активного дочірнього вікна для збереження.");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null && activeChild is ChildForm)
            {
                // Отримати текст з RichTextBox у дочірньому вікні
                string contentToSave = ((ChildForm)activeChild).GetContent();

                if (!string.IsNullOrEmpty(contentToSave))
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, contentToSave);
                        MessageBox.Show("Файл збережено успішно.");
                    }
                }
                else
                {
                    MessageBox.Show("Немає вмісту для збереження.");
                }
            }
            else
            {
                MessageBox.Show("Немає активного дочірнього вікна для збереження.");
            }
        }

        private bool isNewMenuItemClicked = false;
        private bool isOpenMenuItemClicked = false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F))
            {
                fileToolStripMenuItem.ShowDropDown();
            }

            if (keyData == (Keys.Alt | Keys.F | Keys.Control))
            {
                formatToolStripMenuItem.ShowDropDown();
            }

            if (keyData == (Keys.Alt | Keys.V))
            {
                viewToolStripMenuItem.ShowDropDown();
            }

            if (keyData == (Keys.Alt | Keys.E))
            {
                editToolStripMenuItem.ShowDropDown();
            }

            if (keyData == (Keys.Alt | Keys.W))
            {
                windowToolStripMenuItem.ShowDropDown();
            }

            if (!isNewMenuItemClicked)
            {
                if (keyData == (Keys.Control | Keys.N))
                {
                    isNewMenuItemClicked = true;
                    newToolMenuItem_Click(this, EventArgs.Empty);
                    return true;
                }
            }
            if (!isOpenMenuItemClicked)
            {
                if (keyData == (Keys.Control | Keys.O))
                {
                    isOpenMenuItemClicked = true;
                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            toolbarToolStripMenuItem.Checked = toolStrip1.Visible;
            toolStrip2.Visible = !toolStrip2.Visible;
            toolbarToolStripMenuItem.Checked = toolStrip2.Visible;
        }

        private void statusbarToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            statusBar.Visible = !statusBar.Visible;
            statusbarToolStripMenuItem.Checked = statusBar.Visible;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                statusBar.Text = $"{ActiveMdiChild.Text} - {DateTime.Now.ToString()}";
            }
            else
            {
                statusBar.Text = DateTime.Now.ToString();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void closeallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null && activeChild is ChildForm)
            {
                ((ChildForm)activeChild).Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null && activeChild is ChildForm)
            {
                ((ChildForm)activeChild).Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                RichTextBox RichBox = (RichTextBox)activeChild.ActiveControl;
                RichBox.Paste();
            }
        }

        private void insertimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null && activeChild is ChildForm)
            {
                
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    string imagePath = openFileDialog1.FileName;

                    // Отримати посилання на дочірню форму і привести її до типу ChildForm
                    ChildForm childForm = activeChild as ChildForm;

                    
                    childForm.pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null && activeChild is ChildForm)
            {
                ChildForm childForm = activeChild as ChildForm;

                
                FontDialog fontDialog = new FontDialog();

                
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    childForm.richTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null && activeChild is ChildForm)
            {
                ChildForm childForm = activeChild as ChildForm;

                ColorDialog colorDialog = new ColorDialog();

                
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    childForm.richTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }

        private void UpdateOpenWindowsList()
        {
            ToolStripMenuItem listToolStripMenuItem = null;

            
            foreach (ToolStripMenuItem item in windowToolStripMenuItem.DropDownItems)
            {
                if (item.Text == "Список відкритих вікон")
                {
                    listToolStripMenuItem = item;
                    break;
                }
            }

            
            listToolStripMenuItem.DropDownItems.Clear();

            
            foreach (Form mdiChild in this.MdiChildren)
            {
                ToolStripMenuItem windowItem = new ToolStripMenuItem(mdiChild.Text);
                listToolStripMenuItem.DropDownItems.Add(windowItem);
            }
            
            if (this.MdiChildren.Length == 0)
            {
                ToolStripMenuItem noWindowsItem = new ToolStripMenuItem("Відкритих дочірніх вікон немає");
                noWindowsItem.Enabled = false;
                listToolStripMenuItem.DropDownItems.Add(noWindowsItem);

            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tilehorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileverticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void minimizeallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren) 
                childForm.WindowState = FormWindowState.Minimized;

        }
        private void maximizeallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren) 
                childForm.WindowState = FormWindowState.Maximized;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutFormFlag == null)
            {
                aboutFormFlag = new fmAbout();
                aboutFormFlag.MdiParent = this;
                aboutFormFlag.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
                
                if (activeChild.richTextBox.SelectionLength > 0)
                {
                    
                    activeChild.richTextBox.SelectionFont = new Font(activeChild.richTextBox.SelectionFont, activeChild.richTextBox.SelectionFont.Style ^ FontStyle.Bold);
                }
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
               
                if (activeChild.richTextBox.SelectionLength > 0)
                {
                    
                    activeChild.richTextBox.SelectionFont = new Font(activeChild.richTextBox.SelectionFont, activeChild.richTextBox.SelectionFont.Style ^ FontStyle.Italic);
                }
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
                
                if (activeChild.richTextBox.SelectionLength > 0)
                {
                    
                    activeChild.richTextBox.SelectionFont = new Font(activeChild.richTextBox.SelectionFont, activeChild.richTextBox.SelectionFont.Style ^ FontStyle.Underline);
                }
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
                
                activeChild.richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
                
                activeChild.richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            
            if (ActiveMdiChild is ChildForm activeChild && activeChild.richTextBox != null)
            {
                
                activeChild.richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }
    }
}
