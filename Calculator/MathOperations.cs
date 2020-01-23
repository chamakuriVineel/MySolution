﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
        /// <summary>
        /// This method is used to divide two int type number.The first argument is divident and the second parameter is divisor.
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an integer</returns>
        /// <exception cref="System.DivideByZeroException"></exception>
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a/b;
        }
        /// <summary>
        /// This method is used to add two int type numbers.
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an integer</returns>
        /// <exception cref="System.OverflowException"></exception>
        public static int Addition(int a, int b)
        {
            long IntermediateResult = (long)a + (long)b;
            if (IntermediateResult > int.MaxValue||IntermediateResult<int.MinValue)
                throw new System.OverflowException("The result is overflowing the int type");
            return a + b;
        }
        /// <summary>
        /// This method is used to do substraction operation betweem two int types.
        /// Second parameter is substracted from first parameter
        /// </summary>
        /// <param name="a">This should be an integer</param>
        /// <param name="b">This should be an integer</param>
        /// <returns>This method returns an int type</returns>
        /// <exception cref="System.OverflowException"></exception>

        public static int Substraction(int a, int b)
        {
            long IntermediateResult = (long)a - (long)b;
            if (IntermediateResult > int.MaxValue || IntermediateResult < int.MinValue)
                throw new System.OverflowException();
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            

        }
    }
}
