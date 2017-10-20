using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Contatos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ////MainPage = new Contatos.MainPage();

            // Definir a página inicial da aplicação
            //MainPage = new Contatos.Pages.PessoaListaPage();
            MainPage = new NavigationPage(new Contatos.Pages.EventoListaPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
