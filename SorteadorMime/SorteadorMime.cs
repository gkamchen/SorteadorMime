using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SorteadorMime
{
    public partial class SorteadorMime : Form
    {
        Random randNum = new Random();

        List<int> lista = new List<int>();

        public SorteadorMime()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult perguntaSimNao = MessageBox.Show("Tem certeza que deseja limpar os dados do sorteador?", "Limpar Dados", MessageBoxButtons.YesNo);
            if (perguntaSimNao == DialogResult.Yes)
            {
                upDownQtdSort.Value = 1;
                upDownQtdInicial.Value = 1;
                upDownQtdFinal.Value = 1;
                lblUltimoNumero.Text = "-";
                listaResultado.Items.Clear();
                lista.Clear();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeraNumeros_Click(object sender, EventArgs e)
        {
            Int32 qtdNumerosSorteio = Convert.ToInt32(upDownQtdSort.Value);
            Int32 qtdNumerosInicio = Convert.ToInt32(upDownQtdInicial.Value);
            Int32 qtdNumerosFim = Convert.ToInt32(upDownQtdFinal.Value);

            if (qtdNumerosSorteio == 0 || qtdNumerosFim == 0)
            {
                MessageBox.Show("Por favor informe a quantidade de números a serem sorteados e a quantidade total de números.");
            }
            else
            {
                for (int i = 0; i < qtdNumerosSorteio; i++)
                {
                    int numeroGerado = 0;
                    do
                    {
                        numeroGerado = randNum.Next(qtdNumerosInicio, qtdNumerosFim+1);
                        if (lista.Count == qtdNumerosFim && lista.Contains(numeroGerado))
                        {
                            MessageBox.Show("Não existem mais números disponíveis!");
                            break;
                        }
                    } while (lista.Contains(numeroGerado));
                    if (lista.Count == qtdNumerosFim)
                    {
                        break;
                    }
                    else
                    {
                        lista.Add(numeroGerado);
                        listaResultado.Items.Add(numeroGerado);
                        lblUltimoNumero.Text = numeroGerado.ToString();
                    }
                   
                }

            }
        }
    }
}
