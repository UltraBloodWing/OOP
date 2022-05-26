using System;
using SplashKitSDK;

namespace PassTask5
{
    public abstract class Shape
    {
        private Color _color;
        private float _x;
        private float _y;
        private Boolean _selected;

        public Shape():this(Color.White)
        {
        }
        public Shape(Color color)
        {
            _color = color;
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
        public Boolean Selected
        {
            get {return _selected;}
            set{_selected = value;}
        }
        public abstract void Draw();

        public abstract Boolean IsAt(Point2D pt);
        public abstract void DrawOutline();
    }
}