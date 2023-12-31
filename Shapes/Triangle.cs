﻿using System;
using static System.Math;

namespace Figure_Calculator
{
    class Triangle : Shape
    {
        public override string Name { get; } = "Треугольник";
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        /// <summary>
        /// Фигура : Треугольник
        /// </summary>
        /// <param name="A">Сторона A</param>
        /// <param name="B">Сторона B</param>
        /// <param name="C">Сторона C</param>
        public Triangle(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        /// <summary>
        /// Функция, которая выполняет вычисления площади треугольников
        /// </summary>
        /// <returns>Возвращает площадь треугольника</returns>
        public override double Area()
        {
            //Проверка, каким является треугольник(Равно сторонний, равно бедренный, разно сторонний)
            if (A == B && B == C)
            {
                return Round((Pow(A, 2) * Sqrt(3)) / 4, 2);
            }
            else if (A == B || A == C || B == C)
            {
                return Round((Convert.ToDouble(C) / 4) * Sqrt(4 * Pow(A, 2) - Pow(C, 2)), 2);
            }
            else
            {
                double P;
                P = (A + B + C) / 2;
                return Round(Sqrt(P * (P - A) * (P - B) * (P - C)), 2);
            }
        }
        /// <summary>
        /// Функция, которая выполняет вычисления периметра треугольников
        /// </summary>
        /// <returns>Возвращает периметр треугольника</returns>
        public override double Perimeter()
        {
            return Round(A + B + C, 2);
        }
        /// <summary>
        /// Проверка - существует ли треугольник
        /// </summary>
        /// <returns>Возвращает истину или лож</returns>
        public bool IsValidate()
        {
            if (A + B >= C && A + C >= B && B + C >= A) return true;
            else return false;
        }
        public override string ToString()
        {
            return $"Треугольник: \n  A: {A}\n  B: {B}\n  C: {C}";
        }
        public override byte[] GetBytes()
        {
            return new byte[] { };
        }
    }
}
