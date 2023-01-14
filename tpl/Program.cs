﻿using System;
using System.Linq;
using System.IO;
using tpl.Interplitator;

namespace tpl
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var Argitem in args.Select((value, index) => (value, index)))
            {
                switch (Argitem.value)
                {
                    case "-run":
                        try
                        {
                            Compiler.RuninSafeMod(File.ReadAllText(args[Argitem.index+1]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Branch arg not defined");
                        }
                        break;

                    case "-debug":
                        try
                        {
                            Compiler.RuninSafeMod(File.ReadAllText(args[Argitem.index+1]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Branch arg not defined");
                        }
                        break;

                    default:
                        break;
                }
            }
            Compiler.RuninSafeMod(System.IO.File.ReadAllText("test.tpl"));
            Console.ReadKey(true);
        }
    }
}
