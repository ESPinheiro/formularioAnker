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
    public partial class Form2 : Form
    {
        public string Dados
        {
            get { return textBoxDados.Text; }
            set { textBoxDados.Text = value; }
        }
        public string novosDados
        {
            get { return textBoxDados.Text; }
            set { textBoxDados.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
            //novosDados = Dados;
        }

        //public Form2(string Dados) : this()
        //{
        //    textBoxDados.Text = Dados;
        //    textBoxRetorno.Text = form2.Dados;
        //}
        //public string obterDados()
        //{
        //    return novosDados;
        //}
        private void Form2_Load(object sender, EventArgs e)
        {
            //configurando from como modal
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //salvar dados no form1
            Dados = textBoxDados.Text;
            this.Close();
        }

       
        private void btnDependentes_Click(object sender, EventArgs e)
        {//pendente não consegui salvar os dados na form1
            novosDados = textBoxDados.Text;


            this.Close();
        }

       
    }
}
