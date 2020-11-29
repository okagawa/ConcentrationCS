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

namespace ConcentrationCS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel flipCountLabel { get; set; }

        [Action ("touchCard:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void touchCard (UIKit.UIButton sender);

        [Action ("touchCard2:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void touchCard2 (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (flipCountLabel != null) {
                flipCountLabel.Dispose ();
                flipCountLabel = null;
            }
        }
    }
}