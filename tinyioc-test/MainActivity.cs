using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace tinyioctest
{
    [Activity(Label = "tinyioc-test", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public MainActivity()
        {
            var container = TinyIoC.TinyIoCContainer.Current;

            container.Register<ITest, Test>();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
			
            button.Click += delegate
                {
                    StartActivity(typeof(TestActivity));    
                };
        }
    }
}


