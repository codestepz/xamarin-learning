
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

    [Activity(Label = "BaseScreen")]
    public class BaseScreen : Activity {

        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);

            // Set Layout
            SetContentView(Resource.Layout.Main);

        }

    }

}