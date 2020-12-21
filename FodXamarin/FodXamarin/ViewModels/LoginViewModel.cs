using FodXamarin.Models;
using FodXamarin.Views;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FodXamarin.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private ObservableCollection<StudentSignUp> _students { get; set; } = new ObservableCollection<StudentSignUp>();

        public LoginViewModel(ObservableCollection<StudentSignUp> students)
        {
            this._students = students;
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                SetProperty<string>(ref email, value);

            }

        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                SetProperty<string>(ref password, value);

            }
        }
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }

        }
        public Command SignUpCommand
        {
            get
            {
                return new Command(goToSignUp);
            }
        }
        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                foreach (StudentSignUp compte in _students)
                {
                    if (Email=="omar.htiwech@iit.ens.tn" && Password=="1234")
                    {
                        App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                        App.Current.MainPage.Navigation.PushAsync(new HomePage());
                    }
                    else
                        App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");

                }
            }
        }
        private void goToSignUp()
        {
            App.Current.MainPage.Navigation.PushAsync(new SignUp());
        }
    }
}

