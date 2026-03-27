//using Microsoft.Extensions.DependencyInjection;

namespace App01NumeroDaSorte
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell()); // original

            // código abaixo para mostrar nome do probrama na barra de titulo ao inver do nome do projeto
            var window = new Window(new MainPage());
            window.Title = AppInfo.Name;
            return window;
        }
    }
}