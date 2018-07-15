﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Plugin.TabView;
using Xamarin.Forms;

namespace TabViewSample
{
    public partial class MainPage : ContentPage
    {
        TabViewControl tabView;
        public MainPage()
        {
            InitializeComponent();

            string imageFilename = null;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    imageFilename = "Icon-Small-40.png";
                    break;
                case Device.Android:
                    imageFilename = "icon.png";
                    break;
                case Device.UWP:
                    imageFilename = "Assets/StoreLogo.png";
                    break;
            }

            tabView = new TabViewControl(new List<TabItem>()
            {
                new TabItem("Tab 1", new Label{Text = "Tab 1", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Red}, ImageSource.FromFile(imageFilename)),
                new TabItem("Tab 2", new Label{Text = "Tab 2", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Green}, ImageSource.FromFile(imageFilename)),
                new TabItem("Tab 3", new Label{Text = "Tab 3", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Blue}, ImageSource.FromFile(imageFilename)),
            });
            tabView.VerticalOptions = LayoutOptions.FillAndExpand;
            theSl.Children.Add(tabView);

            tabView.PositionChanged += TabView_PositionChanged;
            tabView.PositionChanging += TabView_PositionChanging; ;

        }

        private void TabView_PositionChanging(object sender, PositionChangingEventArgs e)
        {

        }

        private void TabView_PositionChanged(object sender, PositionChangedEventArgs e)
        {

        }

        private void Button_Next(object sender, EventArgs e)
        {
            tabView.SelectNext();
        }

        private void Button_First(object sender, EventArgs e)
        {
            tabView.SelectFirst();
        }

        private void Button_Previous(object sender, EventArgs e)
        {
            tabView.SelectPrevious();
        }

        private void Button_Last(object sender, EventArgs e)
        {
            tabView.SelectLast();
        }

        private void Button_AddTab(object sender, EventArgs e)
        {
            tabView.AddTab(new TabItem("New", new Label { Text = "New", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, BackgroundColor = Color.Red }));
        }

        private void Button_RemoveLastTab(object sender, EventArgs e)
        {
            tabView.RemoveTab(tabView.ItemSource.Count - 1);
        }

        private void Button_ChangeTextColor(object sender, EventArgs e)
        {
            tabView.HeaderTabTextColor = tabView.HeaderTabTextColor == Color.LightGreen ? Color.White : Color.LightGreen;
        }

        private void Button_ChangeBackgroundColor(object sender, EventArgs e)
        {
            tabView.HeaderBackgroundColor = tabView.HeaderBackgroundColor == Color.Black ? Color.Blue : Color.Black;
        }

        private void Button_ChangeSelectionUnderlineColor(object sender, EventArgs e)
        {
            tabView.HeaderSelectionUnderlineColor = tabView.HeaderSelectionUnderlineColor == Color.Yellow ? Color.White : Color.Yellow;
        }

        private void Button_ChangeSelectionUnderlineThickness(object sender, EventArgs e)
        {
            tabView.HeaderSelectionUnderlineThickness = tabView.HeaderSelectionUnderlineThickness + 5;
        }

        private void Button_ChangeSelectionUnderlineWidth(object sender, EventArgs e)
        {
            tabView.HeaderSelectionUnderlineWidth = tabView.HeaderSelectionUnderlineWidth + 10;
        }

        private void Button_ChangeTabTextFontSize(object sender, EventArgs e)
        {
            tabView.HeaderTabTextFontSize = tabView.HeaderTabTextFontSize + 1;
        }

        private void Button_ChangeTabTextFontAttributes(object sender, EventArgs e)
        {
            tabView.HeaderTabTextFontAttributes = tabView.HeaderTabTextFontAttributes == FontAttributes.Bold ? FontAttributes.Italic : FontAttributes.Bold;
        }

        private void Button_ChangeTabTextFontFamily(object sender, EventArgs e)
        {
            tabView.HeaderTabTextFontFamily = tabView.HeaderTabTextFontFamily == "Droid Sans Mono" ? "Comic Sans MS" : "Droid Sans Mono";
        }

        private async void GoToXamlSample(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new XamlSamplePage());
        }
    }
}