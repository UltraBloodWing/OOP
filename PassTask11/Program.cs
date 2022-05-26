using System;
using SplashKitSDK;

namespace PassTask5
{

    public class Program
    {
        private enum ShapeKind{
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
    
            Window shapeWindow = new Window("GameMain", 800, 600);

            ShapeKind kindToAdd = ShapeKind.Circle;

            Drawing myDrawing = new Drawing();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                if(SplashKit.KeyTyped(KeyCode.RKey)){
                    kindToAdd = ShapeKind.Rectangle;
                }else if(SplashKit.KeyTyped(KeyCode.CKey)){
                    kindToAdd = ShapeKind.Circle;
                }else if(SplashKit.KeyTyped(KeyCode.LKey)){
                    kindToAdd = ShapeKind.Line;
                }

                if(SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;  
                    
                    if(kindToAdd == ShapeKind.Circle){
                        Circle1 newCircle = new Circle1();
                        newShape = newCircle;
                    }else if(kindToAdd == ShapeKind.Line){
                        Line1 newLine = new Line1();
                        newLine.EndX = SplashKit.MouseX()+150;
                        newLine.EndY = SplashKit.MouseY()+150;
                        newShape = newLine;
                    }
                    else{
                        Rectangle1 newRect = new Rectangle1();  
                        newShape = newRect;
                    }
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    myDrawing.AddShape(newShape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }

                if(SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapeAt(SplashKit.MousePosition());
                }

                if(SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }

                myDrawing.Draw();

                SplashKit.RefreshScreen(60);

            }while(! SplashKit.QuitRequested());
        }
    }

}