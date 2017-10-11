using Personalities.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Personalities
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Personality_Test : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public Personality_Test()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HubPage));

        }



        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HubPage));
        }


        private void btnYes(object sender, RoutedEventArgs e)
        {
            if (test_flipview.SelectedIndex < 14)
            {
                test_flipview.SelectedIndex++;
            }
            else
            {
                showResult();

            }

        }
        private void btnNo(object sender, RoutedEventArgs e)
        {
            if (test_flipview.SelectedIndex < 14)
            {
                test_flipview.SelectedIndex++;
            }
            else
            {
               showResult();
            }

        }
        public void showResult()
        {
            //CoreWindow currentWindow = Window.Current.CoreWindow;
            Random rnd = new Random();
            int num = rnd.Next(1, 17);
            BtnNo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            BtnYes.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            your_result.Text = num.ToString();
            if (num == 1)
            {
                your_result.Text = "INFP-The Healer";
            }
            else if (num == 2)
            {
                your_result.Text = "INFJ-The Counselor";
            }
            else if (num == 3)
            {
                your_result.Text = "INTP-The Architect";
            }
            else if (num == 4)
            {
                your_result.Text = "INTJ-The Mastermind";
            }
            else if (num == 5)
            {
                your_result.Text = "ISFP-The Composer";
            }
            else if (num == 6)
            {
                your_result.Text = "ISFJ-The Protector";
            }
            else if (num == 7)
            {
                your_result.Text = "ISTP-The Craftsman";
            }
            else if (num == 8)
            {
                your_result.Text = "ISTJ-The Inspector";
            }
            else if (num == 9)
            {
                your_result.Text = "ENFP-The Champion";
            }
            else if (num == 10)
            {
                your_result.Text = "ENFJ-The Teacher";
            }
            else if (num == 11)
            {
                your_result.Text = "ENTP-The Visionary";
            }
            else if (num == 12)
            {
                your_result.Text = "ENTJ-The Commander";
            }
            else if (num == 13)
            {
                your_result.Text = "ESFP-The Performer";
            }
            else if (num == 14)
            {
                your_result.Text = "ESFJ-The Provider";
            }
            else if (num == 15)
            {
                your_result.Text = "ESTP-The Dynamo";
            }
            else if (num == 16)
            {
                your_result.Text = "ESTJ-The Supervisor";
            }

            //personality_test_page.Height = Window.Current.CoreWindow.Bounds.Height;
            //personality_test_page.Width = Window.Current.CoreWindow.Bounds.Width;
            //personality_test_page.Margin = new Thickness(0, 0, 0, 0);
            //Make sure the background is visible
            personality_test_page.Visibility = Windows.UI.Xaml.Visibility.Visible;

            //Now we figure out where the center of the screen is, and we 
            //move the popup to that location.
            //popMessage.HorizontalOffset = (Window.Current.CoreWindow.Bounds.Width / 2) - (400 / 2);
            //popMessage.VerticalOffset = (Window.Current.CoreWindow.Bounds.Height / 2) - (150 / 2);
            popMessage.IsOpen = true;


        }
        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
    }
}
