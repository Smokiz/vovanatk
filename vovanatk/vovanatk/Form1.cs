using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vovanatk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox2.TextLength < 10)
                {
                    label4.Text = "Длина пароля меньше допустимой. Минимальная длина 10 символа.";
                }
                else
                    if ((textBox2.TextLength == 10) && (textBox2.TextLength <= 70))
                {
                    label4.Text = "Длина пароля корректная";
                }
                else
                        if (textBox2.TextLength > 70)
                {
                    label4.Text = "Длина пароля превышает допустимую. Максимальная длина 70 символов.";
                }

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
