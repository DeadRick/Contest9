    using System;

    class IntegralCalculator
    {
        public static void InsertParameter(int param)
        {
            if (param == 0) Program.func = Sin;
            else if (param == 1) Program.func = Cos;
            else Program.func = Tan;
        }

        public static double GetSin(double x)
        {
            return Math.Sin(x);
        }
        public static double GetCos(double x)
        {
            return Math.Cos(x);
        }
        public static double GetTan(double x)
        {
            return Math.Tan(x);
        }
        public static double Sin(double a, double b)
        {
            double sum = 0;
            double step = Program.EPS;
            if ( (b <= a + step) && a < b)
            {
                sum = (GetSin(a) + GetSin(b)) * (b - a) / 2;
            }
            for (double i = a + step; i < b; i += step)
            {
                sum += (GetSin(i - step) + GetSin(i)) * step / 2;
                if (i + step >= b)
                {
                    sum += (GetSin(i) + GetSin(b)) * (b - i) / 2;
                }
            }
            return sum;
        }                                                       
        public static double Cos(double a, double b)
        {
            double sum = 0;
            double step = Program.EPS;
            if ((b <= a + step) && a < b)
            {
                sum = (GetCos(a) + GetCos(b)) * (b - a) / 2;
            }
            for (double i = a + step; i < b; i += step)
            {
                sum += (GetCos(i - step) + GetCos(i)) * step / 2;
                if (i + step >= b)
                {
                    sum += (GetCos(i) + GetCos(b)) * (b - i) / 2;
                }
            }
            return sum;
        }
        public static double Tan(double a, double b)
        {
            double sum = 0;
            double step = Program.EPS;
            if ((b <= a + step) && a < b)
            {
                sum = (GetTan(a) + GetTan(b)) * (b - a) / 2;
            }
            for (double i = a + step; i < b; i += step)
            {
                sum += (GetTan(i - step) + GetTan(i)) * step / 2;
                if (i + step >= b)
                {
                    sum += (GetTan(i) + GetTan(b)) * (b - i) / 2;
                }
            }
            return sum;
        }
    }