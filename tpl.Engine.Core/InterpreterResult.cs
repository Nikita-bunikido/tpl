﻿using System.Collections;
using System.Collections.Generic;
using tpl.Core;
using tpl.Engine.Core;

namespace tpl.Runtime.Results
{
    public sealed class InterpreterResult
    {
        public List<string> ErrorsList { get; set; } = new List<string>();
        public List<Token> FrontentDebug { get; set; } = new List<Token>();
        public List<Node> BackendDebug { get; set; } = new List<Node>();
    }
}
