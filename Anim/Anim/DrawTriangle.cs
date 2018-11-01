using System;
using CoreGraphics;
using UIKit;

namespace Anim
{
    public class DrawTriangle : UIView
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            using (CGContext g = UIGraphics.GetCurrentContext())
            {

                //set up drawing attributes
                g.SetLineWidth(10);
                UIColor.Green.SetFill();
                UIColor.Red.SetStroke();

                //create geometry
                var path = new CGPath();

                path.AddLines(new CGPoint[]{
                    new CGPoint (10, 20),
                    new CGPoint (70, 110),
                    new CGPoint (130, 20)});

                path.CloseSubpath();

                //add geometry to graphics context and draw it
                g.AddPath(path);
                g.DrawPath(CGPathDrawingMode.FillStroke);
            }
        }
    }
}
