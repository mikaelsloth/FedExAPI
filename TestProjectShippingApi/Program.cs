﻿namespace TestProjectShippingApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        internal static void Main(string[] args) 
        {
            var run = new ShippingUnitTest();
            run.Deserialize();
        }
    }
}
