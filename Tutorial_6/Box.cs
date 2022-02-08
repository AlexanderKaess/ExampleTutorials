using System;

namespace Tutorial_6
{
    class Box
    {
        //member variables
        int length;
        int volume;

        //properties
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public int FrontSide
        {
            get => Height * Length;
        }

        //constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.Height = height;
            this.Width = width;
            Console.WriteLine("Object of BOX is created");
        }

        //method
        public void DisplayInfo()
        {
            volume = Length * Height * Width;
            Console.WriteLine("The length is {0}, the height is {1}, the width is {2} and the volume is {3}", Length, Height, Width, volume);
        }
    }
}
