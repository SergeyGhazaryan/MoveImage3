﻿using System;

namespace Form
{
    class RectangleBuilder : IFigureBuilder
    {
        private IShape shape;
        public IShape Create()
        {
            bool notNumber = true;
            while (notNumber)
            {
                Console.WriteLine("Enter height and width of the rectangle.");
                Console.WriteLine();
                Console.Write("Height: ");
                string h = Console.ReadLine();
                bool number1 = int.TryParse(h, out int height);
                Console.Write("Width: ");
                string w = Console.ReadLine();
                bool number2 = int.TryParse(w, out int width);
                if (number1 && number2)
                {
                    Console.WriteLine();
                    shape = new Rectangle(height, width);
                    notNumber = false;
                }
                else 
                {
                    Console.WriteLine("You must enter a number.");
                }
            }
            return shape;
        }
    }
}