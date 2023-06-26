using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria.View
{
    public partial class LivrosForm : Form
    {
        public LivrosForm()
        {
            InitializeComponent();

            cBox_nomelivro.Items.Add("Harry Potter");
            cBox_nomelivro.Items.Add("Senhor dos Anéis");
            cBox_nomelivro.Items.Add("Percy Jackson");
            cBox_nomelivro.Items.Add("As Crônicas de Nárnia");
            cBox_nomelivro.Items.Add("Diario de um Banana");
        }

        private void cBox_nomelivro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string livros = cBox_nomelivro.Text;
            switch (livros)
            {
                case "Harry Potter":
                    lb_genero.Text = "Fantasia e Aventura";
                    lb_desconto.Text = "49,00";
                    break;
                case "Senhor dos Anéis":
                    lb_genero.Text = "Fantisia e Aventura";
                    lb_desconto.Text = "59,00";
                    break;
                case "Percy Jackson":
                    lb_genero.Text = "Fantasia e Aventura";
                    lb_desconto.Text = "39,00";
                    break;
                case "As Crônicas de Nárnia":
                    lb_genero.Text = "Fantisia e Aventura";
                    lb_desconto.Text = "55,00";
                    break;
                case "Diario de um Banana":
                    lb_genero.Text = "Fantisia e Aventura";
                    lb_desconto.Text = "39,00";
                    break;

            }
        }
    }
}