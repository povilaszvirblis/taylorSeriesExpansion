﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaylorSeries.MathSAF.MathSAF.TaylorSeriesExpansionsAPI;

namespace TaylorSeries.MathSAF.MathSAF.TaylorSeriesExpansions.TrigonometricalExpansions.HiperbolicalExpansions
{
    class HiperbolicalCoshExpansion : ITaylorExpansion
    {

        private double Number
        {
            set;
            get;
        }
        private double Error
        {
            set;
            get;
        }
        public HiperbolicalCoshExpansion(double error, double number)
        {
            this.Error = error;
            this.Number = number;
        }
        public Result Calculate()
        {
            ITaylorExpansion exponentialCalc1; //TODO: e^number, error
            ITaylorExpansion exponentialCalc2;//TODO: e^-number, error
            Result result = new Result();

           // result.Answer = (exponentialCalc1.Calculate().Answer + exponentialCalc2.Calculate().Answer) / 2;
            return result;
        }
    }
}
