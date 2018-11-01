// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Anim
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView _ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnColor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnLeft { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnRotate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnScaleMinus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnScalePlus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnTrans { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _btnUp { get; set; }

        [Action ("_btnColor_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnColor_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnDown_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnDown_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnLeft_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnLeft_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnRight_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnRight_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnRotate_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnRotate_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnScaleMinus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnScaleMinus_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnScalePlus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnScalePlus_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnTrans_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnTrans_TouchUpInside (UIKit.UIButton sender);

        [Action ("_btnUp_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _btnUp_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (_ != null) {
                _.Dispose ();
                _ = null;
            }

            if (_btnColor != null) {
                _btnColor.Dispose ();
                _btnColor = null;
            }

            if (_btnDown != null) {
                _btnDown.Dispose ();
                _btnDown = null;
            }

            if (_btnLeft != null) {
                _btnLeft.Dispose ();
                _btnLeft = null;
            }

            if (_btnRight != null) {
                _btnRight.Dispose ();
                _btnRight = null;
            }

            if (_btnRotate != null) {
                _btnRotate.Dispose ();
                _btnRotate = null;
            }

            if (_btnScaleMinus != null) {
                _btnScaleMinus.Dispose ();
                _btnScaleMinus = null;
            }

            if (_btnScalePlus != null) {
                _btnScalePlus.Dispose ();
                _btnScalePlus = null;
            }

            if (_btnTrans != null) {
                _btnTrans.Dispose ();
                _btnTrans = null;
            }

            if (_btnUp != null) {
                _btnUp.Dispose ();
                _btnUp = null;
            }
        }
    }
}