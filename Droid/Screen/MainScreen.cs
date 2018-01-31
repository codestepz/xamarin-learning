using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinLearning.Droid {
    
    [Activity(Label = "XamarinLearning", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainScreen : BaseScreen {
        
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState) {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += delegate { button.Text = $"{count++} clicks!"; };

        }

    }

}