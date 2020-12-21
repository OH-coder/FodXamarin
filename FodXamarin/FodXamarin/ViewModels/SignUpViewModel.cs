using FodXamarin.Models;
using FodXamarin.Views;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FodXamarin.ViewModels
{
    class SignUpViewModel:BaseViewModel
    {
        public ObservableCollection<StudentSignUp> comptes { get; private set; } = new ObservableCollection<StudentSignUp>();
        private StudentSignUp _compte;
        private readonly PageService _pageService;
       public ICommand SignUpCommand { get; private set; }
        public StudentSignUp compte
        {
            get { return _compte; }
            set
            {
                SetProperty<StudentSignUp>(ref _compte, value);
            }
        }
        public SignUpViewModel(PageService pageService)
        {
            this._pageService = pageService;
            SignUpCommand = new Command(async vm => await SignUp());
        }
        private async Task SignUp()
        {
            comptes.Add(_compte);
            await _pageService.PushAsync(new LoginPage(comptes));
        }
    }
    }
