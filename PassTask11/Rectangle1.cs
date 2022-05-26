using System;
using SplashKitSDK;

namespace PassTask5{
    public class Rectangle1:Shape{
        
        private int _height;
        private int _width;

        public Rectangle1():this(Color.Green,0,0,100,100){ 

        } 
        public Rectangle1(Color color,float x, float y, int width, int height):base(color){
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }
        public int Height
        {
            get {return _height;}
            set{_height = value;}
        }

        public int Width
        {
            get {return _width;}
            set{_width = value;}
        }
        public override void Draw()
        {
            if(Selected)
                DrawOutline();
            
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X-2, Y-2, _width+4, _height+4);
        }
        public override bool IsAt(Point2D pt)
        {
            Rectangle rect = new Rectangle();
            rect.X = X;
            rect.Y = Y;
            rect.Width = _width;
            rect.Height = _height;

            if(SplashKit.PointInRectangle(pt, rect))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}