using FodXamarin.Models;
using FodXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FodXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new InstructorViewModel(new PageService());
            
        }
        protected override void OnAppearing()
        {
             base.OnAppearing();
           

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (BindingContext as InstructorViewModel).selectInstructorCommand.Execute(e.SelectedItem as Instructor);
        }
    }
}
