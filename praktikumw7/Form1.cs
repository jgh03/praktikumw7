using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string simpanKalimat = textBoxInput.Text.ToUpper();
            char[] charArr = simpanKalimat.ToCharArray();
            char hurufPertama = Convert.ToChar(textBoxHuruf1.Text.ToUpper());
            char hurufKedua = Convert.ToChar(textBoxHuruf2.Text.ToUpper());

            int temphurufPertama = Convert.ToInt32(hurufPertama);
            int temphurufKedua = Convert.ToInt32(hurufKedua);
            int jarak = temphurufKedua - temphurufPertama;
            string hasil = "";

            foreach (char a in charArr)
            {
                int temp = Convert.ToInt32(a) + jarak;
                if (temp == 115)
                {
                    temp = 65;
                }
                else if (temp > 90)
                {
                    temp = temp - 26;
                }
                hasil = hasil + Convert.ToChar(temp).ToString();
            }
            labelOutput.Text = hasil.ToString();
        }
    }
}