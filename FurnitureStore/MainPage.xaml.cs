using FurnitureStore.Models;
using FurnitureStore.ViewModels;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FurnitureStore
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SetCategory(CategoryGrid.Children[0] as Label);
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var Name = ((Label)((StackLayout)((Grid)sender).Children[2]).Children[0]).Text;
            var selectedItem = ((this.BindingContext) as MainPageViewModel).Items.Where(
                                item => item.Name == Name).ToList()[0];
            
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, selectedItem.Name);
            Navigation.PushAsync(new ProductDetailsPage(selectedItem));

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var lbl = sender as Label;
            var label = SetCategory(lbl);
            ((this.BindingContext) as MainPageViewModel).DoThing(lbl.Text);
            // move the selection bar to the tapped item
            SelectionIndicator.TranslateTo(label.X, 0, 250, Easing.CubicInOut);
            SelectionIndicator.WidthRequest = label.Width;
            SelectionIndicator.HorizontalOptions = LayoutOptions.Center;
            SelectionIndicator.Margin = new Thickness(0, 0, 40, 0);
        }

        private Label SetCategory (Label label)
        {
            // set all the styles to deselected
            foreach (var item in CategoryGrid.Children)
            {
                if (item is Label)
                {
                    item.Style = (Style)Application.Current.Resources["CategoryHeaderStyle"];
                }
            }

            // set the selected items style
            label.Style = (Style)Application.Current.Resources["CategorySelectedHeaderStyle"];
            return label;
        }
    }
}
