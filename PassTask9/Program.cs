using System;
using SplashKitSDK;

namespace PassTask5{
    public class Program{
        public static void Main(){
            Window shapeWindow = new Window("GameMain", 800, 600);

            Drawing myDrawing = new Drawing();

            do{
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                if(SplashKit.MouseClicked(MouseButton.LeftButton)){
                    Shape s = new Shape();
                    s.X = SplashKit.MouseX();
                    s.Y = SplashKit.MouseY();
                    myDrawing.AddShape(s);
                }

                if(SplashKit.KeyTyped(KeyCode.SpaceKey)){
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }

                if(SplashKit.MouseClicked(MouseButton.RightButton)){
                    myDrawing.SelectShapeAt(SplashKit.MousePosition());
                }

                if(SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey)){
                    foreach(Shape s in myDrawing.SelectedShapes){
                        myDrawing.RemoveShape(s);
                    }
                }

                myDrawing.Draw();
 
                SplashKit.RefreshScreen(60);

            }
            while(! SplashKit.QuitRequested());
        }
    }
}