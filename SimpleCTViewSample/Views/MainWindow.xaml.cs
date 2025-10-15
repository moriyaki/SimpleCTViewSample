using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;
using SimpleCTViewSample.ViewModels;

namespace SimpleCTViewSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetService<IMainWindowViewModel>() ?? throw new NullReferenceException(nameof(IMainWindowViewModel));
        }
    }
}
