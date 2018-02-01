using System;
using UIKit;

namespace XamarinLearning.iOS {
    
    public partial class MultiScreen : BaseScreen {
        
        public MultiScreen (IntPtr handle) : base(handle) { }

        public override void ViewDidLoad () {
            
            base.ViewDidLoad();

            // ปุ่ม Next
            BtnNext.TouchUpInside += delegate {
                BackScreen BackScreen = Storyboard.InstantiateViewController("BackScreen") as BackScreen;
                NavigationController.PushViewController(BackScreen, true);
            };

        }

        public override void DidReceiveMemoryWarning () {
            base.DidReceiveMemoryWarning();
        }

    }

}