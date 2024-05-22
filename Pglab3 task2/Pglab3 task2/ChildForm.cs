using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Pglab3_task2
{
    internal class ChildForm : Form
    {
        public RichTextBox richTextBox;
        public PictureBox pictureBox;

        public ChildForm()
        {
            
            InitializeComponents();
        }
        private void InitializeComponents()
        {
            // Створюємо RichTextBox
            richTextBox = new RichTextBox();
            richTextBox.Size = new Size(200, 100);
            richTextBox.Location = new Point(0, 0);

            // Створюємо PictureBox
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 200);
            pictureBox.Location = new Point(0, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            
            this.Controls.Add(richTextBox);
            this.Controls.Add(pictureBox);
        }

        public void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;


                string fileContent = File.ReadAllText(filePath);


                richTextBox.Text = fileContent;

            }
        }

        public string GetContent()
        {
            return richTextBox.Text;
        }

        public void Undo()
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        public void Redo()
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }
    }
}