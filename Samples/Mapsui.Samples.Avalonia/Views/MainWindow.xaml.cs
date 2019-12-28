using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BruTile.Predefined;
using Mapsui.Layers;

namespace Mapsui.Samples.Avalonia.Views
{
    public class MainWindow : Window
    {
        Mapsui.UI.Avalonia.MapControl Map;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Map = this.FindControl<Mapsui.UI.Avalonia.MapControl>("map");
            Map.Map.Layers.Add(new TileLayer(KnownTileSources.Create()));

            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
