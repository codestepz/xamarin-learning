using System;
using UIKit;

namespace XamarinLearning.iOS {
    
    public partial class BackScreen : BaseScreen {
        
        public BackScreen (IntPtr handle) : base(handle) { }

        public override void ViewDidLoad () {
            
            base.ViewDidLoad();

            // ปุ่ม Back
            BtnBack.TouchUpInside += delegate {
                this.NavigationController.PopViewController(true);
            };

        }

        public override void DidReceiveMemoryWarning () {
            base.DidReceiveMemoryWarning();
        }

    }

}