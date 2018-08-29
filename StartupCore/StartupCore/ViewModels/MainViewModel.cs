using System;
using System.Threading.Tasks;
using StartupCore.Contracts.Services.General;
using StartupCore.ViewModels.Base;

namespace StartupCore.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private MenuViewModel _menuViewModel;

        public MainViewModel(IConnectionService connectionService,
            INavigationService navigationService, IDialogService dialogService,
            MenuViewModel menuViewModel)
            : base(connectionService, navigationService, dialogService)
        {
            _menuViewModel = menuViewModel;
        }

        public MenuViewModel MenuViewModel
        {
            get => _menuViewModel;
            set
            {
                _menuViewModel = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object data)
        {
            await Task.WhenAll
            (
                _menuViewModel.InitializeAsync(data),
                _navigationService.NavigateToAsync<HomeViewModel>()
            );
        }
    }
}
