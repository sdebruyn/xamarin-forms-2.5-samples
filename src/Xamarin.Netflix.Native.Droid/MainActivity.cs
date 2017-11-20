using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.Netflix.Native.Droid
{
    [Activity(Label = "Xamarin.Netflix.Native.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Text = "To second activity";
            button.Click += (sender, e) => 
            {
                StartActivity(typeof(SecondActivity));
            };
        }
    }
}

