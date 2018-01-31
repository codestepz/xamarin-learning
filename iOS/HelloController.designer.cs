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
    [Register ("HelloController")]
    partial class HelloController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHello { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelHello != null) {
                LabelHello.Dispose ();
                LabelHello = null;
            }
        }
    }
}