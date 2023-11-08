using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEPWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskCep_Leave(object sender, EventArgs e)
        {
            BuscarCep(maskCep.Text);
        }
        async Task BuscarCep(string cep)
        {
            try
            {
                var cepbuscar = RestService.For<ICepApiService>("https://viacep.com.br");
                var endereço = await cepbuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereço.Logradouro;
                txtBairro.Text = endereço.Bairro;
                txtComplemento2.Text = endereço.Complemento;
                txtMunicipio.Text = endereço.Localidade;
                txtEstado.Text = endereço.Uf;

            }

            catch (Exception e)
            {
                MessageBox.Show("Falha! \n" + e.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
