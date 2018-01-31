using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinLearning.Droid {

    [Activity(Label = "HelloScreen", MainLauncher = true)]
    public class HelloAScreen : BaseScreen {

        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Hello);

            TextView helloWorld = FindViewById<TextView>(Resource.Id.textView1);
            helloWorld.Text = "CodeStep โค๊ดสเต็ป";
            helloWorld.TextSize = 25;

            TextView helloWorld2 = FindViewById<TextView>(Resource.Id.textView2);
            helloWorld2.Text = "CodeStep โค๊ดสเต็ป";
            helloWorld2.TextSize = 25;
            helloWorld2.Typeface = Typeface.CreateFromAsset(Assets, "Kanit-Regular.ttf");

        }

    }

}