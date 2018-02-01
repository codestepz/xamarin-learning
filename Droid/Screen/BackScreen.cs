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
    
    [Activity(Label = "BackScreen")]
    public class BackScreen : BaseScreen {
        
        protected override void OnCreate (Bundle savedInstanceState) {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Back);

            // ปุ่ม Back
            Button BtnBack = FindViewById<Button>(Resource.Id.BtnBack);
            BtnBack.Click += delegate {
                this.Finish();
            };

        }

    }

}