using FodXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FodXamarin.ViewModels
{
    class MyDto
    {
        #region Singleton Pattern
        private MyDto()
        {
        }
        
        public static MyDto Instance { get; } = new MyDto();
        #endregion
        private ObservableCollection<StudentSignUp> _comptes;
        public ObservableCollection<StudentSignUp> comptes
        {
            get { return _comptes; }
            set { _comptes = value; }
        }
    }
}
