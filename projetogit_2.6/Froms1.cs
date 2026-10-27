using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetogit_2._6
{
    public partial class Froms1 : Form
    {
        public Froms1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_registar_Click(object sender, EventArgs e)
        {
            Regsitar paginaPrincipal = new Regsitar();
            paginaPrincipal.Show();  
            this.Hide();
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            string nome = textBox_utilizador.Text.Trim();
            string passe = textBox_passe.Text;

            bool encontrado = false;

            for (int i = 0; i < Globais.posicaoVazia; i++)
            {
                if (Globais.listaUtilizadores[i].NomeUtilizador == nome &&
                    Globais.listaUtilizadores[i].PalavraPasse == passe)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Sessão iniciada com sucesso!");

                // Abre o formulário principal depois do login
                Froms1 paginaPrincipal = new Froms1();
                paginaPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe incorretos!");
            }
        }
    }
}
