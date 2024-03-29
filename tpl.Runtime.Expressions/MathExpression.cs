﻿using System;
using System.Collections.Generic;
using tpl.Runtime.Expressions;

namespace tpl.Runtime.Expressions
{
    public unsafe sealed class MathExpression : Expression
    {
        // shunting yard algorithm

        /* Input -> Divide -> Stack(If is operator)
        *              |
        *              Output(If this number)
        */

        private Dictionary<string, int> _operatorsAndPrecedence = new Dictionary<string, int>()
        {
            {"o_sign", 4},
            {"o_div", 3},
            {"o_sub", 2},
            {"o_minus", 1},
            {"o_plus", 0},
        };

        public override int HowMany()
        {
            int Result;

            for (int pos = 0; pos < Input.Count; pos++)
            {
                var Token = Input[pos];

                if (int.TryParse(Token, out int Value))
                {
                    Output.Enqueue(Value.ToString());
                    continue;
                }

                if (_operatorsAndPrecedence.ContainsKey(Token))
                {

                }
            }

            return 0;
        }

        public override bool Equals(object obj) => base.Equals(obj);
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => base.ToString();
    }
}
