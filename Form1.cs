using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aula63_Exer2_Locacao.Servico;
using static WF_Aula63_Exer2_Locacao.Servico.Cliente;
using static WF_Aula63_Exer2_Locacao.Servico.Livro;

namespace WF_Aula63_Exer2_Locacao
{
    public partial class Form1 : Form
    {
        List<Livro> livros = RepositoryLivros.InicializarLivros();
        List<Cliente> clientes = RepositoryCliente.InicializarCliente();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Livro livro in livros)
            {
                cmbLivros.Items.Add(livro);            
            }
            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int valorLivro = 10, diasMais = 0, multa, totalMulta =0;
            string locacao = txtBoxLocacao.Text;
            string entrega = txtBoxDevolucao.Text;
            int devolucao = (DateTime.Parse(entrega).Subtract(DateTime.Parse(locacao))).Days;
            label1.Text = devolucao.ToString();
           
            if (devolucao > 5)
            {
                diasMais = devolucao - 5;
                multa = diasMais * 5;
                totalMulta = valorLivro + multa;
                lblvalorLivro.Text = valorLivro.ToString();
                lblMulta.Text = multa.ToString();
                lblTotal.Text = totalMulta.ToString();               
            }
            else
            {
                lblvalorLivro.Text = valorLivro.ToString();
                lblTotal.Text = valorLivro.ToString();
            }

            MessageBox.Show("Cliente: " + cmbCliente.Text + "\n\nLivro: " + cmbLivros.Text +
               "\n\nDias que passou do Prazo: " + diasMais +" dias " + "\n\nValor Total: R$ " + 
               lblTotal.Text +",00");
        }
    }
}
