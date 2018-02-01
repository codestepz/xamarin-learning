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
    
    [Activity(Label = "MultiScreen", MainLauncher = true)]
    public class MultiScreen : BaseScreen {
        
        protected override void OnCreate(Bundle savedInstanceState) {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Multi);

            Button BtnNext = FindViewById<Button>(Resource.Id.BtnNext);
            BtnNext.Click += delegate {
                StartActivity(new Intent(this, typeof(BackScreen)));
            };

        }

    }

}