using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// запретить изменять размер окна
// сделать отталкивание от всего
// код - поставить флажок и если он не правильный сделай как было
namespace дурак_версия_2
{
    public partial class Form1 : Form
    {
        bool f = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!f)
            {
                int xcurs = e.X;
                int ycurs = e.Y;
                // у кнопки есть x :Left right,y: botton Top
                //Сделать чтобы button1 обходила textbox. Кнопка приблежается слева к textbox
                if ((button1.Right >= (buttontxt.Left - 10) && button1.Right <= buttontxt.Left
                    && (button1.Top < buttontxt.Bottom && button1.Top > buttontxt.Top
                    || button1.Bottom > buttontxt.Top && button1.Bottom < buttontxt.Bottom)))
                {
                    button1.Left = (buttontxt.Right + 10);
                    button1.Top = (buttontxt.Bottom+10);
                }
                // если кнопку приблежается справа налево к textbox
                if (button1.Left > buttontxt.Right && (button1.Left < buttontxt.Right + 10)
                    && (button1.Bottom > buttontxt.Top && button1.Bottom < buttontxt.Bottom
                    || button1.Top > buttontxt.Top && button1.Top < buttontxt.Bottom))
                {
                    button1.Left = (buttontxt.Right + 10);
                    button1.Top = (buttontxt.Bottom + 10);
                }
                // если приблежаемся снизу к textbox
                if (button1.Top > buttontxt.Bottom && (button1.Top < buttontxt.Bottom + 10)
                    && (button1.Left < buttontxt.Right && button1.Left > buttontxt.Left
                    || button1.Right > buttontxt.Left && button1.Right < buttontxt.Right))
                {
                    button1.Left = (buttontxt.Right + 10);
                    button1.Top = (buttontxt.Bottom + 10);
                }
                // если приблежаемс сверху к textbox
                if ((button1.Bottom > buttontxt.Top - 10) && button1.Bottom < buttontxt.Top
                    && (button1.Left < buttontxt.Right && button1.Left > buttontxt.Left
                    || button1.Right > buttontxt.Left && button1.Right < buttontxt.Right))
                {
                    button1.Left = (buttontxt.Right + 10);
                }

                // вправо
                if (xcurs < button1.Left && xcurs > (button1.Left - 10) && ycurs > button1.Top
                && ycurs < button1.Bottom)
                {
                    button1.Left += 5;
                }
                // влево
                if (xcurs > button1.Right && xcurs < (button1.Right + 10)
                    && ycurs > button1.Top && ycurs < button1.Bottom)
                {
                    button1.Left -= 5;
                }

                // вниз
                if (xcurs < button1.Right && xcurs > button1.Left
                    && ycurs > (button1.Top - 10) && ycurs < button1.Top)
                {
                    button1.Top += 5;
                }
                //вверх
                if (xcurs < button1.Right && xcurs > button1.Left &&
                    (ycurs < button1.Bottom + 10) && ycurs > button1.Bottom)
                {
                    button1.Top -= 5;
                }
                //вверх вправо
                if ((xcurs > button1.Left - 10) && xcurs < button1.Left && (ycurs < button1.Bottom + 10)
                    && ycurs > button1.Bottom)
                {
                    button1.Top -= 5;
                    button1.Left += 5;
                }

                //вниз вправо
                if ((xcurs > button1.Left - 10) && xcurs < button1.Left
                        && ycurs < button1.Top && (ycurs > button1.Top - 10))
                {
                    button1.Left += 5;
                    button1.Top += 5;
                }
                //вниз влево
                if (xcurs > button1.Right && (xcurs < button1.Right + 10) &&
                   ycurs < button1.Top && (ycurs > button1.Top - 10))
                {
                    button1.Top += 5;
                    button1.Left -= 5;
                }
                //вверх влево
                if (xcurs > button1.Right && (xcurs < button1.Right + 10)
                    && (ycurs < button1.Bottom + 10) && ycurs > button1.Bottom)
                {
                    button1.Left -= 5;
                    button1.Top -= 5;
                }

                if (button1.Left <= -4 || button1.Top <= -4 || button1.Bottom >= (this.Size.Height - 35)
                    || button1.Right >= (this.Size.Width - 13))
                {
                    button1.Top = 125;
                    button1.Left = 360;
                }
                // если справа приблежаемся справа
                if (button1.Right >= (button2.Left - 10) && button1.Right <= button2.Left
                    && (button1.Top < button2.Bottom && button1.Top > button2.Top
                    || button1.Bottom > button2.Top && button1.Bottom < button2.Bottom))
                {
                    button1.Top = (button2.Bottom + 10);
                }
                // если приблежаеся слева
                if (button1.Left > button2.Right && (button1.Left < button2.Right + 10)
                    && (button1.Bottom > button2.Top && button1.Bottom < button2.Bottom
                    || button1.Top > button2.Top && button1.Top < button2.Bottom))

                {
                    button1.Top = (button2.Bottom + 10);
                }
                //если приблежаемся снизу
                if (button1.Top > button2.Bottom && (button1.Top < button2.Bottom + 10)
                    && (button1.Left < button2.Right && button1.Left > button2.Left
                    || button1.Right > button2.Left && button1.Right < button2.Right))
                {
                    button1.Left = (button2.Right + 10);
                    button1.Top = (button2.Bottom + 10);
                }
                //сверху
                if ((button1.Bottom > button2.Top - 10) && button1.Bottom < button2.Top
                    && (button1.Left < button2.Right && button1.Left > button2.Left
                    || button1.Right > button2.Left && button1.Right < button2.Right))
                {
                    button1.Left = (button2.Right + 10);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f)
            {
                MessageBox.Show("Как тебе удалось?");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Не сегодня!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляю!");
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234")
                f = true;
            else
                f = false;
        }
    }
}
