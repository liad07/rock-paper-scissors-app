using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        static string[] game = { "אבן", "נייר", "מספריים" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            int num = rnd.Next(0, 3);
            label2.Text = "";
            label2.ForeColor = System.Drawing.Color.Black;
            // int x = Convert.ToInt32(this.textBox1.Text);
            string comp = game[num];
            if (comp == "אבן") {
                pictureBox1.ImageLocation = "https://www.nir-zvi.co.il/wp-content/uploads/2017/01/stone.jpg";
            }
            if (textBox1.Text == "אבן")
            {
                pictureBox2.ImageLocation = "https://www.nir-zvi.co.il/wp-content/uploads/2017/01/stone.jpg";

            }
            if (comp == "נייר")
            {
                pictureBox1.ImageLocation = "https://konimboimages.s3.amazonaws.com/system/photos/1782573/large/1549bf1ddf56c0d814edde2f872a41d7.jpg";
            }
            if (textBox1.Text == "נייר")
            {
                pictureBox2.ImageLocation = "https://konimboimages.s3.amazonaws.com/system/photos/1782573/large/1549bf1ddf56c0d814edde2f872a41d7.jpg";

            }
            if (comp == "מספריים")
            {
                pictureBox1.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Skalm_2.JPG/375px-Skalm_2.JPG";
            }
            if (textBox1.Text == "מספריים")
            {
                pictureBox2.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Skalm_2.JPG/375px-Skalm_2.JPG";

            }
            if (comp == "אבן" && textBox1.Text == "נייר")
            {
                label2.Text = "ניצחת";
                label2.ForeColor = System.Drawing.Color.Green;

            }
            if ((comp == "אבן") && (textBox1.Text == "מספריים"))
            {
                label2.Text = "הפסדת";
                label2.ForeColor = System.Drawing.Color.Red;

            }

            if (comp == "אבן" && textBox1.Text == "אבן")
            {
                label2.Text = "תיקו";
                label2.ForeColor = System.Drawing.Color.Blue;

            }
            if (comp == "נייר" && textBox1.Text == "אבן")
            {
                label2.Text = "הפסדת";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            if (comp == "נייר" && textBox1.Text == "מספריים")
            {
                label2.Text = "ניצחת";
                label2.ForeColor = System.Drawing.Color.Green;
            }
            if (comp == "נייר" && textBox1.Text == "נייר")
            {
                label2.Text = "תיקו";
                label2.ForeColor = System.Drawing.Color.Blue;
            }

            if (comp == "מספריים" && textBox1.Text == "נייר")
            {
                label2.Text = "הפסדת";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            if (comp == "מספריים" && textBox1.Text == "אבן")
            {
                label2.Text = "ניצחת";
                label2.ForeColor = System.Drawing.Color.Green;
            }
            if (comp == "מספריים" && textBox1.Text == "מספריים")
            {
                label2.Text = "תיקו";
                label2.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
