﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.FactoryMethod
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }
}
