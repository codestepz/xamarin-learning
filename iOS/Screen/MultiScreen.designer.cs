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
    [Register ("MultiScreen")]
    partial class MultiScreen
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnNext { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BtnNext != null) {
                BtnNext.Dispose ();
                BtnNext = null;
            }
        }
    }
}