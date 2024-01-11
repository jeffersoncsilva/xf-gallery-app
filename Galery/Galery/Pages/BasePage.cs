using Galery.ViewModels;
using Xamarin.Forms;

namespace Galery.Pages
{
    public abstract class BasePage : ContentPage
    {
        private readonly BaseViewModel vm;
        
        public BasePage(BaseViewModel vm)
        {
            this.vm = vm; 
            BindingContext = vm;
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.OnAppearing();
        }
        
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            vm.OnDisappearing();
        }
        
        protected override bool OnBackButtonPressed()
        {
            return vm.OnBackButtonPressed();
        }
    }
}