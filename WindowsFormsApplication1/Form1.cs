using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = ConfigurationManager.AppSettings["ImageFilePath"];
            var cl1 = new ClassLibrary1.Class1(imagePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.ClientSize = new Size(cl1.Picture.Width, cl1.Picture.Height);
            pictureBox1.Image = (Image) cl1.Picture;

            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.ClientSize = new Size(cl1.PictureFromJson.Width, cl1.PictureFromJson.Height);
            pictureBox2.Image = (Image)cl1.PictureFromJson;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
