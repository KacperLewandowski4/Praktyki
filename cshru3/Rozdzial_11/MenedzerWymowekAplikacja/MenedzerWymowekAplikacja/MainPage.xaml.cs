using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace MenedzerWymowekAplikacja
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : MenedzerWymowekAplikacja.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void OpenButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenExcuseAsync();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsync();
        }

        private void NewExcuseButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.NewExcuseAsync();
        }

        private void SaveAsButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SaveCurrentExcuseAsAsync();
        }

        private void SetToCurrentTimeClick(object sender, RoutedEventArgs e)
        {
            excuseManager.SetToCurrentTime();
        }

        private void RandomExcuseButtonClick(object sender, RoutedEventArgs e)
        {
            excuseManager.OpenRandomExcuseAsync();
        }

        private async void FolderButtonClick(object sender, RoutedEventArgs e)
        {
            bool folderChosen = await excuseManager.ChooseNewFolderAsync();
            if (folderChosen)
            {
                saveButton.IsEnabled = true;
                randomButton.IsEnabled = true;
            }
        }
    }
}
