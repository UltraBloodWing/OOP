using System;
using SplashKitSDK;

namespace PassTask5
{
    public class Shape
    {
        private Color _color;
        private float _x;
        private float _y;
        private int _height;
        private int _width;

        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _height = 100;
            _width = 100;
        }

        public Color Color
        {
            get {return _color;}
            set{_color = value;}
        }

        public float X
        {
            get {return _x;}
            set{_x = value;}
        }

        public float Y
        {
            get {return _y;}
            set{_y = value;}
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

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Boolean IsAt(Point2D pt)
        {
            Rectangle rect = new Rectangle();
            rect.X = _x;
            rect.Y = _y;
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