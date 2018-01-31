using System;
using UIKit;

namespace XamarinLearning.iOS {
    
    public partial class HelloController : UIViewController {
        
        public HelloController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad() {
            
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            LabelHello.Text = "Xamarin Learning";

        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }

}