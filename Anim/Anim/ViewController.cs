using System;
using CoreGraphics;
using CoreImage;
using UIKit;

namespace Anim
{
    public partial class ViewController : UIViewController
    {
        private UIView _sprite;
        private const float _step = 5f;
        private float _scale = 1f;
        private float _angleRotate = (float)Math.PI / 4;
        private bool _colorFlag = true;
        private bool _transformFlag = true;

        CGAffineTransform _transform;
       
        protected ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           _transform = CGAffineTransform.MakeIdentity();

            _sprite = new UIView(new CGRect(20, 50, 30, 30));
            _sprite.BackgroundColor = UIColor.Red;
            View.AddSubview(_sprite);

            var figure1 = new UIView(new CGRect(100, 60, 35, 65));
            figure1.BackgroundColor = UIColor.Black;
            View.AddSubview(figure1);

            var figure2 = new UIView(new CGRect(25, 150, 100, 40));
            figure2.BackgroundColor = UIColor.Black;
            View.AddSubview(figure2);

            var figure3 = new UIView(new CGRect(200, 120, 40, 90));
            figure3.BackgroundColor = UIColor.Black;
            figure3.Transform = CGAffineTransform.MakeRotation(0.5f);
            View.AddSubview(figure3);

            var figure4 = new UIView(new CGRect(75, 250, 105, 35));
            figure4.BackgroundColor = UIColor.Black;
            View.AddSubview(figure4);

            var figure9 = new UIView(new CGRect(25, 300, 120, 50));
            figure9.BackgroundColor = UIColor.Black;
            View.AddSubview(figure9);

            var figure7 = new UIView(new CGRect(160, 290, 200, 50));
            figure7.BackgroundColor = UIColor.Black;
            figure7.Layer.CornerRadius = figure7.Frame.Height / 2;
            figure7.Transform = CGAffineTransform.MakeRotation(-0.5f);
            View.AddSubview(figure7);

            var viewLine = new UIView()
            {

                Frame = new CGRect(0, (View.Frame.Height / 2) - 20, View.Frame.Width, 2),
                BackgroundColor = UIColor.Black
            };
            View.AddSubview(viewLine);

            var figure5 = new UIView(new CGRect(20, 400, 60, 100));
            figure5.BackgroundColor = UIColor.Green;
            figure5.Transform = CGAffineTransform.MakeRotation(-0.5f);
            View.AddSubview(figure5);

            var figure6 = new UIView(new CGRect(120, 460, 100, 100));
            figure6.BackgroundColor = UIColor.Green;
            figure6.Layer.CornerRadius = figure6.Frame.Width / 2;
            View.AddSubview(figure6); 

            var figure8 = new UIView(new CGRect(40, 580, 200, 50));
            figure8.BackgroundColor = UIColor.Green;
            figure8.Layer.CornerRadius = figure8.Frame.Height / 2;
            View.AddSubview(figure8);

            var _drawTriangle = new DrawTriangle
            {
                Frame = new CGRect(220, 410, 140, 130),
                BackgroundColor = UIColor.White
            };

            View.AddSubview(_drawTriangle);
        }

        partial void _btnRotate_TouchUpInside(UIButton sender)
        {
            _angleRotate += (float)(Math.PI / 4);
                UIView.Animate(0.1f, () =>
                {
                _transform.Rotate(_angleRotate);
                _sprite.Transform = _transform;

                });    
        }

        partial void _btnColor_TouchUpInside(UIButton sender)
        { if (_colorFlag == true)
            {
                UIView.Animate(0.1f, () =>
               {
                   _sprite.Layer.BackgroundColor = UIColor.Green.CGColor;

               });
                _colorFlag = false;
        } else if (_colorFlag == false)
           {
                UIView.Animate(0.1f, () =>
                {
                    _sprite.Layer.BackgroundColor = UIColor.Red.CGColor;

                });
                _colorFlag = true; 
            }
        }

        partial void _btnScalePlus_TouchUpInside(UIButton sender)
        {
            _scale += 0.2f;
          
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                _sprite.Transform = _transform;
            });
        }

        partial void _btnScaleMinus_TouchUpInside(UIButton sender)
        {
            _scale -= 0.2f;
            UIView.Animate(0.2f, () =>
            {
                _transform.Scale(_scale, _scale);
                _sprite.Transform = _transform;
            });
        }

        partial void _btnTrans_TouchUpInside(UIButton sender)
        {
            if (_transformFlag == true)
            {
                UIView.Animate(0.1f, () =>
            {

                _sprite.Layer.CornerRadius = _sprite.Frame.Width / 2;

            });
                _transformFlag = false;
            }
            else if(_transformFlag == false)
            {
                UIView.Animate(0.1f, () =>
                {

                    _sprite.Layer.CornerRadius = 0;
                });
                _transformFlag = true;
            }
        }

        partial void _btnLeft_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {

                var center = _sprite.Center;
                center.X -= _step;
                _sprite.Center = center;
            });
        }

        partial void BtnRight_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {

                var center = _sprite.Center;
                center.X += _step;
                _sprite.Center = center;
            });
        }

        partial void _btnDown_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {

                var center = _sprite.Center;
               center.Y += _step;
                _sprite.Center = center;
            });
        }

        partial void _btnUp_TouchUpInside(UIButton sender)
        {
            UIView.Animate(0.2f, () =>
            {

                var center = _sprite.Center;
                center.Y -= _step;
                _sprite.Center = center;
            });
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
