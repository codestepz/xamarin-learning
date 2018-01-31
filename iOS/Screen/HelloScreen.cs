using System;
using UIKit;

namespace XamarinLearning.iOS {

    public partial class HelloScreen : BaseScreen {
        
        public HelloScreen (IntPtr handle) : base(handle) { }

        public override void ViewDidLoad () {
            
            base.ViewDidLoad();

            LabelHello.Text = "CodeStep โค๊ดสเต็ป";

            LabelHello_Kanit.Text = "CodeStep โค๊ดสเต็ป";
            LabelHello_Kanit.Font = UIFont.FromName("Kanit-Regular", 25f);

        }

        public override void DidReceiveMemoryWarning () {
            base.DidReceiveMemoryWarning();
        }

    }

}