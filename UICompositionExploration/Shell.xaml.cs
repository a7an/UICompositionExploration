using System.Collections.ObjectModel;
using UICompositionExploration.Pages;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UICompositionExploration
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        private ObservableCollection<NavigationItem> navigationItems;

        public Shell()
        {
            this.InitializeComponent();

            navigationItems = new ObservableCollection<NavigationItem>
            {
                new NavigationItem { Page = NavigationPage.DropShadow, Icon = "", Title = "DropShadow" },
                new NavigationItem { Page = NavigationPage.Scale, Icon = "", Title = "Scale" },
                new NavigationItem { Page = NavigationPage.Blur, Icon = "", Title = "Blur" }
            };

            HamburgerMenu.ItemsSource = navigationItems;
            HamburgerMenu.IsPaneOpen = true;
        }

        private void HamburgerMenu_OptionsItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void HamburgerMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menu = e.ClickedItem as NavigationItem;

            if (menu != null)
            {
                switch (menu.Page)
                {
                    case NavigationPage.DropShadow:
                        NavigationFrame.Navigate(typeof(DropShadowPage));

                        break;

                    case NavigationPage.Scale:
                        NavigationFrame.Navigate(typeof(ScalePage));
                        break;

                    case NavigationPage.Blur:
                        NavigationFrame.Navigate(typeof(BlurPage));
                        break;
                }
            }
        }
    }

    public enum NavigationPage
    {
        DropShadow,
        Scale,
        Blur
    }

    public sealed class NavigationItem
    {
        public NavigationPage Page { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
