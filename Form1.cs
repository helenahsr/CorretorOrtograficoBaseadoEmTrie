using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrieOrtografica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Trie auto = new Trie();
        private string _caminhoArquivoDicionario = string.Empty;

        private void btnInserirPalavra_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text == "")
            {
                MessageBox.Show("Digite uma palavra para inserir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtPalavra.Focus();
                return;
            }
            try
            {
                auto.Inserir(txtPalavra.Text);
                txtPalavra.Text = string.Empty;
                txtPalavra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir palavra: " + ex.Message);
            }
        }

        private void txtPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.SuppressKeyPress = true;
                sobreToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnInserirPalavra_Click(sender, e);
            }
            if (e.KeyCode == Keys.Space)
            {
                txtPalavra.Text = txtPalavra.Text.Trim();
                txtPalavra.Focus();
            }
        }

        private void txtPalavra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        private void listaDePalavrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lstPalavrasAdicionadas.Items.Clear();
                List<string> palavras = auto.ComecaCom(txtPalavra.Text);
                int indice = 0;
                foreach (string palavra in palavras)
                {
                    indice++;
                    lstPalavrasAdicionadas.Items.Add(indice + " - " + palavra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar palavras: " + ex.Message);
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            string textoDigitado = txtTexto.Text;

            int ultimoSeparadorIndex = textoDigitado.LastIndexOfAny(new char[] { ' ', '.', ',', ';', ':' });

            string prefixoParaBuscar = "";

            if (ultimoSeparadorIndex == -1)
            {
                prefixoParaBuscar = textoDigitado.ToLower();
            }
            else if (ultimoSeparadorIndex < textoDigitado.Length - 1)
            {
                prefixoParaBuscar = textoDigitado.Substring(ultimoSeparadorIndex + 1).ToLower();
            }

            if (!string.IsNullOrEmpty(prefixoParaBuscar))
            {
                List<string> sugestoes = auto.ComecaCom(prefixoParaBuscar).Take(5).ToList();
                lstSugestao.DataSource = sugestoes;
                lstSugestao.Visible = sugestoes.Any();
            }
            else
            {
                lstSugestao.Visible = false;
            }
        }

        private void lstSugestao_DoubleClick_1(object sender, EventArgs e)
        {
            if (lstSugestao.SelectedItem != null)
            {
                string sugestaoSelecionada = lstSugestao.SelectedItem.ToString();
                string textoAtual = txtTexto.Text;

                int ultimoSeparadorIndex = textoAtual.LastIndexOfAny(new char[] { ' ', '.', ',', ';', ':' });

                int startIndex = 0;
                if (ultimoSeparadorIndex != -1)
                {
                    startIndex = ultimoSeparadorIndex + 1;
                }

                string novoTexto = "";
                if (startIndex > 0)
                {
                    novoTexto = textoAtual.Substring(0, startIndex) + sugestaoSelecionada;
                }
                else
                {
                    novoTexto = sugestaoSelecionada;
                }

                txtTexto.Text = novoTexto;
                txtTexto.SelectionStart = novoTexto.Length;
                lstSugestao.Visible = false;
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Corretor Ortográfico (Árvore Trie).\nDesenvolvido por Helena Rezende.\nVersão 1.4.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            openFileDialog.Title = "Selecionar Arquivo de Dicionário";
            openFileDialog.FileName = _caminhoArquivoDicionario;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CarregarDicionario(openFileDialog.FileName);
            }
            listaDePalavrasToolStripMenuItem_Click(sender, e);
        }
        private void CarregarDicionario(string caminhoArquivo)
        {
            _caminhoArquivoDicionario = caminhoArquivo;
            auto = new Trie();
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    string[] palavras = File.ReadAllLines(caminhoArquivo);
                    foreach (string palavra in palavras)
                    {
                        if (!string.IsNullOrWhiteSpace(palavra))
                        {
                            auto.Inserir(palavra.Trim().ToLower());
                        }
                    }
                    MessageBox.Show($"Dicionário carregado com sucesso de '{caminhoArquivo}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Arquivo de dicionário '{caminhoArquivo}' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _caminhoArquivoDicionario = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o dicionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _caminhoArquivoDicionario = string.Empty;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.SuppressKeyPress = true;
                sobreToolStripMenuItem_Click(sender, e);
            }
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                e.SuppressKeyPress = true;
                sobreToolStripMenuItem_Click(sender, e);
            }
        }

        private void bloquearInserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled == true)
                groupBox1.Enabled = false;
            else
                groupBox1.Enabled = true;
        }
    }
}
