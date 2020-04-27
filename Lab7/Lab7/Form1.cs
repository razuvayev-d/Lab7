using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            const byte jmp = 5;
            int area = button1.Height;


           // bool CondRetX = (button1.Left < 0) || (button1.Right + button1.Width > this.Width);
            bool CondX = (e.X > button1.Left - area) && (e.X < button1.Left + button1.Width + area);
            bool CondY = ((e.Y > button1.Top - area) && (e.Y < button1.Top + button1.Height + area));

            if (CondX && CondY) 
            {
                if (CondX)
                {
                    bool CondRetX = (button1.Left < 0) || (button1.Right > this.ClientSize.Width);
                    if (!CondRetX)
                    {
                        if (e.X > button1.Left + button1.Width / 2)
                            button1.Left = button1.Left - jmp;
                        else
                            button1.Left = button1.Left + jmp;
                    }
                    else
                    {
                        //if (button1.Right > this.ClientSize.Width) button1.Left = 0;
                        //if (button1.Left < 0) button1.Left = this.ClientSize.Width - button1.Width;
                        Random r = new Random();
                        button1.Left = r.Next(0, this.ClientSize.Width - button1.Width);
                    }
                }
                
                if (CondY)
                {
                    bool CondRetY = (button1.Top < 0) || (button1.Top + button1.Height > this.ClientSize.Height);
                    if (!CondRetY)
                    {
                        if (e.Y < button1.Top + button1.Height / 2)
                            button1.Top = button1.Top + jmp;
                        else
                            button1.Top = button1.Top - jmp;
                    }
                    else
                    {
                        //button1.Top = 0;
                        Random r = new Random();
                        button1.Top = r.Next(0, this.ClientSize.Height - button1.Height);
                    }

                }

            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            MessageBox.Show("Поздравляем, вы смогли нажать на кнопку!","Поздравляем!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_resize(object sender, EventArgs e)
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;

            
        }
    }
}
