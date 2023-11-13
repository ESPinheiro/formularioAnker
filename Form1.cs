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
    public partial class Form1 : Form
    {
        // Exemplo de dados (substitua isso pelos seus próprios dados)
        private DataTable dados = new DataTable();
       // private object datagridViewDados;

        public Form1()
        {
            InitializeComponent();

            //comboBox exemplo,modificar para BD
            // Inicializa o DataTable com dados fictícios para este exemplo
            dados.Columns.Add("Nome", typeof(string));
            dados.Columns.Add("Idade", typeof(int));
            dados.Rows.Add("João", 25);
            dados.Rows.Add("Maria", 30);
            dados.Rows.Add("Carlos", 22);

            PreencherComboBox();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //NovoRegistro – Deverá incluir um registro na base de dados;

            //using (var form2 = new Form2())
            //{
            //    //form2.Dados = textBoxDados.Text;
            //    //form2.ShowDialog();
            //    //obtendo o texto do inserido
            //    //string dado = textBoxDados.Text;

            //    //defina o caminho para salvar o arquivo
            //    string caminhoArquivo = "Caminho\\Para\\O\\Seu\\Arquivo.txt";

            //}

            Form2 form2 = new Form2();
            form2.ShowDialog();

            // Verifica se o texto foi inserido em Form2 antes de atualizar Form1
            if (!string.IsNullOrEmpty(form2.Dados))
            {
                // Atualiza o TextBox em Form1 com o texto de Form2
                textBoxDados.Text = form2.Dados;
              
            }
            //obtendo dados dos dependentes
            //string novosDados = form2.obterDados();

            //atualiza os dados no form1
            if (!string.IsNullOrEmpty(form2.novosDados))
            {
                textBoxDados.Text = form2.novosDados;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // ExcluiRegistro – Deverá excluir um registro da base de dados;

            //defina o caminho para excluir no BD o arquivo
            //string caminhoArquivo = "Caminho\\Para\\O\\Seu\\Arquivo.txt";
            textBoxDados.Text = string.Empty;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //obtendo o texto do inserido
            string dado = textBoxDados.Text;

            //defina o caminho para salvar o arquivo
            string caminhoArquivo = "Caminho\\Para\\O\\Seu\\Arquivo.txt";

            //escreva os dados no arquivo
            try
            {
                //File.WriteAllText(caminhoArquivo, texto);
                MessageBox.Show("Dados salvo com sucesso.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar os dados: {ex.Message}");
            }

        }
        //public string AlterarDados(Form2)
        //{
        //    return 
        //}

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Alterar – Deverá permitir abrir a tela de cadastro do registro selecionado, no modo de edição;
            //Poderá ser acionado por um botão ou double-click no registro;

            //dados para alterar
            //string novoDados = "Novo Dado";
            //atribui um novo dado ao textbox
            //textBoxDados.Text = textBoxDados.Text;
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" prox");
        }
        //exemplos de preenchimento de combobox mudar BD
         private void PreencherComboBox()
        {
            List<int> idades = new List<int>();
            foreach (DataRow row in dados.Rows)
            {
                int idade = Convert.ToInt32(row["Idade"]);
                if (!idades.Contains(idade))
                {
                    idades.Add(idade);
                }
            }
            // Ordena os valores
            idades.Sort();

            // Adiciona os valores ao ComboBox
            comboBoxFiltro.DataSource = idades;
        }

        private void AplicarFiltro()
        {
            // Obtém o valor selecionado no ComboBox
            if (comboBoxFiltro.SelectedItem != null)
            {
                int valorSelecionado = (int)comboBoxFiltro.SelectedItem;

                // Filtra os dados com base no valor selecionado
                DataView dv = new DataView(dados);
                dv.RowFilter = $"Idade = {valorSelecionado}";

                // Se o valor selecionado for -1, não aplicamos filtro
                if (valorSelecionado != -1)
                {
                    dv.RowFilter = $"Idade = {valorSelecionado}";
                }

                // Atualiza o DataGridView (ou outra parte do seu aplicativo) com os dados filtrados
                //datagridViewDados.DataSource = dv.ToTable();
            }
        }
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando o item selecionado no ComboBox muda, aplica o filtro
            AplicarFiltro();
        }
    }
}
