using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace SmallBasicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //printExample1();
            //printExample2();
            printTort();
        }

        

             static void printExample1()
        {
            int i = 0;
            while (i < 4)
            {
                for (int j = 0; j < 2; j++)
                {
                    Turtle.Move(30);
                    Turtle.TurnRight();
                }
                for (int k = 0; k < 2; k++)
                {
                    Turtle.Move(30);
                    Turtle.TurnLeft();
                }
              
                i++;
            }

        }

             static void printExample2()
             {

                 for (int i = 0; i < 6; i++)
                 {
                     Turtle.Move(100);
                     Turtle.Turn(60);
                 }

             }

             static void printT(int size)
             {
                 Turtle.Move(size);
                 Turtle.TurnRight();
                 Turtle.Move(30);
                 Turtle.Angle = 270;
                 Turtle.Move(60);
             }
             static void printO(int size)
             {
                 for (int i = 0; i < 4; i++)
                 {
                     Turtle.Move(size);
                     Turtle.TurnRight();
                 }
             }
             static void printR(int size)
             {
                 Turtle.Move(size);

                 for (int i = 0; i < 3; i++)
                 {
                     Turtle.TurnRight();
                     Turtle.Move(size / 2);

                 }
             }     

             static void printTort()
             {
                 Turtle.X = 200;
                 Turtle.Y = 200;

                 printT(100);

                 Turtle.X = 260;
                 Turtle.Y = 200;
                 Turtle.Angle = 0;

                 printO(50);
                 Turtle.X = 360;
                 Turtle.Y = 200;
                 Turtle.Angle = 0;
                 printR(50);
                 Turtle.X = 450;
                 Turtle.Y = 200;
                 Turtle.Angle = 0;
                 printT(50);
             }

            
    }
}
