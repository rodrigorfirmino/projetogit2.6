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
            Regsitar paginaPrincipal = new Regsitar();
            paginaPrincipal.Show();
            this.Hide();
        }
    }
}
