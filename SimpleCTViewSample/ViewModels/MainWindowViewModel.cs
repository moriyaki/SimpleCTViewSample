using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace SimpleCTViewSample.ViewModels
{
    public interface IMainWindowViewModel { }
    public partial class MainWindowViewModel : ObservableObject, IMainWindowViewModel
    {
        [ObservableProperty]
        private IViewModel currentViewModel;

        public MainControlViewModel MainControlVM { get; }
        public SettingsControlViewModel SettingsControlVM { get; }

        [RelayCommand]
        private void Settings()
        {
            CurrentViewModel = SettingsControlVM;
        }

        private readonly IMessenger _messenger;

        public MainWindowViewModel() { throw new NullReferenceException(nameof(MainWindowViewModel)); }
        public MainWindowViewModel(
            IMessenger messenger,
            MainControlViewModel mainControlVM,
            SettingsControlViewModel settingsControlVM)
        {
            _messenger = messenger;
            MainControlVM = mainControlVM;
            SettingsControlVM = settingsControlVM;

            currentViewModel = MainControlVM;

            _messenger.Register<QuitSettingsMessage>(this, (_, _) => CurrentViewModel = MainControlVM);
        }
    }
}
