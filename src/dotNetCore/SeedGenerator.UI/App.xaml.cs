using Avalonia;
using Avalonia.Markup.Xaml;

namespace SeedGenerator.UI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
