using Android.App;
using Android.OS;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HelloXamarinFormsWorld.Droid
{
    [Activity(Label = "HelloXamarinFormsWorld", MainLauncher = true)]
	public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Microsoft.AppCenter.AppCenter.Start("0b093df6-9196-468a-a7a4-f55044f955f1",
                   typeof(Analytics), typeof(Crashes));
            Forms.Init(this, bundle);

			LoadApplication (new App ());
        }
    }
}
