using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace PassTask5
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing():this(Color.White)
        {

        }

        public List<Shape> Shapes
        {
            get {return _shapes;}
        }
        public Color Background
        {
            get {return _background;}
            set {_background = value;}
        }
        public int ShapeCount
        {
            get {return _shapes.Count;}
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
        }

        public void SelectShapeAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if(s.IsAt(pt) == true)
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result;
                result = new List<Shape>();
                foreach(Shape s in _shapes)
                {
                    if(s.Selected == true)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }
        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }
    }
}