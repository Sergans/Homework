﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2021, 02, 11, 19, 07, 45);
            //DateTime data = DateTime.Now; Вариант с текущей системной датой и временем 
            string name = "Сергей";

            Console.WriteLine($"Привет,{name},сегодня {data}");
        }
    }
}
