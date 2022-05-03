﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    public  class Liskov
    {
        
            public static void LiskovMain()
            {
                Rectangle rectangle = new Square(10, 5);
                Console.WriteLine(rectangle.Area);
                Console.Read();
            }
    }

        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public virtual int Height { get; set; }
            public virtual int Width { get; set; }
            public int Area
            {
                get
                {
                    return Height * Width;
                }
            }
        }


        class Square : Rectangle
        {
            public Square(int width, int height) : base(width, height)
            {
            }

            public override int Width
            {
                get
                {
                    return base.Width;
                }
                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }
            public override int Height
            {
                get
                {
                    return base.Height;
                }
                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }
    
}
