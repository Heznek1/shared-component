﻿using System;

namespace Shared.Utils
{
    public static class EnumParserUtils
    {
        public static T ToEnumType<T>(this int input)
        {
            var result = Enum.Parse(typeof(T), Convert.ToString(input));
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}