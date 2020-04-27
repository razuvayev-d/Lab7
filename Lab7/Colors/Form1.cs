using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        string color;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
            color = String.Format("#{0:X2}{1:X2}{2:X2}", panel1.BackColor.R, panel1.BackColor.G, panel1.BackColor.B);
            toolTip1.SetToolTip(panel1, color);
            try
            {
                Clipboard.SetText(color);
            }
            catch (Exception) { }
        }

       

        private void value_changed(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);         
        }

        private void resize_form(object sender, EventArgs e)
        {
            int n = 12;

            if (Height < 300 || Width < 780)
            {
                n = 12;

            }
            if (Height >= 300 && Height <= 600 || Width >= 780 && Width <= 1000)
            {
                n = 14;

            }
            if (Height > 600 || Width > 1000)
            {
                n = 16;
            }
            label1.Font = new Font(label1.Font.FontFamily, n);
            label2.Font = new Font(label2.Font.FontFamily, n);
            label3.Font = new Font(label3.Font.FontFamily, n);
            label4.Font = new Font(label4.Font.FontFamily, n);
            label5.Font = new Font(label5.Font.FontFamily, n);
            label6.Font = new Font(label6.Font.FontFamily, n);

           /* label7.Font = new Font(Font.FontFamily, n);
            label8.Font = new Font(Font.FontFamily, n);
            label9.Font = new Font(Font.FontFamily, n);*/

        }
    }
}
