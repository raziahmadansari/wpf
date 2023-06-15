using ModernUI.Core;

namespace ModernUI.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;

        public HomeViewModel HomeViewModel { get; set; }

        public DiscoveryViewModel DiscoveryViewModel { get; set; }

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeViewModel = new HomeViewModel();
            DiscoveryViewModel = new DiscoveryViewModel();
            CurrentView = HomeViewModel;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeViewModel;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryViewModel;
            });
        }
    }
}
