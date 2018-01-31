using System;
using UIKit;

namespace XamarinLearning.iOS {
    
    public partial class BaseScreen : UIViewController {
        
        public BaseScreen (IntPtr handle) : base(handle) { }

        public override void ViewDidLoad () {
            base.ViewDidLoad();
        }

        public override void DidReceiveMemoryWarning () {
            base.DidReceiveMemoryWarning();
        }

    }

}