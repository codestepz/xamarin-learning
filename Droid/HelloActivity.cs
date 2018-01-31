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

namespace XamarinLearning.Droid {
    
    [Activity(Label = "HelloActivity", MainLauncher = true)]
    public class HelloActivity : Activity {
        
        protected override void OnCreate (Bundle savedInstanceState) {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Hello);

            TextView helloWorld = FindViewById<TextView>(Resource.Id.textView1);
            helloWorld.Text = "Xamarin Learning";
            helloWorld.TextSize = 15;

        }

    }

}