using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alımsatım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alısfiyati, satisfiyati, kar;
            alısfiyati = Convert.ToDouble(textBox1.Text);
            satisfiyati = Convert.ToDouble(textBox2.Text);
            kar = satisfiyati-alısfiyati;
            label3.Text = "Toplam Kar: " + kar;
        }
    }
}
