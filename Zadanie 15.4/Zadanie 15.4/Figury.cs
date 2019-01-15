using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_15._4
{
    static class Figury
    {
        static public double KoloPole(double r)
        {
            double pole = Math.PI * r * r;
            return pole;
        }
        static public  double KoloObw(double r)
        {
            double obw = 2 * Math.PI * r;
            return obw;
        }
        static public double KwadratPole(double x)
        {
            double pole = x * x;
            return pole;
        }
        static public double KwadratObw(double x)
        {
            double obw = 4 * x;
            return obw;
        }
        static public double ProstokatPole(double x, double y)
        {
            double pole = x*y;
            return pole;
        }
        static public double ProstokatObw(double x, double y)
        {
            double obw = 2 * x + 2 * y;
            return obw;
        }
        static public double TrojkatPole(double a, double h)
        {
            double pole = (a * h) / 2;
            return pole;
        }
        static public double TrojkatObw(double a, double b,double c)
        {
            double obw = a + b + c;
            return obw;
        }
        static public double RownologlobokPole(double a, double h)
        {
            double pole = a * h;
            return pole;
        }
        static public double RownoleglobokObw(double a, double b)
        {
            double obw = 2 * a + 2 * b;
            return obw;
        }
        static public double RombPole(double e,double f)
        {
            double pole = (e * f) / 2;
            return pole;
        }
        static public double RombObw(double x)
        {
            double obw = 4 * x;
            return obw;
        }
        static public double TrapezPole(double a,double b,double h)
        {
            double pole = (a + b) * h / 2;
            return pole;
        }
        static public double TrapezObw(double a,double b, double c, double d)
        {
            double obw = a + b + c + d;
            return obw;

        }
        static public double Odlegloc(double a,double b, double c,double d)
        {
            double dlugosc = Math.Sqrt(Math.Pow(2, (c - a)) + Math.Pow(2, (d - b)));
            return dlugosc;
        }
    }
}
