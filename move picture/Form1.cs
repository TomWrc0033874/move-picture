using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }












        private async void Button5_Click(object sender, EventArgs e)
        {    if(pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
            }   await Task.Delay(500);
        }




        private async void Button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                for (int i = 0; i < 10; i++)
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                await Task.Delay(100);
            }
        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }



        private void Button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }  
}   
   
 
    
    


