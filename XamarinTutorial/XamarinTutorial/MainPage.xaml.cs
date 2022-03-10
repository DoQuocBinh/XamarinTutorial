using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        async void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            await DisplayAlert("Alert", $"Dear, you have changed to {text}", "OK");
        }


        bool flag = false;
        private void Save_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                (sender as Button).Text = "Click me again!";
            }
            else
            {
                (sender as Button).Text = "Click me!";
            }
            flag = !flag;         
        }
    }
}
