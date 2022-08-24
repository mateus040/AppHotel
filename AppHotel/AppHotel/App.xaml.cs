using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel
{
    public partial class App : Application
    {

         public List<Model.Suite> tipos_quartos = new List<Model.Suite>()
         {


             new Model.Suite()
             {
                 Descricao = "Suíte Super Luxo",
                 ValorDiariaAdulto = 110.0,
                 ValorDiariaCrianca = 55.0
             },

             new Model.Suite()
             {
                 Descricao = "Suíte Luxo",
                 ValorDiariaAdulto = 88.0,
                 ValorDiariaCrianca = 40.0
             },

             new Model.Suite()
             {
                 Descricao = "Suíte Single",
                 ValorDiariaAdulto = 50.0,
                 ValorDiariaCrianca = 25.0
             },

             new Model.Suite()
             {
                 Descricao = "Suíte Crise",
                 ValorDiariaAdulto = 25.0,
                 ValorDiariaCrianca = 12.5
             }
         };


        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            MainPage = new NavigationPage(new View.ContratacaoHospedagem());
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
