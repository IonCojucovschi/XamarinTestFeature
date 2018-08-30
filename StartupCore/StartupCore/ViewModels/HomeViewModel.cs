using System;
using System.Windows.Input;
using Xamarin.Forms;
using StartupCore.Models.BooksModels;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using StartupCore.Contracts.Services.General;
using StartupCore.Contracts.Services.Data;
using StartupCore.ViewModels.Base;
using StartupCore.Extensions;

namespace StartupCore.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IBooksDataService _catalogDataService;
        private ObservableCollection<CategoryContent> _allCategory;

        public HomeViewModel(IConnectionService connectionService,
            INavigationService navigationService,
            IDialogService dialogService,
            IBooksDataService catalogDataService) : base(connectionService, navigationService, dialogService)
        {
            _catalogDataService = catalogDataService;

            AllCategory = new ObservableCollection<CategoryContent>();
        }

        public ICommand PieTappedCommand => new Command<Booklist>(OnPieTapped);
        public ICommand AddToCartCommand => new Command<Booklist>(OnAddToCart);

        public ObservableCollection<CategoryContent> AllCategory
        {
            get => _allCategory;
            set
            {
                _allCategory = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object data)
        {
            AllCategory = (await _catalogDataService.GetCategories()).ToObservableCollection();
        }

        private void OnPieTapped(Booklist selectedBook)
        {
            /// _navigationService.NavigateToAsync<BookDetailViewModel>(selectedBook);
        }

        private async void OnAddToCart(Booklist selectedPie)
        {
            //MessagingCenter.Send(this, MessagingConstants.AddPieToBasket, selectedPie);
            //await _dialogService.ShowDialog("Pie added to your cart", "Success", "OK");
        }
    }
}
