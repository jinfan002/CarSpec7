using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSpec7.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public DelegateCommand NavToNextPage { get; set; }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _info1;
        public string Info1
        {
            get { return _info1; }
            set { SetProperty(ref _info1, value); }
        }

        private string _button1Text;
        public string Button1text
        {
            get { return _button1Text; }
            set { SetProperty(ref _button1Text, value); }
        }
        INavigationService _navigationservice;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
            Title = "CarSpecs7\n\n";
            Info1 = "The App that will help you and your car enthusiast needs! Look up car specs, pricing, mgh, mph, etc.\n\n\n";
            Button1text = "Start Searching";
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}

