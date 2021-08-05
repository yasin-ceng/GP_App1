using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_App1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        //Fotoğraf Ölçeklendirme Buton İşlevleri
        private void btnImgScl_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Lütfen Resim Yükleyin");
            else
            {
                if (textBoxW.Text != "" && textBoxH.Text != "")
                {
                    double w_k, h_k;
                    w_k = Convert.ToDouble(textBoxW.Text);
                    h_k = Convert.ToDouble(textBoxH.Text);
                    pictureBox1.Width = Convert.ToInt32(pictureBox1.Width * w_k);
                    pictureBox1.Height = Convert.ToInt32(pictureBox1.Height * h_k);


                }
            }
        }

        private void btnImgUp_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();

             if (open.ShowDialog() == DialogResult.OK ){
                
                pictureBox1.Image = new Bitmap(open.FileName);
                
            }

        }

        private void btnImgPos_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Lütfen Resim Yükleyin");
            else
            {
                int x, y;
                x = pictureBox1.Location.X;
                y = pictureBox1.Location.Y;

                MessageBox.Show("x.loc:" + Convert.ToString(x) +" y.loc:"+ Convert.ToString(y));

                if (textBoxX.Text != "" && textBoxY.Text != "")
                {
                    int x_arti, y_arti;
                    x_arti = Convert.ToInt32(textBoxX.Text);
                    y_arti = Convert.ToInt32(textBoxY.Text);
                    x = x + x_arti;
                    y = y + y_arti;
                    pictureBox1.Location = new Point(x, y);

                    MessageBox.Show("x_arti:" + Convert.ToString(x_arti) + " y_arti:" + Convert.ToString(y_arti));
                    MessageBox.Show("x_son:" + Convert.ToString(x) + " y_son:" + Convert.ToString(y));

                }
            }
        }

        private void btnRotateR_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Lütfen Resim Yükleyin");
            else 
            {
                Image img;
                img = pictureBox1.Image;

                img.RotateFlip(RotateFlipType.Rotate90FlipNone); // Saat Yönü Dönüş

                pictureBox1.Image = img;
            }
        }

        private void btnRotateL_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                MessageBox.Show("Lütfen Resim Yükleyin");
            else
            {
                Image img;
                img = pictureBox1.Image;

                img.RotateFlip(RotateFlipType.Rotate90FlipXY);  //Saat Yönü Tersi Dönüş

                pictureBox1.Image = img;
            }
        }
    }
}
