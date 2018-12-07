using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//best score tut.
namespace MouseButonOyunu
{
    public partial class Form1 : Form
    {
        int best=int.MaxValue;
        int counter ;
        int x, y;
        public Form1()
        {
            InitializeComponent();

        }

        public void degis(int a,int b)
        {
            button1.Location = new Point(x, y);
        }

//butona tıklandıgında kazandınız mesajı yazsın.
        private void button1_Click(object sender, EventArgs e)
        {
            Best(best);
            counter =0;
            MessageBox.Show("tebrikler kazandınız.");
            label1.Text = "0";

            
        }

//mouse butona değdiği zaman buton yeniden konumlandırılsın.
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(ClientSize.Width-100);
            y = rnd.Next(ClientSize.Height-100);
            degis(x, y);
        }

//forma tıklandıgında sayac artsın.
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
            string ycounter = Convert.ToString(counter);
            label1.Text = ycounter;
           // best = counter;
            


        }
        public void Best(int x)
        {
            if (counter < best)
            {
                best = counter;
                bests.Text = Convert.ToString(best);
            }
        }

    }
}
