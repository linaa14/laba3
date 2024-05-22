using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pglab3_task2
{
    public partial class fmAbout : Form
    {
        PictureBox pictureBox;
        Label label1;
        public fmAbout()
        {
            InitializeComponent();
            this.Text = "Про програму";
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(200, 250);
            pictureBox.Location = new Point(25, 25);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(@"C:\!D\Halya\comp.jpg");
            this.Controls.Add(pictureBox);

            label1 = new Label();
            label1.Location = new Point(300, 75);
            label1.Size = new Size(200, 250);
            label1.Text = "Пробна програма";
            label1.Font = new Font("Arial", 10, FontStyle.Bold); ;
            this.Controls.Add(label1);
        }

        private void fmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
