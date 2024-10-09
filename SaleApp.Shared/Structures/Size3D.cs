using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Shared.Structures
{
    public struct Size3D
    {
        private float length;
        private float width;
        private float height;

        public Size3D()
        {

        }
        public Size3D(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public float Length { get { return length; } set { length = value; } }
        public float Width { get { return width; } set { width = value; } }
        public float Height { get { return height; } set { height = value; } }

        public float GetArea()
            => Width * Length;
        public float GetCube()
            => Length * Width * Height;
        public float GetCircumference()
            => Length * Width * 2;

    }
}
