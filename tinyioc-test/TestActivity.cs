
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

namespace tinyioctest
{
    [Activity(Label = "TestActivity")]			
    public class TestActivity : Activity
    {
        public ITest Test { get; set; }

        public TestActivity()
        {
            Test = TinyIoC.TinyIoCContainer.Current.Resolve<ITest>();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            Console.WriteLine(Test.DoWork());
        }
    }
}

