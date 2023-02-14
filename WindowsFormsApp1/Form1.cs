using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conversaolbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            if(conversaoCb.SelectedIndex == 0)
            {
                float c = 0;
                if(float.TryParse(valorConverterTxt.Text, out c))
                {
                    float f = ((float)c * 9 / 5) + 32;
                    valorConvertidoTxt.Text = $"{f}";
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    valorConvertidoTxt.Text = "";
                }
            }

            else if(conversaoCb.SelectedIndex == 1)
            {
                float f = 0;
                if(float.TryParse(valorConverterTxt.Text,out f))
                {
                    float c = ((float)f - 32) * 5 / 9;
                    valorConvertidoTxt.Text = $"{c}";
                }
                else
                {
                    MessageBox.Show("Valor inválido");
                    valorConvertidoTxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de conversão!");
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            valorConverterTxt.Clear();
            valorConvertidoTxt.Clear();
        }
    }
}
