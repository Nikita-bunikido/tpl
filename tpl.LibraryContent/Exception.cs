﻿using System;
using tpl.Runtime.Results;

namespace tpl.LibraryContent
{
    public sealed class Exception
    {
        public static bool IsNumber(string text)
        {
            return int.TryParse(text, out int i);
        }

        public static string Lex(string text)
        {
            string ret = "";
            string word = "";
            foreach (var item in text)
            {
                if (char.IsWhiteSpace(item) || IsBracket(item.ToString()) || IsSemicolon(item.ToString()) || IsDot(item.ToString()) || IsSign(item.ToString()))
                {
                    word += $" {item}";
                    ret += $" {word}";
                    word = "";
                    continue;
                }
                word += $"{item}";
                continue;
            }
            return ret;
        }
    }
}
