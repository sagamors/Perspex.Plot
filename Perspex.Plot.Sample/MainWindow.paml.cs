using Perspex.Controls;
using Perspex.Markup.Xaml;

namespace Perspex.Plot.Sample
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            Content = new Axis();
          /*  this.InitializeComponent();*/
            App.AttachDevTools(this);
        }

        private void InitializeComponent()
        {
            PerspexXamlLoader.Load(this);
        }
    }
}
