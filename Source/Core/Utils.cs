﻿using System;
using System.Text;

namespace Galifee.Core
{
    public static class Utils
    {
        internal static string RandomString()
        {
            var rndm = new Random();
            string chars = "abcdefghijklmopqrstuvwxyzabcdefghijklmnopqrstuvwxyz_-";
            var length = rndm.Next(5, 10);

            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(chars[rndm.Next(0, chars.Length)]);
            }

            return sb.ToString();
        }
    }
}