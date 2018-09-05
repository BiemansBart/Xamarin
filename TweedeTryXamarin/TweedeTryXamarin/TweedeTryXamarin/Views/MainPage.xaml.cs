using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweedeTryXamarin.ViewModels;
using Xamarin.Forms;

namespace TweedeTryXamarin {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new TaskViewModel();

        }
    }
}
