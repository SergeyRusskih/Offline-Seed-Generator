using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeedGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly RandomSeedGenerator _generator = new RandomSeedGenerator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Seed.Text);
        }

        private void GenerateNewSeed(object sender, RoutedEventArgs e)
        {
            Seed.Text = _generator.CreateNewSeed();
            CopyToClipboard.Visibility = Visibility.Visible;
        }
    }
}
