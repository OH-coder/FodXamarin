using FodXamarin.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FodXamarin.ViewModels
{
    class InstructorDetailViewModel:BaseViewModel
    {
        private Instructor _instructorSelected;
    public ICommand callInstructor { get; private set; }
    public ICommand smsInstructor { get; private set; }
    public ICommand emailInstructor { get; private set; }
        public Instructor instructorSelected
        {
            get { return _instructorSelected; }
            set
            {
                SetProperty<Instructor>(ref _instructorSelected, value);
            }
        }
        public InstructorDetailViewModel(Instructor instructor)
        {
            instructorSelected = instructor;
            callInstructor = new Command(CallInstructor);
            smsInstructor = new Command(SendMessage);
            emailInstructor = new Command(SendEmail);
        }
        public void CallInstructor()
        {
            PhoneDialer.Open(instructorSelected.Phone);

        }
        public void SendMessage()
        {
            var message = new SmsMessage("", instructorSelected.Phone);
            Sms.ComposeAsync(message);

        }
        public void SendEmail()
        {
            var message = new EmailMessage("", "",instructorSelected.Email);
            Email.ComposeAsync(message);
        }
    }
}
