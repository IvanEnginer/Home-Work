﻿using System;

namespace Work4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint lineCopasity = 3;
            uint folderCopasity = 52;
            uint fullLines =folderCopasity / lineCopasity;
            Console.WriteLine("Full lines = " + fullLines);
        }
    }
}