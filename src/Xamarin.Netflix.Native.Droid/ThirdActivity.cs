
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Netflix.Views;
using Xamarin.Forms.Platform.Android;
using FFImageLoading.Forms.Droid;
using Xamarin.Netflix.ViewModels;
using Xamarin.Netflix.Services.Profile;
using Xamarin.Netflix.Services.Navigation;

namespace Xamarin.Netflix.Native.Droid
{
    [Activity(Label = "ThirdActivity")]
    public class ThirdActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            CachedImageRenderer.Init();
            Forms.Forms.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.Third);

            var formsView = new LoginView2();

            var vm = new LoginViewModel(new ProfileService(), new NavigationService());
            vm.InitializeAsync(null);
            formsView.BindingContext = vm;

            var fragment = formsView.CreateFragment(this);

            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.frameLayout1, fragment);
            transaction.Commit();
        }
    }
}
