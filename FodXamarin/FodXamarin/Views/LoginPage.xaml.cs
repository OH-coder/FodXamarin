using FodXamarin.Models;
using FodXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FodXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        
     
        public LoginPage(ObservableCollection<StudentSignUp> students)
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(students);
        }
    }
}