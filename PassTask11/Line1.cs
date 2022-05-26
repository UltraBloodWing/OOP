using System;
using SplashKitSDK;

namespace PassTask5{
    public class Line1:Shape{
        private float _endX;
        private float _endY;
        public Line1():this(Color.Green,0,0,0,0){
            
        }
        public Line1(Color color,float starX, float starY, float endX, float endY):base(color){
            X = starX;
            Y = starY;
            _endX = endX;
            _endY = endY;
        }
        public float EndX{
            get{return _endX;}
            set{_endX = value;}
        }
        public float EndY{
            get{return _endY;}
            set{_endY = value;}
        }
        public override void Draw()
        {
            if(Selected)
                DrawOutline();
            SplashKit.DrawLine(Color,X,Y,EndX,EndY);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black,X,Y,5);
            SplashKit.DrawCircle(Color.Black,_endX,_endY,5);
        }
        public override bool IsAt(Point2D pt)
        {
            Line line = new Line();

            Point2D strPoint = new Point2D();
            strPoint.X = X;
            strPoint.Y = Y;

            Point2D endPoint = new Point2D();
            endPoint.X = _endX;
            endPoint.Y = _endY;

            line.StartPoint = strPoint;
            line.EndPoint = endPoint;
            
            if (SplashKit.PointOnLine(pt,line)){
                return true;
            }else{
                return false;
            }
        }
    }
}




