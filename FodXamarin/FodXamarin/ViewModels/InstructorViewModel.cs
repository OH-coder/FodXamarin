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
    class InstructorViewModel:BaseViewModel
    {
       public ObservableCollection<Instructor> instructors { get; private set; } = new ObservableCollection<Instructor>() { 
       
           new Instructor("omar htiwech","English","tunisian","Male","29055186","omar.htiwech@iit.ens.tn","Ingineer","software Developper","bla bla","5 years of java and .net developping","20$/hour","xamarin","Sfax","omar.jpg"),
       
           new Instructor("Manel Ben Rached","Frensh","Tunisian","Female","22154785","manel.benrached@iit.ens.tn","ingineer","software developper","graduated from iit with honors worked as a devop engineer","5 years","20$/hour","Dev ops","Sfax","manel.jpg")
       
       
       };
      private Instructor _selectedInstructor;
        public ICommand selectInstructorCommand { get; private set; }
        private readonly PageService _pageService;
        public InstructorViewModel(PageService pageservice)
        {
            this._pageService = pageservice;
            selectInstructorCommand = new Command<Instructor>(async vm=> await selectInstructor(vm));
        }
        public Instructor selectedInstructor
        {
            get { return _selectedInstructor; }
            set
            {
                SetProperty<Instructor>(ref _selectedInstructor, value);
            }
        }
         public async Task selectInstructor(Instructor instructor)
        {
            if (instructor == null)
                return;
            selectedInstructor = null;
             await _pageService.PushAsync(new InstructorDetails(instructor));

        }
    }
}
