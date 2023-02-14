using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converterFahrenheitCelsius
{
    public partial class converterTemperaturas : Form
    {
        public converterTemperaturas()
        {
            InitializeComponent();
        }

        private void txtEntradaValorr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelSelecioneConversão_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if(this.comboBoxSelecionarFouC.SelectedIndex == 0)
            {
                float valorC = 0;
                if(float.TryParse(txtEntradaValorr.Text, out valorC))
                {
                    float C = (valorC * 9/5) + 32;
                    txtSaidaCº.Text = $"{valorC}";
                    txtSaisaFº.Text = $"{C}";
                }
                else
                {
                    txtMensagem.Text = "VALOR\nINVÁLIDO!";
                    txtEntradaValor.Text = "";
                }
            }else if(this.comboBoxSelecionarFouC.SelectedIndex == 1)
            {
                float valorF = 0;
                if(float.TryParse(txtEntradaValorr.Text, out valorF))
                {
                    float F = (valorF - 32) * 5 / 9;
                    txtSaisaFº.Text = $"{F}";
                    txtSaidaCº.Text = $"{valorF}";

                }
                else
                {
                    txtMensagem.Text = "VALOR\nINVÁLIDO!";
                    txtEntradaValor.Text = "";
                }
            }
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
