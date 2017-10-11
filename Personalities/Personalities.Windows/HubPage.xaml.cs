﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Personalities.Data;
using Personalities.Common;

// The Universal Hub Application project template is documented at http://go.microsoft.com/fwlink/?LinkID=391955

namespace Personalities
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HubPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// Gets the NavigationHelper used to aid in navigation and process lifetime management.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the DefaultViewModel. This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        public HubPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Create an appropriate data model for your problem domain to replace the sample data
            var sampleDataGroup = await SampleDataSource.GetGroupAsync("Group-4");
            this.DefaultViewModel["Section3Items"] = sampleDataGroup;
        }

        /// <summary>
        /// Invoked when a HubSection header is clicked.
        /// </summary>
        /// <param name="sender">The Hub that contains the HubSection whose header was clicked.</param>
        /// <param name="e">Event data that describes how the click was initiated.</param>
        

        /// <summary>
        /// Invoked when an item within a section is clicked.
        /// </summary>
        /// <param name="sender">The GridView or ListView
        /// displaying the item clicked.</param>
        /// <param name="e">Event data that describes the item clicked.</param>
       
        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void infp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(infp));
        }
        private void infj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(infj));
        }
        private void intj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(intj));
        }
        private void intp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(intp));
        }
        private void isfj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(isfj));
        }
        private void isfp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(isfp));
        }
        private void istj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(istj));
        }
        private void istp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(istp));
        }
        private void enfj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(enfj));
        }
        private void enfp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(enfp));
        }
        private void entj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(entj));
        }
        private void entp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(entp));
        }
        private void esfj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(esfj));
        }
        private void esfp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(esfp));
        }
        private void estj(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(estj));
        }
        private void estp(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(estp));
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Personality_Test));
        }
    }
}