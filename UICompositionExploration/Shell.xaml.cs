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
                new NavigationItem { Page = "DropShadow", Icon = "", Title = "DropShadow" },
                new NavigationItem { Page = "Scaling", Icon = "", Title = "Scaling" }
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
                    case "DropShadow":
                        NavigationFrame.Navigate(typeof(DropShadowPage));

                        break;

                    case "Scaling":
                        NavigationFrame.Navigate(typeof(ScalingPage));
                        break;

                }
            }
        }
    }

    public sealed class NavigationItem
    {
        public string Page { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
