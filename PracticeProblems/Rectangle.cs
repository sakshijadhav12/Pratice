using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Rectangle
    {
        public double Lenght;
        public double Width;
        public double area;
        public double perimeter;


        public  void Set(double len , double widhth)
        {
            Lenght = len;
            Width=widhth;
        }
        public double getLen()
        {
            return Lenght;
        }
        public double getWidth() 
        {
            return Width;
        }
        public void Calculate()
        {
            area = Lenght * Width;
            perimeter = 2 * (Lenght + Width);
        }
        public void show()
        {
            Console.WriteLine("lenght is :" + Lenght);
            Console.WriteLine("Width is : "+ Width);
            Console.WriteLine("area:" +  area);
            Console.WriteLine("perimter:" + perimeter);

        }
            
    }
}
