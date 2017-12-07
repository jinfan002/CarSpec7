using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CarSpec7.ViewModels
{
    public class NextPage2ViewModel : BindableBase, INavigationAware
    {
        // public NextPage2ViewModel()
        //{}
        public DelegateCommand NavToThirdPage { get; set; }
        public DelegateCommand GoBackCommand { get; set; }
        private string _text1;
        public string Text1
        {
            get { return _text1; }
            set { SetProperty(ref _text1, value); }

        }
        private int _year;
        public int Year
        {
            get { return _year; }
            set { SetProperty(ref _year, value); }
        }
        private string _maket;
        public string Maket
        {
            get { return _maket; }
            set { SetProperty(ref _maket, value); }
        }
        private string _modelt;
        public string ModelT
        {
            get { return _modelt; }
            set { SetProperty(ref _modelt, value); }
        }
        private string _moru;
        public string MorU
        {
            get { return _moru; }
            set { SetProperty(ref _moru, value); }
        }
        private string _nextpage2;
        public string NextPage2
        {
            get { return _nextpage2; }
            set { SetProperty(ref _nextpage2, value); }
        }
        INavigationService _navigationservice;

        public NextPage2ViewModel(INavigationService navigationService)
        {
            _navigationservice = navigationService;
            Text1 = "Enter Car Details";
            Maket = "Car Make";
            ModelT = "Car Model";
            MorU = "Metric or US Units for measurement";
            NextPage2 = "Get specs for car";
            GoBackCommand = new DelegateCommand(GoBack);
        }
        private void GoBack()
        {
            _navigationservice.GoBackAsync();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        //private async void NavToThirdPage()
        //{

        //}
        /*internal async void GetCarInformation()
        {
            string url = "https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/440?format=json";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var tmp = client.GetAsync(url).Result;
                //if (tmp.IsSuccessStatusCode)
                  //  var result = tmp.Content.ReadAsStringAsync();
            }
            catch (Exception err)
            {
                // error handling
            }
        }*/


    }
}
