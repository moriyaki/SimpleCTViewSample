using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace SimpleCTViewSample.ViewModels
{
    public record QuitSettingsMessage();

    public partial class SettingsControlViewModel : ObservableObject, IViewModel
    {
        [RelayCommand]
        private void QuitSetting()
        {
            _messenger.Send<QuitSettingsMessage>();
        }

        private readonly IMessenger _messenger;

        public SettingsControlViewModel() { throw new NullReferenceException(nameof(SettingsControlViewModel)); }
        public SettingsControlViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }
    }
}
