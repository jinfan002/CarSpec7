using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Unity;
using CarSpec7.Views;

namespace CarSpec7
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
       
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"MainPage");

        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NextPage2>();
        }
    }
}

