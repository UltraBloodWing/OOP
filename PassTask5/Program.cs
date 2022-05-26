using System;
using SplashKitSDK;

namespace PassTask5
{

    public class Program
    {
        public static void Main()
        {
    
            Window shapeWindow = new Window("GameMain", 800, 600);

            Shape myShape = new Shape();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);
                myShape.Draw();

                if(SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }

                if(myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = SplashKit.RandomRGBColor(255);
                }

                SplashKit.RefreshScreen(60);

            }while(! SplashKit.QuitRequested());
        }
    }

}