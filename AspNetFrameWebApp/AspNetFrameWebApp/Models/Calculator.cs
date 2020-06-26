using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFrameWebApp.Models
{
    public class Calculator
    {
        public int Sum(params int[] values)
        {
            return values.Sum();
        }
    }
}