using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Serviço.Modelo;
using App01_ConsultarCEP.Serviço;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {

            // TODO - Lógica d oprograma.



            // TODO - validações.
            string cep = CEP.Text.Trim();
            Endereco end = ViaCepServiso.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Lagradouro: {0}\nComplemento: {1}\nBairro: {2}\nCidade: {3}\nUF: {4}", end.logradouro, end.complemento, end.bairro, end.localidade, end.uf);
        }

    }



}
