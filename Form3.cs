using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFormulario
{
    public partial class Form3 : Form

    {
        public string NovosDados
        {
            get { return textBoxNovosDados.Text; }
            set { textBoxNovosDados.Text = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }
  
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //obtendo o texto do inserido
            string NovosDados = textBoxNovosDados.Text;

            //defina o caminho para salvar o arquivo
            string caminhoArquivo = "Caminho\\Para\\O\\Seu\\Arquivo.txt";

            //escreva os dados no arquivo
            try
            {
                //File.WriteAllText(caminhoArquivo, texto);
                MessageBox.Show("Dados Aterados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar os dados: {ex.Message}");
            }
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

       
    }
}
