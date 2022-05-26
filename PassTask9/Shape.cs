using System;
using SplashKitSDK;

namespace PassTask5{
    public class Shape{
        private Color _color;
        private float _x;
        private float _y;
        private int _height;
        private int _width;
        private Boolean _selected;
        
        public Shape():this(Color.Green,0,0,100,100){
           
        }

        public Shape(Color color, float x, float y, int width, int height){
            _color = color;
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public Color Color{
            get {return _color;}
            set{_color = value;}
        }

        public float X{
            get {return _x;}
            set{_x = value;}
        }

        public float Y{
            get {return _y;}
            set{_y = value;}
        }

        public int Height{
            get {return _height;}
            set{_height = value;}
        }

        public int Width{
            get {return _width;}
            set{_width = value;}
        }

        public Boolean Selected{
            get{ return _selected; }
            set{ _selected = value; }
        }

        public void Draw(){
            if(_selected == true){
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Boolean IsAt(Point2D pt){
            Rectangle rect = new Rectangle();
            rect.X = _x;
            rect.Y = _y;
            rect.Width = _width;
            rect.Height = _height;

            if(SplashKit.PointInRectangle(pt, rect)){
                return true;
            }
            else{
                return false;
            }
        }

        public void DrawOutline(){
            SplashKit.DrawRectangle(Color.Black,_x-2,_y-2,_width+4,_height+4);
        }
    }
}