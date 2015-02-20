﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method that adds two polynomials.
// Represent them as arrays of their coefficients.

namespace _11.AddingPolinomials
{
    class Program
    {
        static void PrintPolynom(decimal[] polynom)
        {
            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                if (polynom[i] != 0 && i != 0)
                {
                    if (polynom[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} + ", i, polynom[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0}  ", i, polynom[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynom[i]);
                }
            }
            Console.WriteLine();
        }
        
        static decimal[] SumPolynoms(decimal[] first, decimal[] second, decimal[] result)
        {
            if (first.Length > second.Length)
            {
                return SumPolynoms(second, first, result);
            }

            int i = 0;

            while (i < first.Length)
            {
                result[i] = first[i] + second[i];
                i++;
            }

            while (i < second.Length)
            {
                result[i] = second[i];
                i++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            decimal[] firstPolynom = { 5, -1 };
            decimal[] secondPolynom = { 10, -5, 6 };
            decimal[] result = new decimal[Math.Max(firstPolynom.Length, secondPolynom.Length)];

            Console.Write("First polynom:   ");
            PrintPolynom(firstPolynom);
            Console.Write("Second polynom:   ");
            PrintPolynom(secondPolynom);
            result = SumPolynoms(firstPolynom, secondPolynom, result);
            Console.Write("Sum               ");
            PrintPolynom(result);
        }
    }
}
