using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace SorteadorMime
{
    public partial class SorteadorMime : Form
    {
        Random randNum = new Random();
        List<int> lista = new List<int>();

        private OleDbConnection _olecon;
        private OleDbCommand _oleCmd;
        private static String _Arquivo = @"C:\Users\ti05\Documents\Sorteio.xlsx";
        private String _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
        private int totalLinhas = 0;

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
                upDownQtdFinal.Value = totalLinhas;
                lblQtdeTotal.Text = upDownQtdFinal.Value.ToString("#,###,###");
                lblUltimoNumero.Text = "-";
                timer.Enabled = false;
                //listaResultado.Items.Clear();
                lista.Clear();
                dgvDados.Rows.Clear();
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
            timer.Enabled = true;

            if (qtdNumerosSorteio == 0 || qtdNumerosFim == 0)
            {
                MessageBox.Show("Por favor informe a quantidade de números a serem sorteados e a quantidade total de números.");
            }
            else
            {
                for (int i = 0; i < qtdNumerosSorteio; i++)
                {
                    int numeroGerado = 0;
                    String nome = String.Empty, cargo = String.Empty, filial = String.Empty;
                    do
                    {
                        numeroGerado = randNum.Next(qtdNumerosInicio, qtdNumerosFim + 1);
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
                        try
                        {
                            _oleCmd.CommandText = "SELECT * FROM [Sorteio$] Where Numero = " + numeroGerado;
                            OleDbDataReader reader = _oleCmd.ExecuteReader();

                            while (reader.Read())
                            {

                                nome = reader.GetString(1);
                                cargo = reader.GetString(2);
                                filial = reader.GetString(3);
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgvDados.Rows.Add(numeroGerado.ToString("#,###,###"), nome, cargo, filial);
                        dgvDados.FirstDisplayedScrollingRowIndex = dgvDados.RowCount - 1;

                        lista.Add(numeroGerado);
                        //listaResultado.Items.Add(numeroGerado + " | " + nome + " | " + cargo + " | " + filial);
                        lblUltimoNumero.Text = numeroGerado.ToString("#,###,###");
                    }
                }
            }
        }

        private void SorteadorMime_Load(object sender, EventArgs e)
        {
            
            try
            {
                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;

                try
                {
                    
                    _oleCmd.CommandText = "SELECT count(1) FROM [Sorteio$]";
                    OleDbDataReader readerCount = _oleCmd.ExecuteReader();

                    while (readerCount.Read())
                    {
                        totalLinhas = readerCount.GetInt32(0);
                    }
                    readerCount.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                upDownQtdFinal.Value = totalLinhas;
                lblQtdeTotal.Text = upDownQtdFinal.Value.ToString("#,###,###");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnImportaExcel_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                _Arquivo = ofd1.FileName;

            if (!string.IsNullOrEmpty(_Arquivo))
            {
                
                try
                {
                    _StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
                    _olecon = new OleDbConnection(_StringConexao);
                    _olecon.Open();

                    _oleCmd = new OleDbCommand();
                    _oleCmd.Connection = _olecon;
                    _oleCmd.CommandType = CommandType.Text;

                    try
                    {

                        _oleCmd.CommandText = "SELECT count(1) FROM [Sorteio$]";
                        OleDbDataReader readerCount = _oleCmd.ExecuteReader();

                        while (readerCount.Read())
                        {
                            totalLinhas = readerCount.GetInt32(0);
                        }
                        readerCount.Close();

                        MessageBox.Show("Arquivo importado com Sucesso!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    upDownQtdFinal.Value = totalLinhas;
                    lblQtdeTotal.Text = upDownQtdFinal.Value.ToString("#,###,###");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void upDownQtdFinal_ValueChanged(object sender, EventArgs e)
        {
            lblQtdeTotal.Text = upDownQtdFinal.Value.ToString("#,###,###");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Color vermelhoMime = new Color();
            vermelhoMime = Color.FromArgb(235, 36, 65);


            lblUltimoNumero.ForeColor = lblUltimoNumero.ForeColor == vermelhoMime ? Color.White : vermelhoMime;
        }
    }
}
