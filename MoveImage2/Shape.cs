﻿namespace Form
{
    class Shape
    {
        private IShape shape;

        public Shape(IShape shape)
        {
            this.shape = shape;
        }

        public void MoveShape()
        {
            MoveImage moveImage = new MoveImage(shape);
            moveImage.MoveImg();
        }
    }
}