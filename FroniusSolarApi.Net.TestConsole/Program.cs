﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FroniusSolarApi.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var values = new FroniusSolarApi.SolarState("192.168.121.90", 1).GetValues();
                Console.WriteLine(string.Concat("Day-Energy: ", values.DayEnergy));
                Console.WriteLine(string.Concat("Current Power: ", values.CurrentPower));
                System.Threading.Thread.Sleep(2000);
            }


        }
    }
}