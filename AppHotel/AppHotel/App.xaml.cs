using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppHotel.View;
using AppHotel.Model;

namespace AppHotel
{
    public partial class App : Application
    {

        public List<Suite> Suites = new List<Suite>()
        {
            new Suite()
            {
                Descricao = "Super Luxo",
                ValorDiariaAdulto = 95.5,
                ValorDiariaCrianca = 45.5
            },

            new Suite()
            {
                Descricao = "Luxo",
                ValorDiariaAdulto = 80,
                ValorDiariaCrianca = 40
            },

            new Suite()
            {
                Descricao = "Pobre Premium (classe média)",
                ValorDiariaAdulto = 70.5,
                ValorDiariaCrianca = 35.5
            }
        };



        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "456"
            }

        };


        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            else
                MainPage = new Login();

           /* MainPage = new NavigationPage(new View.ContratacaoHospedagem()); */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}