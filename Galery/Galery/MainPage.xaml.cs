using Galery.Pages;
using Galery.ViewModels;

namespace Galery
{
    public partial class MainPage : BasePage
    {
        public MainPage(BaseViewModel vm) : base(vm)
        {
            BindingContext = vm;
            InitializeComponent();
        }
    }
}