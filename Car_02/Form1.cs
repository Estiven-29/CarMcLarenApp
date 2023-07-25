using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cpt = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(5);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("Car\\1.png");
            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("Car\\2.png");
            guna2DataGridView1.Rows[2].Cells[0].Value = Image.FromFile("Car\\3.png");
            guna2DataGridView1.Rows[3].Cells[0].Value = Image.FromFile("Car\\4.png");
            guna2DataGridView1.Rows[4].Cells[0].Value = Image.FromFile("Car\\5.png");


            guna2DataGridView1.Rows[0].Cells[1].Value = "McLaren 750S Spider";
            guna2DataGridView1.Rows[1].Cells[1].Value = "McLaren Artura";
            guna2DataGridView1.Rows[2].Cells[1].Value = "McLaren 570 GT";
            guna2DataGridView1.Rows[3].Cells[1].Value = "McLaren 675 LT";
            guna2DataGridView1.Rows[4].Cells[1].Value = "McLaren Solus GT";
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < guna2DataGridView1.Rows.Count)
            {
                cpt++;
                guna2PictureBox_car.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabelName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_car1.Load("Car\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_car2.Load("Car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_car3.Image = guna2PictureBox_car.Image;
                
            }
            else cpt = 1;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                guna2PictureBox_car.Image = (Image)guna2DataGridView1.Rows[cpt - 1].Cells[0].Value;
                gunaLabelName.Text = guna2DataGridView1.Rows[cpt - 1].Cells[1].Value.ToString();
                guna2PictureBox_car1.Load("Car\\" + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_car2.Load("Car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + ".png");
                guna2PictureBox_car3.Image = guna2PictureBox_car.Image;
                
            }
            else cpt = 1;
        }

        private void guna2PictureBox_car1_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Image = guna2PictureBox_car1.Image;
        }

        private void guna2PictureBox_car2_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Image = guna2PictureBox_car2.Image;
        }

        private void guna2PictureBox_car3_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Image = guna2PictureBox_car3.Image;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox_car.Load("Car\\" + cpt.ToString() + "bl.png");
            
            guna2PictureBox_car1.Load("Car\\" + cpt.ToString() + cpt.ToString() + "bl.png");
            guna2PictureBox_car2.Load("Car\\" + cpt.ToString() + cpt.ToString() + cpt.ToString() + "bl.png");
            guna2PictureBox_car3.Load("Car\\" + cpt.ToString() + "bl.png");
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
