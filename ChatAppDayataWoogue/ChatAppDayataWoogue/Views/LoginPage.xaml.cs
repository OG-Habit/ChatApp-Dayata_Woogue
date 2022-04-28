﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static ChatAppDayataWoogue.Constants;

namespace ChatAppDayataWoogue.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            bool IsPassword = EntryPassword.IsPassword;
            EntryPassword.IsPassword = !IsPassword;
            BtnTogglePasswordVisibility.Text = IsPassword ? "Hide" : "Show";
        }

        async void GoToSignup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }

        private void Login(object sender, EventArgs e)
        {
            if(App.Current.Properties[KEY_EMAIL].ToString().Equals(EntryEmail.Text) &&
                App.Current.Properties[KEY_PASSWORD].ToString().Equals(EntryPassword.Text))
            {
                App.Current.MainPage = new AppShell();
            }
        }
    }
}