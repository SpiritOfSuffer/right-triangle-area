using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAreaSearcherLib
{
    public class Searcher
    {
        //Метод находит площадь треугольника по формуле Герона. Общий вид формулы: S=sqrt(p(p-a)(p-b)(p-c)), где p - полупериметр
        public static double SearchArea(double FirstSide, double SecondSide, double ThirdSide)
        {
                double Semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2; //Находим полупериметр

                return Math.Sqrt(Semiperimeter * (Semiperimeter - FirstSide) * (Semiperimeter - SecondSide) * (Semiperimeter - ThirdSide));
        }

        //Метод определяет, корректны ли введенные данные
        public static bool DataAreCorrect(double FirstSide, double SecondSide, double ThirdSide)
        {
            return FirstSide > 0.0 && SecondSide > 0.0 && ThirdSide > 0.0;
        }

        //Метод определяет, является ли треугольник прямоугольным
        public static bool TriangleIsRight(double FirstSide, double SecondSide, double ThirdSide)
        {
            if (DataAreCorrect(FirstSide, SecondSide, ThirdSide))
            {
                bool IsRight = false;
                double[] data = new double[3] { FirstSide, SecondSide, ThirdSide }; //Массив из 3-х сторон треугольника
                Array.Sort(data); //Сортируем массив
                IsRight = (data[0] * data[0]) + (data[1] * data[1]) == data[2] * data[2]; //Определяем по теореме Пифагора, прямоугольный ли наш треугольник 

                return IsRight;
            }
            else
            {
                return false;
            }
        }
    }
}
