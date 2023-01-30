﻿using System;
using System.Linq;
using System.IO;
using tpl.Runtime.Results;
using tpl.Engine;
using tpl.Engine.Core;
using tpl.Engine.Core.Analysis;
using tpl.Engine.Core.Loader;

namespace tpl.Runtime
{
    class MainClass
    {
        protected static TplEngine Engine = new TplEngine(new ScriptLoader(), new LoaderErrors(new InterpreterResult()));

        public static void Main(string[] args)
        {
            foreach (var Argitem in args.Select((value, index) => (value, index)))
            {
                if (Argitem.value is "-file")
                {
                    Engine.RegistryScript(args[Argitem.index + 1]);
                }
            }
            Engine.RunScript("test.tpl");
            Console.ReadKey(true);
        }
    }
}
