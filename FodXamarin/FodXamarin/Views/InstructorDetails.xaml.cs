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
    public partial class InstructorDetails : ContentPage
    {
        public InstructorDetails(Instructor instructor)
        {
            
            InitializeComponent();
            BindingContext = new InstructorDetailViewModel(instructor);


        }

    }
}