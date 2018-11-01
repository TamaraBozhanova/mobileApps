// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AnotherAnim
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnPress { get; set; }

        [Action ("_btnPress_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnPress_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (_btnPress != null) {
                _btnPress.Dispose ();
                _btnPress = null;
            }
        }
    }
}