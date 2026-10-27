using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetogit_2._6
{
    public partial class Regsitar : Form
    {
        string pathToFile;

        public Regsitar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }







        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
                pathToFile = theDialog.FileName;

            }
        }

        private void textBox_passe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_esconder_Click(object sender, EventArgs e)
        {
            if (textBox_passe.PasswordChar == '\0')
            {
                textBox_passe.PasswordChar = '*';
                button_esconder.Text = "🙈";
            }
            else
            {
                textBox_passe.PasswordChar = '\0';
                button_esconder.Text = "👁️";
            }
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Froms1 paginaPrincipal = new Froms1();
            paginaPrincipal.Show();
            this.Hide();
        }


        private void button_adiconarconta_Click(object sender, EventArgs e)
        {
            
            if (textBox_utilizador.Text.Trim() == "" ||
                textBox_passe.Text == "" ||
                textBox_Nome.Text.Trim() == "")
            {
                MessageBox.Show("Preenche todos os campos obrigatórios!");
                return;
            }

            
            DateTime nascimento = dateTimePicker1.Value.Date;
            DateTime hoje = DateTime.Today;

            if (nascimento > hoje)
            {
                MessageBox.Show("A data de nascimento não pode ser futura!");
                return;
            }

            
            int idade = hoje.Year - nascimento.Year;

            if (nascimento > hoje.AddYears(-idade))
            {
                idade--;
            }

            
            if (idade < 18)
            {
                MessageBox.Show("Tens de ter pelo menos 18 anos para criar uma conta!");
                return;
            }


            Globais.Utilizador novo = new Globais.Utilizador();

            novo.NomeUtilizador = textBox_utilizador.Text.Trim();
            novo.NomeReal = textBox_Nome.Text.Trim();
            novo.PalavraPasse = textBox_passe.Text;
            novo.DataNascimento = dateTimePicker1.Value;

            Globais.listaUtilizadores[Globais.posicaoVazia] = novo;
            Globais.posicaoVazia++;

            MessageBox.Show("Conta registada com sucesso!");
        }

    }
}
