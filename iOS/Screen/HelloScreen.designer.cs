// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinLearning.iOS
{
    [Register ("HelloScreen")]
    partial class HelloScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHello { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHello_Kanit { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelHello != null) {
                LabelHello.Dispose ();
                LabelHello = null;
            }

            if (LabelHello_Kanit != null) {
                LabelHello_Kanit.Dispose ();
                LabelHello_Kanit = null;
            }
        }
    }
}