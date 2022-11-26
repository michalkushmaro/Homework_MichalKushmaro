using System;
namespace Homework_MichalKushmaro.Client.Shared.Models.OOP
{
    public class MyRectagle
    {

        public string color { get; set; }
        public double height { get; set; }
        public double width { get; set; }

public double Area()
        {
            double Area1 = height * width;
            return Area1;
        }

        public double Perimeter()
        {
            double Perimeter1 = height + height + width + width;
            return Perimeter1;


        }

    }
    }


