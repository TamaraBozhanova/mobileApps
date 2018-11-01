using System;
using CoreGraphics;
using UIKit;

namespace AnotherAnim
{
    public partial class ViewController : UIViewController
    {
        private CGPoint StartPoint { get; set; }
        private UIView _figure;
        private bool flag = false;


        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           _figure = new UIView(new CGRect(View.Frame.Width / 2, 100, 50, 50));
            _figure.BackgroundColor = UIColor.Black;

            var recon = new UIPanGestureRecognizer(r =>
            {
                switch (r.State)
                {

                    case UIGestureRecognizerState.Possible:
                        break;
                    case UIGestureRecognizerState.Began:
                        StartPoint = r.LocationInView(r.View);

                        if (StartPoint.X > _figure.Frame.X && StartPoint.X < _figure.Frame.X + 50 && StartPoint.Y > _figure.Frame.Y && StartPoint.Y < _figure.Frame.Y + 100)
                        {
                            flag = true;
                        }


                        break;
                    case UIGestureRecognizerState.Changed:
                        if (flag == true)
                        {
                            StartPoint = r.LocationInView(r.View);
                            var frame = _figure.Frame;
                            frame.Y = StartPoint.Y - 50;

                            _figure.Frame = frame;

                        }
                        break;

                    case UIGestureRecognizerState.Ended:
                        flag = false;
                        break;
                    case UIGestureRecognizerState.Cancelled:

                        break;
                    case UIGestureRecognizerState.Failed:
                        break;
                }
            });

            View.AddGestureRecognizer(recon);
            View.AddSubview(_figure);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

        }

        partial void _btnPress_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.5f, 0, UIViewAnimationOptions.CurveEaseOut, () =>
            {
                var frame = _figure.Frame;
                var frameY = View.Frame.Height - frame.Y - 50;
                frame.Y += frameY;
                _figure.Frame = frame;
            }, null);
        }
    }
}
