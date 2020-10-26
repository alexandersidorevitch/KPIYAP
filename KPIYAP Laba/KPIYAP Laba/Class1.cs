using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIYAP_Laba
{

    struct Window
    {
        private static double width;
        private static double height;
        public double Width
        {
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Ширина не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение ширины");

                    this.Width = double.Parse(Console.ReadLine());

                }
                else
                {
                    width = value;
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Высота не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение высоты");
                    this.Height = double.Parse(Console.ReadLine());
                }
                else
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }
    }
    class Room
    {
        private static double width;
        private static double height;
        private static double lenght;
        private double lenght_of_rolls;
        private double width_of_rolls;
        private static int count_of_windows;
        private Window[] windows;

        private double LenghtOfRolls
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина рулона не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение длина");
                    this.LenghtOfRolls = double.Parse(Console.ReadLine());

                }
                else
                {
                    lenght_of_rolls = value;
                }
            }
            get
            {
                return lenght_of_rolls;
            }
        }
        private double WidthOfRolls
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина рулона не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение ширины");
                    this.WidthOfRolls = double.Parse(Console.ReadLine());

                }
                else
                {
                    width_of_rolls = value;
                }
            }
            get
            {
                return width_of_rolls;
            }
        }
        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение ширины");
                    this.Width = double.Parse(Console.ReadLine());

                }
                else
                {
                    width = value;
                }
            }
            get
            {
                return width;
            }
        }
        private double Height
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Высота не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение высоты");
                    this.Height = double.Parse(Console.ReadLine());
                }
                else
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }
        private double Lenght
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина не может быть равна 0 или быть отрицательной");
                    Console.WriteLine("Введите новое значение длины");
                    this.Lenght = double.Parse(Console.ReadLine());
                }
                else
                {
                    lenght = value;
                }
            }
            get
            {
                return lenght;
            }
        }
        private int countOfWindows
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кол-во окон не может быть отрицательной");
                    Console.WriteLine("Введите новое кол-во окон");
                    this.countOfWindows = int.Parse(Console.ReadLine());
                }
                else
                {
                    count_of_windows = value;
                }
            }
            get
            {
                return count_of_windows;
            }
        }



        public void SetWindowsSize()
        {
            for (int i = 0; i < count_of_windows; i++)
            {
                Console.WriteLine($"Введите ширину окна номер {i + 1}");
                windows[i].Width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Введите высоту окна номер {i + 1}");
                windows[i].Height = double.Parse(Console.ReadLine());
            }
        }
        private double GetSquareOfWindows()
        {
            double totalSquare = 0;
            for (int i = 0; i < count_of_windows; i++)
            {
                totalSquare += windows[i].Width * windows[i].Height;
            }
            if (totalSquare >= GetSquareOfRoom())
            {
                Console.WriteLine("Площадь окон не может быть площади стен");
                return 0;
            }
            return totalSquare;
        }
        public double GetSquareOfRoom()
        {
            return (width + height) * lenght * 2;
        }

        public double GetSquareForGluing()
        {
            return GetSquareOfRoom() - GetSquareOfWindows();
        }

        private double GetSquareOfRolls()
        {
            return lenght_of_rolls * width_of_rolls;

        }
        public int CountOfRolls()
        {
            return (int)Math.Ceiling(GetSquareForGluing() / GetSquareOfRolls());
        }
        public Room(double width, double height, double lenght) : this(width, height, lenght, 0)
        {
        }
        public Room(double width, double height, double lenght, int count_of_windows) : this(width, height, lenght, count_of_windows, 0.53, 10)
        { 
        }
        public Room(double width, double height, double lenght, int count_of_windows, double width_of_rolls, double lenght_of_rolls)
        {
            this.Width = width;
            this.Height = height;
            this.Lenght = lenght;
            this.countOfWindows = count_of_windows;
            this.windows = new Window[count_of_windows];
            this.WidthOfRolls = width_of_rolls;
            this.LenghtOfRolls = lenght_of_rolls;

        }


    }
}
