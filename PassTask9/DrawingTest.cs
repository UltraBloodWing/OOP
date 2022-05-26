using System;
using System.Collections.Generic;
using SplashKitSDK;
using NUnit.Framework;

namespace PassTask5{
    [TestFixture()]
    public class DrawingTest{
        [Test()]
        public void TestingDefaultInitialization(){
            Drawing myDrawing = new Drawing();
            Assert.AreEqual(myDrawing.Background, Color.White);
        }

       [Test()]
        public void TestInitializeWithColor(){
            Drawing myDrawing = new Drawing(Color.Green);
            Assert.AreEqual(myDrawing.Background,Color.Green);
        }
        [Test()]
        public void TestAddShape(){
            Drawing myDrawing = new Drawing();
            int count = myDrawing.ShapeCount;

            Assert.AreEqual(0,count);

            myDrawing.AddShape(new Shape());
            myDrawing.AddShape(new Shape());

            count = myDrawing.ShapeCount;

            Assert.AreEqual(2,count);
        }

        [Test()]
        public void TestSelectShape(){
            Drawing myDrawing = new Drawing();
            Shape[] testShapes = {
                new Shape(Color.Red,25,25,50,50),
                new Shape(Color.Green,25,10,50,50),
                new Shape(Color.Blue,10,25,50,50)
            };

            foreach(Shape s in testShapes){
                myDrawing.AddShape(s);
            }

            List<Shape> selected;
            Point2D point;

            point = SplashKit.PointAt(70,70);
            myDrawing.SelectShapeAt(point);
            selected = myDrawing.SelectedShapes;
            CollectionAssert.Contains(selected,testShapes[0]);
            Assert.AreEqual(1, selected.Count);

            point = SplashKit.PointAt(70,50);
            myDrawing.SelectShapeAt(point);
            selected = myDrawing.SelectedShapes;
            CollectionAssert.Contains(selected,testShapes[0]);
            CollectionAssert.Contains(selected,testShapes[1]);
            Assert.AreEqual(2, selected.Count);
        }

        [Test()]
        public void TestRemoveShape(){
            Drawing myDrawing = new Drawing();
            Shape[] testShapes = {
                new Shape(Color.Red,25,25,50,50),
                new Shape(Color.Green,25,10,50,50),
                new Shape(Color.Blue,10,25,50,50)
            };

            foreach(Shape s in testShapes){
                myDrawing.AddShape(s);
            }

            List<Shape> selected;
            Point2D point;

            point = SplashKit.PointAt(70,70);
            myDrawing.SelectShapeAt(point);
            selected = myDrawing.SelectedShapes;
            CollectionAssert.Contains(selected,testShapes[0]);
            Assert.AreEqual(1, selected.Count);

            myDrawing.RemoveShape(testShapes[0]);
            selected = myDrawing.SelectedShapes;
            CollectionAssert.DoesNotContain(selected,testShapes[0]);
            Assert.AreEqual(0,selected.Count); 
        }
    }
}
