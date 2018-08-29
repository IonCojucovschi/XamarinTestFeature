using System;
using Xamarin.Forms;
using StartupCore.Enumeration;

namespace StartupCore.Models
{
    public class MainMenuItem : BindableObject
    {
        private string _menuText;
        private StartupCore.Enumeration.MenuItemType _menuItemType;
        private Type _viewModelToLoad;

        public StartupCore.Enumeration.MenuItemType MenuItemType
        {
            get
            {
                return _menuItemType;
            }
            set
            {
                _menuItemType = value;
                OnPropertyChanged();
            }
        }

        public string MenuText
        {
            get
            {
                return _menuText;
            }
            set
            {
                _menuText = value;
                OnPropertyChanged();
            }
        }

        public Type ViewModelToLoad
        {
            get
            {
                return _viewModelToLoad;
            }
            set
            {
                _viewModelToLoad = value;
                OnPropertyChanged();
            }
        }
    }
}
